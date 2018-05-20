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
    public partial class KhachHang : MetroForm
    {
        private string _Id;
        private KhachHangBUS _bus;
        private KhachHangDTO _ChiTietDTO;
        public KhachHang(string id)
        {
            InitializeComponent();

            this._Id = id;
            _bus = new KhachHangBUS();

            TruyenDataVao();
        }

        private void TruyenDataVao()
        {
            _ChiTietDTO = _bus.LayThongTinKhachHang(this._Id);
            lblHoTen.Text = _ChiTietDTO.HoTen;
            lblCMND.Text = _ChiTietDTO.Cmnd.ToString();
            lblSDT.Text = _ChiTietDTO.Sdt.ToString();

            dataGrdV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGrdV.AllowUserToResizeRows = false;
            dataGrdV.DataSource = dsBaoBieu(_ChiTietDTO.IdKhachHang);

        }
        public DataTable dsBaoBieu(string _id)
        {
            DataTable table = new DataTable();
            List<BaoBieuDTO> _data = new List<BaoBieuDTO>();
            BaoBieuBUS _dvBus = new BaoBieuBUS();
            _data = _dvBus.LayThongTinBaoBieuTheoIDKhachHang(_id);

            table.Columns.Add("ID Báo Biểu", typeof(string)).ReadOnly = true;
            table.Columns.Add("ID Phòng", typeof(string));
            table.Columns.Add("ID Nhân Viên", typeof(string));
            table.Columns.Add("ID Khách Hàng", typeof(string));
            table.Columns.Add("TG Bắt Đầu", typeof(string));
            table.Columns.Add("TG Kết Thúc", typeof(string));
            table.Columns.Add("DS Dịch Vụ", typeof(string));
            table.Columns.Add("Tồng tiền", typeof(string));

            foreach (var item in _data)
            {
                string s = Global.Instance().ConvertCurrency(item.TongTien.ToString());
                table.Rows.Add(item.IdBaoBieu.ToString(), item.IdPhong.ToString(), item.IdNhanVien.ToString(), item.IdKhachHang.ToString(), item.ThoiGianBatDau.ToString(), item.ThoiGianKetThuc.ToString(), item.DsDichVu.ToString(), s.ToString());
            }

            return table;
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
            foreach (Form item in Application.OpenForms)
            {
                item.Activate();
            }   
        }
    }
}
