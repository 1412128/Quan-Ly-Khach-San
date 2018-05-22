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
using QLKS.DTO;

namespace QLKS.GUI
{
    public partial class DatPhong : MetroForm
    {
        string idPhong;
        PhongBUS _phongBus;
        PhongDTO _phongDTO;
        KhachHangBUS _khBus;

        public DatPhong()
        {
            InitializeComponent();
            _phongBus = new PhongBUS();
            _khBus = new KhachHangBUS();
            LoadData();
        }
        public DatPhong(string idPhong)
        {
            InitializeComponent();
            _phongBus = new PhongBUS();
            _khBus = new KhachHangBUS();
            this.idPhong = idPhong;
            LoadData();
        }
        private void LoadData()
        {
            _phongDTO = _phongBus.LayThongTinPhong(idPhong);
            txtIDPhong.Text = _phongDTO.IdPhong;           
            lblTenPhong.Text = _phongDTO.TenPhong;
            string s = Global.Instance().ConvertCurrency(_phongDTO.Dongia.ToString());
            lblChiPhi.Text = s + " VND";
            txtNgay.Text = DateTime.Now.ToString();
            txtNgay.ReadOnly = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu op = new TrangChu();            
            op.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu op = new TrangChu();
            op.Show();
        }
        //Dat Phong
        private void button1_Click(object sender, EventArgs e)
        {
           
            //Cap nhat
            if (
            string.IsNullOrWhiteSpace(txtHoTen.Text) ||
            string.IsNullOrWhiteSpace(txtCMND.Text) ||
            string.IsNullOrWhiteSpace(txtSDT.Text) ||
            string.IsNullOrWhiteSpace(txtNgaySinh.Text)           
           )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của dịch vụ", "Lỗi thông tin",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!txtCMND.Text.All(char.IsDigit) || !txtSDT.Text.All(char.IsDigit))
                {
                    MessageBox.Show("SDT và CMND phải là số", "Lỗi thông tin",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    KhachHangDTO _data = new KhachHangDTO();
                    _data.IdKhachHang = Global.Instance().idKhachHang().ToString();
                    _data.HoTen = txtHoTen.Text;
                    _data.NgaySinh = txtNgaySinh.Text;
                    _data.Cmnd = Int32.Parse(txtCMND.Text);
                    _data.Sdt = Int32.Parse(txtSDT.Text);

                    if (!_khBus.ThemThongTinKhachHang(_data))
                    {
                        MessageBox.Show("Đặt phòng cho kháchh hàng thất bại", "Thất bại",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {                  
                        MessageBox.Show("Đặt phòng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Luu trạng thái Phong
                        _phongDTO.TrangThai = "Đang Sử Dụng";
                        _phongBus.CapNhatThongTinPhong(_phongDTO);
                        //Luu Phong duoc dat
                        PhongDangSuDungDTO _pdsdDTO = new PhongDangSuDungDTO();
                        _pdsdDTO.IdPhong = _phongDTO.IdPhong;
                        _pdsdDTO.ThoiGianBatDau = txtNgay.Text;
                        _pdsdDTO.IdKhachHang = _data.IdKhachHang;
                        _pdsdDTO.DsDichVu = "";
                        _pdsdDTO.GiaDichVu = 0.ToString();
                        _phongBus.ThemThongTinPhongDangSuDung(_pdsdDTO);

                        this.Hide();
                        TrangChu op = new TrangChu();
                        op.Show();

                    }

                }
            }

        }
    }
}
