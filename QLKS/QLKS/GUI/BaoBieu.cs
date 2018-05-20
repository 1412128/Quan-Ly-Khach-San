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
    public partial class BaoBieu : MetroForm
    {
        private string _Id;
        private BaoBieuBUS _bus;
        private BaoBieuDTO _ChiTietDTO;
        public BaoBieu(string id)
        {
            InitializeComponent();

            this._Id = id;
            _bus = new BaoBieuBUS();            
           
            TruyenDataVao();
        }

        private void TruyenDataVao()
        {
            _ChiTietDTO = _bus.LayThongTinBaoBieu(this._Id);
            lblIDBaoBieu.Text = _ChiTietDTO.IdBaoBieu;
            lblIDPhong.Text = _ChiTietDTO.IdPhong;
            lblThoiGianDatPhong.Text = _ChiTietDTO.ThoiGianBatDau;
            lblThoiGianTraPhong.Text = _ChiTietDTO.ThoiGianKetThuc;      
            lblChiPhi.Text = Global.Instance().ConvertCurrency(_ChiTietDTO.TongTien.ToString()) + " VND";

            PhongBUS phongBus = new PhongBUS();
            PhongDTO _phong = phongBus.LayThongTinPhong(_ChiTietDTO.IdPhong);
            lblIDPhong.Text = _phong.IdPhong;
            lblLoaiPhong.Text = _phong.LoaiPhong.ToString();

            KhachHangBUS khBus = new KhachHangBUS();
            KhachHangDTO _kh = khBus.LayThongTinKhachHang(_ChiTietDTO.IdKhachHang);
            lblTenKhach.Text = _kh.HoTen;
            lblCMNDKhach.Text = _kh.Cmnd.ToString();

            string[] _arrayDV = _ChiTietDTO.DsDichVu.Split(',');

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.DataSource = dsDichVu(_arrayDV);
            //dataGridView1.Columns[0].Visible = false;


        }

        public DataTable dsDichVu(string[] _arrayDV)
        {
            DataTable table = new DataTable();
            List<DichVuDTO> _array = new List<DichVuDTO>();
            DichVuBUS _dvBus = new DichVuBUS();
            foreach (var item in _arrayDV)
            {
                _array.Add(_dvBus.LayThongTinDichVu(item));
            }

            table.Columns.Add("Tên Dịch Vụ", typeof(string)).ReadOnly = true;
            table.Columns.Add("Đơn Giá", typeof(string));         

            //Show data            
            foreach (var item in _array)
            {
                string s = Global.Instance().ConvertCurrency(item.Gia.ToString());
                table.Rows.Add(item.TenDichVu.ToString(), s);
            }

            return table;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form f in Application.OpenForms)
            {
                f.Activate();
            }         
            
        }
    }
}
