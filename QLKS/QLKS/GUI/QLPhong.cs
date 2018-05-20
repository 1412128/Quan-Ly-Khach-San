using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using QLKS.DTO;
using QLKS.BUS;
using QLKS.GUI.Component;

namespace QLKS.GUI
{
    public partial class QLPhong : MetroForm
    {
        PhongBUS phongBUS;
        int state = -1;
        // = 0 -> cap nhat 
        // = 1 -> them
        public QLPhong()
        {
            //Component
            InitializeComponent();
            txtIdPhong.Text = Global.Instance().idPhong();       

            dataGrdV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGrdV.AllowUserToResizeRows = false;
            txtIdPhong.ReadOnly = true;

            phongBUS = new PhongBUS();
            DocDuLieu(phongBUS.LayDuDieu());

            state = 1;
        }


        #region Layout

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DocDuLieu(phongBUS.LayDuDieu());
        }   

        public void DocDuLieu(DataTable dt)
        {
            dataGrdV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrdV.DataSource = dt;
            dataGrdV.AllowUserToAddRows = false;
            dataGrdV.Dock = DockStyle.Bottom;
            dataGrdV.AllowUserToResizeColumns = false;
        }

        #endregion





        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            PhongDTO idxPhong = phongBUS.LayThongTinPhong(index);

            txtIdPhong.Text = idxPhong.IdPhong.ToString();
            txtIdPhong.ReadOnly = true;

            txtTenPhong.Text = idxPhong.TenPhong;
            cbbTrangThai.Text = idxPhong.TrangThai;
            txtDonGia.Text = idxPhong.Dongia.ToString();
            cbbLoaiPhong.SelectedIndex = idxPhong.LoaiPhong;

            state = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ID Phòng: " + index,"Xóa phòng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!phongBUS.XoaThongTinPhong(index))
                {
                    MessageBox.Show("Xóa thông tin phòng thất bại", "Thất bại",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DocDuLieu(phongBUS.LayDuDieu());
                    MessageBox.Show("Xóa thông tin phòng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtIdPhong.Text = Global.Instance().idPhong();
            
            txtTenPhong.Text = "";
            cbbLoaiPhong.SelectedIndex = -1;
            cbbTrangThai.SelectedIndex = -1;
            txtDonGia.Text = "";

            state = 1;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (this.state == 0)
            {
                //Cap nhat
                if (string.IsNullOrWhiteSpace(txtIdPhong.Text) ||                
                string.IsNullOrWhiteSpace(txtTenPhong.Text) ||
                string.IsNullOrWhiteSpace(cbbLoaiPhong.Text) ||
                string.IsNullOrWhiteSpace(cbbTrangThai.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text)
               )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin của phòng", "Lỗi thông tin",
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
                        PhongDTO _data = new PhongDTO();
                        _data.IdPhong = txtIdPhong.Text;
                        _data.TenPhong = txtTenPhong.Text;
                        _data.LoaiPhong = cbbLoaiPhong.SelectedIndex;                    
                        _data.TrangThai = cbbTrangThai.Text;
                        _data.Dongia = Int32.Parse(txtDonGia.Text);
                      

                        if (!phongBUS.CapNhatThongTinPhong(_data))
                        {
                            MessageBox.Show("Cập nhật thông tin phòng vào cơ sở dữ liệu thất bại", "Thất bại",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DocDuLieu(phongBUS.LayDuDieu());
                            MessageBox.Show("Thông tin phòng đã được cập nhật vào cơ sở dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string.IsNullOrWhiteSpace(cbbLoaiPhong.Text) ||
                string.IsNullOrWhiteSpace(cbbTrangThai.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text)
               )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin của phòng", "Lỗi thông tin",
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
                        PhongDTO _data = new PhongDTO();
                        _data.IdPhong = txtIdPhong.Text;
                        _data.TenPhong = txtTenPhong.Text;
                        _data.LoaiPhong = cbbLoaiPhong.SelectedIndex;
                        _data.TrangThai = cbbTrangThai.Text;
                        _data.Dongia = Int32.Parse(txtDonGia.Text);


                        if (!phongBUS.ThemThongTinPhong(_data))
                        {
                            MessageBox.Show("Thêm thông tin phòng vào cơ sở dữ liệu thất bại hoặc ID Phòng bị trùng", "Thất bại",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DocDuLieu(phongBUS.LayDuDieu());
                            MessageBox.Show("Thông tin phòng đã được thêm vào cơ sở dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

            }
            btnNhapLai_Click(sender, e);


        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {            
            DocDuLieu(phongBUS.LayDuDieuTheoDieuKien(txtTimKiem.Text.ToUpper()));
        }
    }
}
