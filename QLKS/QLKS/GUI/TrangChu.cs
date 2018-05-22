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
    public partial class TrangChu : MetroForm,ObserverPattern
    {
        List<PhongDTO> _dataPhong;
        PhongBUS _phongBUS;       
        int state = 0;
        Image img = Properties.Resources.startrom5;
        Panel _panelData;
        Panel _panelDivhVu;
        Panel _panelActive;     
        string dsDv ="";
        int tongTienDichVu;
        int trangThaiPhong = -1;
        string idPhongClick;     
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
            if(trangThaiPhong == 1)
            {
                this.Hide();
                DichVu frm = new DichVu(idPhongClick);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Phòng đang sử dụng mới được sử dụng dịch vụ của hệ thống", "Thông báo");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (trangThaiPhong == 0)
            {
                this.Hide();
                DatPhong frm = new DatPhong(idPhongClick);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Phòng trống mới được đặt phòng", "Thông báo");
            }
        }

        private void btnFiveStar_Click(object sender, EventArgs e)
        {
            state = 0;
            //panel3 = new Panel();
            this.Controls.Remove(_panelData);
            img = Properties.Resources.startrom5;
            LoadData(state);
        }

        private void btnFourStar_Click(object sender, EventArgs e)
        {
            state = 1;
            this.Controls.Remove(_panelData);
            img = Properties.Resources.startrom2;
            LoadData(state);
        }

        private void btnThreeStar_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(_panelData);
            state = 2;
            img = Properties.Resources.startroom1;
            LoadData(state);
        }
        //Tra Phong
        private void button11_Click(object sender, EventArgs e)
        {
            if(trangThaiPhong == 1)
            {
                PhongDTO phong = _phongBUS.LayThongTinPhong(idPhongClick);

                DateTime dtNow = DateTime.Now;

                PhongDangSuDungDTO _pdsdDTO = new PhongDangSuDungDTO();
                _pdsdDTO = _phongBUS.LayThongTinPhongDangSuDung(idPhongClick);

                string[] _array = _pdsdDTO.DsDichVu.Split(',');
                DichVuBUS _dvBus = new DichVuBUS();
                List<DichVuDTO> _dvDTO = new List<DichVuDTO>();

                foreach (var item in _array)
                {
                    DichVuDTO _dv = _dvBus.LayThongTinDichVu(item);
                    if (_dv != null)
                        _dvDTO.Add(_dv);
                }

                string idPhong = "\n ID Phòng: " + idPhongClick;
                string tenPhong = "\n Tên Phòng: " + phong.TenPhong;    
                string ngayDatPhong = "\n Thời gian Đặt Phòng: " + txtThoiGianDatPhong.Text;
                string ngayTraPhong = "\n Thời gian Trả Phòng: " + dtNow.ToString();
                string dsDV_ThanhToan = "\n Danh sách dịch vụ sử dụng:";
                int sDichVu = 0;
                foreach (var item in _dvDTO)
                {
                    dsDV_ThanhToan += "\n       + " + item.TenDichVu;
                    
                  
                    sDichVu += (int)item.Gia;

                }                     
                DateTime dtBatDau = DateTime.Parse(txtThoiGianDatPhong.Text);

                TimeSpan span = dtNow - dtBatDau;
                double TongHoaDon = (span.TotalMinutes/60)*(phong.Dongia) + sDichVu;
                string s = Global.Instance().ConvertCurrency(TongHoaDon.ToString());


                string chiphi = "\n Tổng hóa đơn: " + s + " VND";

                DialogResult dialogResult = MessageBox.Show("Bạn muốn thanh toán hóa đơn với:" + idPhong + tenPhong + ngayDatPhong + ngayTraPhong + dsDV_ThanhToan + chiphi, "Thanh Toán", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    BaoBieuDTO baoBieu = new BaoBieuDTO();
                    baoBieu.IdBaoBieu = Global.Instance().idBaoBieu();
                    baoBieu.IdPhong = idPhongClick;
                    baoBieu.IdNhanVien = "1";
                    baoBieu.IdKhachHang = _pdsdDTO.IdKhachHang;
                    baoBieu.DsDichVu = _pdsdDTO.DsDichVu;
                    baoBieu.ThoiGianBatDau = txtThoiGianDatPhong.Text;
                    baoBieu.ThoiGianKetThuc = dtNow.ToString();
                    baoBieu.TongTien = (float)TongHoaDon;

                    BaoBieuBUS _baobieuBUs = new BaoBieuBUS();
                    _baobieuBUs.ThemThongTinBaoBieu(baoBieu);

                    _phongBUS.XoaThongTinPhongDangSuDung(idPhongClick);

                    //Cap nhat thong tin Phong
                    PhongDTO _phongCapNhat = _phongBUS.LayThongTinPhong(idPhongClick);
                    _phongCapNhat.TrangThai = "Còn Trống";
                    _phongBUS.CapNhatThongTinPhong(_phongCapNhat);

                   LoadData(state);

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                MessageBox.Show("Phòng đang sử dụng mới được trả phòng", "Thông báo");
            }
        }
        #endregion
        private void LoadData(int state)
        {
            this.Controls.Remove(_panelData);
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
                Panel _roomPanel = DrawPanel(new Point(x, y), c, _dataPhong[i].TenPhong, _dataPhong[i].TrangThai, _dataPhong[i].IdPhong, img);
                

                _panelData.Controls.Add(_roomPanel);
                x += 145;
            }
            this.Controls.Add(_panelData);
        }

        private void TimKiem(string kitu)
        {
            _panelData = new Panel();
            _panelData.Location = new Point(150, 85);
            _panelData.Size = new Size(465, 419);
            _panelData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _panelData.AutoScroll = true;
            _panelData.AutoScrollMargin = new Size(0, 25);

            if (kitu != "")
            {
                _dataPhong = _phongBUS.LayDanhSachPhongTheoIdPhong(kitu, _dataPhong);
            }        
            else
            {
                this.Controls.Remove(_panelData);
                LoadData(state);
            }    
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

        Label cp;
        private void CreateLableChiPhi()
        {
           
            this.panel6.Controls.Remove(cp);
            PhongBUS _phongBus = new PhongBUS();
            PhongDTO _phongDTO = _phongBus.LayThongTinPhong(idPhongClick);
            cp = new Label();
            cp.Location = new Point(35, 34);
            cp.Size = new Size(0, 17);
            cp.AutoSize = true;
            cp.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold | FontStyle.Italic);
            if (_phongDTO.TrangThai == "Đang Sử Dụng")
            {
                PhongDangSuDungDTO phong = _phongBUS.LayThongTinPhongDangSuDung(idPhongClick);
                int cpInt = Int32.Parse(phong.GiaDichVu) + (int)_phongDTO.Dongia;
                cp.Text = _phongDTO.Dongia.ToString() + " + " + phong.GiaDichVu.ToString() + "DV";
            }
            else
            {
                cp.Text = _phongDTO.Dongia.ToString();
            }
            this.panel6.Controls.Add(cp);
        }
        protected void pnlPhong_Click(object sender, EventArgs e)
        {

            

            this.panel5.Controls.Remove(_panelDivhVu);           

            Control control = sender as Control;

            // string idPhong = sender;            
            //MessageBox.Show(control.Name);
            _panelData.Controls.Remove(_panelActive);
         
            idPhongClick = control.Name;

            Control _controlParent = control.Parent;         
            _panelActive = new Panel();
            _panelActive.Location = new Point(control.Parent.Location.X - 5, control.Parent.Location.Y - 5);
            _panelActive.BackColor = Color.Orange;
            _panelActive.Size = new Size(130, 130);         
            _panelData.Controls.Add(_panelActive);
            CreateLableChiPhi();
            //MessageBox.Show(control.Parent.Location.X.ToString());

            PhongBUS _phongBus = new PhongBUS();
            PhongDTO _phongDTO = _phongBus.LayThongTinPhong(idPhongClick);
            txtIDPhong.Text = _phongDTO.IdPhong;

            //Cong voi DIch vu            
            

            txtLoaiPhong.Text = _phongDTO.LoaiPhong.ToString();
            txtTinhTrang.Text = _phongDTO.TrangThai;
            
            if (_phongDTO.TrangThai == "Đang Sử Dụng")
            {
                trangThaiPhong = 1;
                PhongDangSuDungDTO _p = _phongBUS.LayThongTinPhongDangSuDung(idPhongClick);
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
                if (_phongDTO.TrangThai == "Còn Trống")
                {
                    trangThaiPhong = 0;
                }
                else
                {
                    trangThaiPhong = -1;
                }
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
                if(_dv!= null)
                    _dvDTO.Add(_dv);
            }
            this.panel5.Controls.Remove(_panelDivhVu);
            _panelDivhVu = new Panel();
            _panelDivhVu.Location = new Point(3, 196);
            _panelDivhVu.Size = new Size(224, 158);      
            _panelDivhVu.AutoScroll = true;
            _panelDivhVu.AutoScrollMargin = new Size(0, 5);

            int height = 0;
            for (int i = 0; i < _dvDTO.Count; i++)
            {
                _panelDivhVu.Controls.Add(DrawPanelDichVu(new Point(0, height),_dvDTO[i].TenDichVu,_dvDTO[i].IdDichVu));
                height += 30;
            }  

            this.panel5.Controls.Add(_panelDivhVu);

        }
        private Panel DrawPanelDichVu(Point p, string TenDv,string idDv)
        {
            Panel pnl = new Panel();
            pnl.Size = new System.Drawing.Size(234, 30);
            pnl.Location = new Point(p.X, p.Y);            
            
         

            Label tenDv = new Label();
            tenDv.Text = TenDv;
            tenDv.Location = new Point(10, 2);
            tenDv.TextAlign = ContentAlignment.MiddleLeft;
            tenDv.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Italic);
            

            Button btnDv = new Button();
            btnDv.Cursor = Cursors.Hand;
            btnDv.Location = new Point(180, 2);
            btnDv.Size = new Size(27, 25);
            btnDv.FlatAppearance.BorderSize = 0;
            btnDv.FlatStyle = FlatStyle.Flat;
            btnDv.TextAlign = ContentAlignment.MiddleRight;
            btnDv.BackgroundImage = Properties.Resources.btnDelete;
            btnDv.BackgroundImageLayout = ImageLayout.Zoom;
            btnDv.Click += new EventHandler(btnDelete_Click);
            btnDv.Name = idDv;


            pnl.Controls.Add(tenDv);
            pnl.Controls.Add(btnDv);

            return pnl;
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            string ds = "";
            //  _phongBUS
            PhongDangSuDungDTO _pdsdDTO = _phongBUS.LayThongTinPhongDangSuDung(idPhongClick);
            int index = _pdsdDTO.DsDichVu.IndexOf(control.Name.ToString()) ;
            // MessageBox.Show(index.ToString());
            string[] array = _pdsdDTO.DsDichVu.Split(',');
            var listString = new List<string>(array);
            foreach (var item in listString)
            {
               if(item == control.Name)
               {
                   listString.Remove(item);
                    DichVuBUS dvBus = new DichVuBUS();
                    DichVuDTO dvDTO = dvBus.LayThongTinDichVu(item);
                    _pdsdDTO.GiaDichVu = (Int32.Parse(_pdsdDTO.GiaDichVu) - (int)dvDTO.Gia).ToString();
                   break;
               }                
            }
           foreach (var item in listString)
           {
                ds += "," + item.ToString();               
           }
           if(ds!= "")
                ds = ds.Remove(0, 1);           
            _pdsdDTO.DsDichVu = ds;
            _phongBUS.CapNhatThongTinPhongDangSuDung(_pdsdDTO);
             LoadDichDvu(_pdsdDTO.DsDichVu);

            CreateLableChiPhi();

        }
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Controls.Remove(_panelData);           
            TimKiem(txtTimKiem.Text.ToUpper());               
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData(state);
        }

        public void onSubmit(string dsDichVu, int tongChiPhiDichVu, string idPhong)
        {           
            this.dsDv = dsDichVu;
            this.tongTienDichVu = tongChiPhiDichVu;
            this.idPhongClick = idPhong;
           
            //MessageBox.Show(this.Name);          
        }
    }
}
