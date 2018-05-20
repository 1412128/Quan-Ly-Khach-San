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
using System.Drawing.Printing;

namespace QLKS.GUI
{
    public partial class TrangChu : MetroForm
    {
        List<PhongDTO> _dataPhong;
        PhongBUS _phongBUS;       
        int state = 0;
        Panel _panelData;
        Panel _panelDivhVu;
        public TrangChu()
        {
            InitializeComponent();

            _phongBUS = new PhongBUS();
            //5 Sao voi State = 0;
            
            LoadData(state);
        }
        #region OnClickButton
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachCacKhachHang frm = new DanhSachCacKhachHang();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachBaoBieu frm = new DanhSachBaoBieu();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap frm = new DangNhap();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DichVu frm = new DichVu();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DatPhong frm = new DatPhong();
            frm.Show();
        }

        private void btnFiveStar_Click(object sender, EventArgs e)
        {
            state = 0;
            //panel3 = new Panel();
            this.Controls.Remove(_panelData);
            LoadData(state);
        }

        private void btnFourStar_Click(object sender, EventArgs e)
        {
            state = 1;
            this.Controls.Remove(_panelData);
            LoadData(state);
        }

        private void btnThreeStar_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(_panelData);
            state = 2;
            LoadData(state);
        }
        #endregion
        private void LoadData(int state)
        {
            _panelData = new Panel();
            _panelData.Location = new Point(150, 85);
            _panelData.Size = new Size(465, 419);
            _panelData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _panelData.AutoScroll = true;
            _panelData.AutoScrollMargin = new Size(0, 25);
             
            _dataPhong = _phongBUS.LayDanhSachPhongTheoLoaiPhong(state);
            int x = 25;
            int y = 20;
            for (int i = 0; i < _dataPhong.Count; i++)
            {
                //x = x + 120;
                Color c = Color.White;
                string s = _dataPhong[i].TrangThai.Normalize(NormalizationForm.FormC);
                if (s == "Còn Trống".Normalize(NormalizationForm.FormC))
                {
                    c = Color.Wheat;
                }
                else
                {
                    if (s == "Đang Sử Dụng".Normalize(NormalizationForm.FormC))
                    {
                        c = Color.Yellow;                        
                    }
                    else
                    {
                        if (s == "Đang Bảo Trì".Normalize(NormalizationForm.FormC))
                        {
                            c = Color.Gray;
                        }
                    }
                }

                if (x > 450)
                {
                    x = 25;
                    y = y + 145;
                }
                _panelData.Controls.Add(DrawPanel(new Point(x, y), c, _dataPhong[i].TenPhong, _dataPhong[i].TrangThai, _dataPhong[i].IdPhong, Properties.Resources.startrom5));
                x += 145;
            }
            this.Controls.Add(_panelData);
        }

        private Panel DrawPanel(Point p, Color c, string ten, string trangthai, string _id, Image img)
        {                        

            Panel pnl = new Panel();
            pnl.Size = new System.Drawing.Size(120, 120);
            pnl.Location = new Point(p.X, p.Y);
            pnl.BackColor = c;
            pnl.Cursor = Cursors.Hand;
            pnl.Click += new EventHandler(pnlPhong_Click);
            pnl.Name = _id;
            pnl.BackColor = c;

            Panel pnl1 = new Panel();
            pnl1.Size = new Size(120, 80);
            pnl1.BackgroundImage = img;
            pnl1.BackgroundImageLayout = ImageLayout.Stretch;
            pnl1.Name = _id;
            pnl1.Click += new EventHandler(pnlPhong_Click);

            Label lblTen = new Label();
            lblTen.Text = ten;
            lblTen.AutoSize = false;
            lblTen.Location = new Point(0, 80);
            lblTen.Size = new Size(120, 20);
            lblTen.TextAlign = ContentAlignment.MiddleCenter;
            lblTen.Font = new Font("Microsoft Sans Serif", 10);
            lblTen.Name = _id;
            lblTen.Click += new EventHandler(pnlPhong_Click);

            Label lblTrangThai = new Label();
            lblTrangThai.Text = trangthai;
            lblTrangThai.AutoSize = false;
            lblTrangThai.Location = new Point(0, 100);
            lblTrangThai.Size = new Size(120, 20);
            lblTrangThai.TextAlign = ContentAlignment.TopCenter;
            lblTrangThai.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Italic);
            lblTrangThai.Name = _id;
            lblTrangThai.Click += new EventHandler(pnlPhong_Click);

            pnl.Controls.Add(pnl1);
            pnl.Controls.Add(lblTen);
            pnl.Controls.Add(lblTrangThai);
            return pnl;
        }
       
        protected void pnlPhong_Click(object sender, EventArgs e)
        {
            this.panel5.Controls.Remove(_panelDivhVu);
            Control control = sender as Control;
            // string idPhong = sender;            
            //MessageBox.Show(control.Name);

            PhongBUS _phongBus = new PhongBUS();
            PhongDTO _phongDTO = _phongBus.LayThongTinPhong(control.Name);
            txtIDPhong.Text = _phongDTO.IdPhong;
            txtGia.Text = _phongDTO.Dongia.ToString();
            txtLoaiPhong.Text = _phongDTO.LoaiPhong.ToString();
            txtTinhTrang.Text = _phongDTO.TrangThai;
            
            if (_phongDTO.TrangThai == "Đang Sử Dụng")
            {
                PhongDangSuDungDTO _p = _phongBUS.LayThongTinPhongDangSuDung(control.Name);
                txtThoiGianDatPhong.Text = _p.ThoiGianBatDau;

                KhachHangBUS _khBus = new KhachHangBUS();
                KhachHangDTO _KhDTO = _khBus.LayThongTinKhachHang(_p.IdKhachHang.ToString());
                txtTenKH.Text = _KhDTO.HoTen;

                //Load Dich Vu    
                LoadDichDvu(_p.DsDichVu);


            }
            else
            {
                txtThoiGianDatPhong.Text = "Trống";
                txtTenKH.Text = "Trống";                
            }
                

            

        }
        private void LoadDichDvu(string ds)
        {
            string[] _array = ds.Split(',');
            DichVuBUS _dvBus = new DichVuBUS();
            List<DichVuDTO> _dvDTO = new List<DichVuDTO>();

            foreach (var item in _array)
            {
                DichVuDTO _dv = _dvBus.LayThongTinDichVu(item);
                _dvDTO.Add(_dv);
            }

            _panelDivhVu = new Panel();
            _panelDivhVu.Location = new Point(3, 196);
            _panelDivhVu.Size = new Size(224, 158);      
            _panelDivhVu.AutoScroll = true;
            _panelDivhVu.AutoScrollMargin = new Size(0, 5);

            int height = 0;
            for (int i = 0; i < _dvDTO.Count; i++)
            {
                _panelDivhVu.Controls.Add(DrawPanelDichVu(new Point(0, height),_dvDTO[i].TenDichVu));
                height += 30;
            }  

            this.panel5.Controls.Add(_panelDivhVu);

        }
        private Panel DrawPanelDichVu(Point p, string TenDv)
        {
            Panel pnl = new Panel();
            pnl.Size = new System.Drawing.Size(234, 30);
            pnl.Location = new Point(p.X, p.Y);            
            pnl.Cursor = Cursors.Hand;
         

            Label tenDv = new Label();
            tenDv.Text = TenDv;
            tenDv.Location = new Point(10, 2);
            tenDv.TextAlign = ContentAlignment.MiddleLeft;
            tenDv.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Italic);
            

            Button btnDv = new Button();
            btnDv.Location = new Point(180, 2);
            btnDv.Size = new Size(27, 25);
            btnDv.FlatAppearance.BorderSize = 0;
            btnDv.FlatStyle = FlatStyle.Flat;
            btnDv.TextAlign = ContentAlignment.MiddleRight;
            btnDv.BackgroundImage = Properties.Resources.btnDelete;
            btnDv.BackgroundImageLayout = ImageLayout.Zoom;
            

            pnl.Controls.Add(tenDv);
            pnl.Controls.Add(btnDv);

            return pnl;
        }


    }
}
