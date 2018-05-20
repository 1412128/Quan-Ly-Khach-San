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
    public partial class QLTaiKhoan : MetroFramework.Forms.MetroForm
    {
        AccountBUS _bus;
        int state = -1;
        public QLTaiKhoan()
        {
            InitializeComponent();
            txtId.Text = Global.Instance().idAccount();

            dataGrdV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGrdV.AllowUserToResizeRows = false;           


            _bus = new AccountBUS();
            DocDuLieu(_bus.LayDuDieu());
            state = 1;
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
            AccountDTO idx = _bus.getAccount(index);

            txtId.Text = idx.IDTaiKhoan.ToString();
            txtId.ReadOnly = true;
            txtTen.Text = idx.TaiKhoan.ToString();
            txtMK.Text = idx.MatKhau.ToString();
            state = 0;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ID Tài Khoản: " + index, "Xóa Tài Khoản", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!_bus.deleteAccount(index))
                {
                    MessageBox.Show("Xóa thông tin tài khoản thất bại", "Thất bại",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DocDuLieu(_bus.LayDuDieu());
                    MessageBox.Show("Xóa thông tin tài khoản thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtId.Text = Global.Instance().idAccount();
            txtTen.Text = "";
            txtMK.Text = "";
            state = 1;
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (this.state == 0)
            {

                //Cap nhat
                if (string.IsNullOrWhiteSpace(txtId.Text) ||
                    string.IsNullOrWhiteSpace(txtTen.Text) ||
                    string.IsNullOrWhiteSpace(txtMK.Text)
                    )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin của tài khoản", "Lỗi thông tin",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    AccountDTO _data = new AccountDTO();
                    _data.IDTaiKhoan = txtId.Text;
                    _data.TaiKhoan = txtTen.Text;
                    _data.MatKhau = txtMK.Text;

                    if (!_bus.updateAccount(_data))
                    {
                        MessageBox.Show("Cập nhật thông tin tài khoản vào cơ sở dữ liệu thất bại", "Thất bại",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DocDuLieu(_bus.LayDuDieu());
                        MessageBox.Show("Thông tin tài khoản đã được cập nhật vào cơ sở dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            else
            {
                if (this.state == 1)
                {
                    if (string.IsNullOrWhiteSpace(txtId.Text) ||
                   string.IsNullOrWhiteSpace(txtTen.Text) ||
                   string.IsNullOrWhiteSpace(txtMK.Text)
                   )
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin của tài khoản", "Lỗi thông tin",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        AccountDTO _data = new AccountDTO();
                        _data.IDTaiKhoan = txtId.Text;
                        _data.TaiKhoan = txtTen.Text;
                        _data.MatKhau = txtMK.Text;


                        if (!_bus.addAccount(_data))
                            {
                                MessageBox.Show("Thêm thông tin tài khoản vào cơ sở dữ liệu thất bại hoặc ID Phòng bị trùng", "Thất bại",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DocDuLieu(_bus.LayDuDieu());
                                MessageBox.Show("Thông tin tài khoản đã được thêm vào cơ sở dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

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
