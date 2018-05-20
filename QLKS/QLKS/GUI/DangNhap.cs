using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using QLKS.BUS;

namespace QLKS.GUI
{
    public partial class DangNhap : MetroForm
    {
        AccountBUS acc;
        public DangNhap()
        {
            InitializeComponent();
            // this.groupBox1.BackColor = Color.FromArgb(255, 232, 232);
            acc = new AccountBUS();
            this.Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text == "" 
                || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản hoặc mật khẩu", "Lỗi thông tin",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (acc.KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == -1)
                {
                    MessageBox.Show("Tài Khoản hoặc Mật khẩu không đúng", "Lỗi thông tin",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (acc.KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == 0)
                    {
                        this.Hide();
                        QLTrangChu frm = new QLTrangChu();
                        frm.Show();
                    }
                    else
                    {
                        if (acc.KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == 1)
                        {
                            this.Hide();
                            TrangChu frm = new TrangChu();
                            frm.Show();
                        }
                    }
                }
            }
        }
    }
}
