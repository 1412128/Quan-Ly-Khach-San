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
    public partial class QLConNguoi : MetroFramework.Forms.MetroForm
    {

        NhanVienBUS NvBus;
        int state = -1;   
        public QLConNguoi()
        {
            InitializeComponent();

            txtIdNV.Text = Global.Instance().idNhanVien();

            dataGrdV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGrdV.AllowUserToResizeRows = false;
            txtIdNV.ReadOnly = true;  

            NvBus = new NhanVienBUS();
            DocDuLieu(NvBus.LayDuDieu());         
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
            DocDuLieu(NvBus.LayDuDieu());
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            NhanVienDTO idxNV = NvBus.LayThongTinNhanVien(index);            

            txtIdNV.Text = idxNV.IdNhanVien.ToString();
            txtIdNV.ReadOnly = true;
            txtTenNV.Text = idxNV.TenNhanVien.ToString();
            txtCMND.Text = idxNV.Cmnd.ToString();
            txtNgaySinh.Text = idxNV.NgaySinh;
            cbbChucVu.Text = idxNV.ChucVu.ToString();           
            txtLuong.Text = idxNV.Luong.ToString();

            state = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ID Nhân Viên: " + index, "Xóa Nhân Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!NvBus.XoaThongTinKNhanVien(index))
                {
                    MessageBox.Show("Xóa thông tin nhân viên thất bại", "Thất bại",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DocDuLieu(NvBus.LayDuDieu());
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
            txtIdNV.Text = Global.Instance().idNhanVien();

            txtTenNV.Text = "";
            cbbChucVu.SelectedIndex = -1;
            txtCMND.Text = "";
            txtLuong.Text = "";
            txtNgaySinh.Text = "";           
            

            state = 1;
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (this.state == 0)
            {
                //Cap nhat
                if (string.IsNullOrWhiteSpace(txtIdNV.Text) ||
                string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(txtNgaySinh.Text) ||
                string.IsNullOrWhiteSpace(txtCMND.Text) ||
                string.IsNullOrWhiteSpace(cbbChucVu.Text) ||
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
                        MessageBox.Show("Lương và CMND phải là số", "Lỗi thông tin",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        NhanVienDTO _data = new NhanVienDTO();
                        _data.IdNhanVien = txtIdNV.Text;                   
                        _data.TenNhanVien = txtTenNV.Text;
                        _data.NgaySinh = txtNgaySinh.Text;
                        _data.Cmnd = Int32.Parse(txtCMND.Text);
                        _data.ChucVu = cbbChucVu.Text;                       
                        _data.Luong = Int32.Parse(txtLuong.Text);                        

                        if (!NvBus.CapNhatThongTinNhanVien(_data))
                        {
                            MessageBox.Show("Cập nhật thông tin nhân viên vào cơ sở dữ liệu thất bại", "Thất bại",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DocDuLieu(NvBus.LayDuDieu());
                            MessageBox.Show("Thông tin nhên viên đã được cập nhật vào cơ sở dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            else
            if (this.state == 1)
            {
                //Them
                if (string.IsNullOrWhiteSpace(txtIdNV.Text) ||
                string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(txtNgaySinh.Text) ||
                string.IsNullOrWhiteSpace(txtCMND.Text) ||
                string.IsNullOrWhiteSpace(cbbChucVu.Text) ||
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
                        MessageBox.Show("Lương và CMND phải là số", "Lỗi thông tin",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        NhanVienDTO _data = new NhanVienDTO();
                        _data.IdNhanVien = txtIdNV.Text;
                        _data.TenNhanVien = txtTenNV.Text;
                        _data.NgaySinh = txtNgaySinh.Text;
                        _data.Cmnd = Int32.Parse(txtCMND.Text);
                        _data.ChucVu = cbbChucVu.Text;
                        _data.Luong = Int32.Parse(txtLuong.Text);


                        if (!NvBus.ThemThongTinNhanVien(_data))
                        {
                            MessageBox.Show("Thông tin nhân viên thêm vào cơ sở dữ liệu thất bại", "Thất bại",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DocDuLieu(NvBus.LayDuDieu());
                            MessageBox.Show("Thông tin nhên viên đã được thêm vào cơ sở dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

            }
            btnNhapLai_Click(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DocDuLieu(NvBus.LayDuDieuTheoDieuKien(txtTimKiem.Text.ToUpper()));
        }
    }
}
