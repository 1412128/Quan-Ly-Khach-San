using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace QLKS.GUI
{
    public partial class QLTrangChu : MetroForm
    {
        public QLTrangChu()
        {
            InitializeComponent();
        }
        private void btnPhong_Click(object sender, EventArgs e)
        {           
            this.Hide();
            QLPhong _qlPhong = new QLPhong();
            _qlPhong.Show();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLDichVu _qlDichVu = new QLDichVu();
            _qlDichVu.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLConNguoi _qlConNguoi = new QLConNguoi();
            _qlConNguoi.Show();
        }

        private void btnBaoBieu_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLBaoBieu _qlBaoBieu = new QLBaoBieu();
            _qlBaoBieu.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap frmDangNhap = new DangNhap();
            frmDangNhap.Show();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLKhachHang frmQLKhachHang = new QLKhachHang();
            frmQLKhachHang.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLTaiKhoan frmQLTaiKhoan = new QLTaiKhoan();
            frmQLTaiKhoan.Show();
        }
    }
}
