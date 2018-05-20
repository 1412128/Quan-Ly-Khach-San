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
    public partial class QLDichVu : MetroFramework.Forms.MetroForm
    {
        DichVuBUS dvBus;
        int state = -1;
        public QLDichVu()
        {
            InitializeComponent();
            txtIdPhong.Text = Global.Instance().idDichVu();
            dataGrdV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGrdV.AllowUserToResizeRows = false;
            txtIdPhong.ReadOnly = true;

            dvBus = new DichVuBUS();
            DocDuLieu(dvBus.LayDuDieu());
            state = 1;
        }

        #region Layout  

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
            DocDuLieu(dvBus.LayDuDieu());
        }


        #endregion

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            DichVuDTO idxDichVu = dvBus.LayThongTinDichVu(index);

            txtIdPhong.Text = idxDichVu.IdDichVu.ToString();
            txtIdPhong.ReadOnly = true;
            txtTenPhong.Text = idxDichVu.TenDichVu;
            cbbTrangThai.Text = idxDichVu.TinhTrang;
            txtDonGia.Text = idxDichVu.Gia.ToString();

            state = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ID Dịch Vụ: " + index, "Xóa Dịch Vụ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!dvBus.XoaThongTinDichVu(index))
                {
                    MessageBox.Show("Xóa thông tin dịch vụ thất bại", "Thất bại",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DocDuLieu(dvBus.LayDuDieu());
                    MessageBox.Show("Xóa thông tin dịch vụ thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (this.state == 0)
            {
                //Cap nhat
                if (string.IsNullOrWhiteSpace(txtIdPhong.Text) ||
                string.IsNullOrWhiteSpace(txtTenPhong.Text) ||               
                string.IsNullOrWhiteSpace(cbbTrangThai.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text)
               )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin của dịch vụ", "Lỗi thông tin",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!txtDonGia.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Đơn giá phải là số", "Lỗi thông tin",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DichVuDTO _data = new DichVuDTO();
                        _data.IdDichVu = txtIdPhong.Text;
                        _data.TenDichVu = txtTenPhong.Text;                       
                        _data.TinhTrang = cbbTrangThai.Text;
                        _data.Gia = Int32.Parse(txtDonGia.Text);


                        if (!dvBus.CapNhatThongTinDichVu(_data))
                        {
                            MessageBox.Show("Cập nhật thông tin dịch vụ vào cơ sở dữ liệu thất bại", "Thất bại",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DocDuLieu(dvBus.LayDuDieu());
                            MessageBox.Show("Thông tin dịch vụ đã được cập nhật vào cơ sở dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            else
            if (this.state == 1)
            {
                //Them
                if (string.IsNullOrWhiteSpace(txtIdPhong.Text) ||
                string.IsNullOrWhiteSpace(txtTenPhong.Text) ||             
                string.IsNullOrWhiteSpace(cbbTrangThai.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text)
               )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin của dịch vụ", "Lỗi thông tin",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!txtDonGia.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Đơn giá phải là số", "Lỗi thông tin",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DichVuDTO _data = new DichVuDTO();
                        _data.IdDichVu = txtIdPhong.Text;
                        _data.TenDichVu = txtTenPhong.Text;
                       
                        _data.TinhTrang = cbbTrangThai.Text;
                        _data.Gia = Int32.Parse(txtDonGia.Text);


                        if (!dvBus.ThemThongTinDivhVu(_data))
                        {
                            MessageBox.Show("Thêm thông tin dịch vụ vào cơ sở dữ liệu thất bại hoặc ID Phòng bị trùng", "Thất bại",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DocDuLieu(dvBus.LayDuDieu());
                            MessageBox.Show("Thông tin dịch vụ đã được thêm vào cơ sở dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

            }
            btnNhapLai_Click(sender, e);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtIdPhong.Text = Global.Instance().idDichVu();

            txtTenPhong.Text = "";            
            cbbTrangThai.SelectedIndex = -1;
            txtDonGia.Text = "";

            state = 1;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DocDuLieu(dvBus.LayDuDieuTheoDieuKien(txtTimKiem.Text.ToUpper()));
        }
    }
}
