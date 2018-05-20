using QLKS.BUS;
using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class QLKhachHang : MetroFramework.Forms.MetroForm
    {
        KhachHangBUS _bus;
        public QLKhachHang()
        {
            InitializeComponent();

            dataGrdV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGrdV.AllowUserToResizeRows = false;
            txtIdNV.Enabled = false;
            txtCMND.Enabled = false;
            txtLuong.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtTenNV.Enabled = false;

            _bus = new KhachHangBUS();
            DocDuLieu(_bus.LayDuDieu());
        }
        public void DocDuLieu(DataTable dt)
        {
            dataGrdV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrdV.DataSource = dt;
            dataGrdV.AllowUserToAddRows = false;
            dataGrdV.Dock = DockStyle.Bottom;
            dataGrdV.AllowUserToResizeColumns = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DocDuLieu(_bus.LayDuDieu());
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            KhachHangDTO idxNV = _bus.LayThongTinKhachHang(index);

            txtIdNV.Text = idxNV.IdKhachHang.ToString();
            txtIdNV.ReadOnly = true;
            txtTenNV.Text = idxNV.HoTen.ToString();
            txtCMND.Text = idxNV.Cmnd.ToString();
            txtNgaySinh.Text = idxNV.NgaySinh;          
            txtLuong.Text = idxNV.Sdt.ToString();

            txtCMND.Enabled = true;
            txtLuong.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtTenNV.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ID Nhân Viên: " + index, "Xóa Nhân Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!_bus.XoaThongTinKhachHang(index))
                {
                    MessageBox.Show("Xóa thông tin nhân viên thất bại", "Thất bại",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DocDuLieu(_bus.LayDuDieu());
                    MessageBox.Show("Xóa thông tin nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtIdNV.Text = "";
            txtTenNV.Text = "";          
            txtCMND.Text = "";
            txtLuong.Text = "";
            txtNgaySinh.Text = "";

            txtCMND.Enabled = true;
            txtLuong.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtTenNV.Enabled = true;


        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtCMND.Enabled = false;
            txtLuong.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtTenNV.Enabled = false;

            //Cap nhat
            if (string.IsNullOrWhiteSpace(txtIdNV.Text) ||
            string.IsNullOrWhiteSpace(txtTenNV.Text) ||
            string.IsNullOrWhiteSpace(txtNgaySinh.Text) ||
            string.IsNullOrWhiteSpace(txtCMND.Text) ||   
            string.IsNullOrWhiteSpace(txtLuong.Text)
           )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của dịch vụ", "Lỗi thông tin",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!txtLuong.Text.All(char.IsDigit) || !txtCMND.Text.All(char.IsDigit))
                {
                    MessageBox.Show("SDT và CMND phải là số", "Lỗi thông tin",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    KhachHangDTO _data = new KhachHangDTO();
                    _data.IdKhachHang = txtIdNV.Text;
                    _data.HoTen = txtTenNV.Text;
                    _data.NgaySinh = txtNgaySinh.Text;
                    _data.Cmnd = Int32.Parse(txtCMND.Text);                   
                    _data.Sdt = Int32.Parse(txtLuong.Text);

                    if (!_bus.CapNhatThongTinKhachHang(_data))
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên vào cơ sở dữ liệu thất bại", "Thất bại",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DocDuLieu(_bus.LayDuDieu());
                        MessageBox.Show("Thông tin nhên viên đã được cập nhật vào cơ sở dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }



            btnNhapLai_Click(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DocDuLieu(_bus.LayDuDieuTheoDieuKien(txtTimKiem.Text.ToUpper()));
        }
    }
}
