using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QLKS.DTO;
using QLKS.DAO;

namespace QLKS.BUS
{
    class BaoBieuBUS
    {
        BaoBieuDAO _dao = new BaoBieuDAO();

        public List<BaoBieuDTO> LayDanhSachBaoBieu()
        {
            try
            {
                return _dao.LayDanhSachBaoBieu();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public BaoBieuDTO LayThongTinBaoBieu(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return _dao.LayThongTinBaoBieu(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<BaoBieuDTO> LayThongTinBaoBieuTheoIDKhachHang(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return _dao.LayThongTinBaoBieuTheoIDKhachHang(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool XoaThongTinBaoBieu(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return _dao.XoaThongTinBaoBieu(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }       
        public bool ThemThongTinBaoBieu(BaoBieuDTO dv)
        {
            //Xu ly nghiep vu           
            if (_dao.ThemThongTinBaoBieu(dv))
            {
                return true;
            }
            return false;
        }
        public DataTable LayDuDieu()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID Báo Biểu", typeof(string)).ReadOnly = true;
            table.Columns.Add("ID Phòng", typeof(string));
            table.Columns.Add("ID Nhân Viên", typeof(string));
            table.Columns.Add("ID Khách Hàng", typeof(string));
            table.Columns.Add("TG Bắt Đầu", typeof(string));
            table.Columns.Add("TG Kết Thúc", typeof(string));
            table.Columns.Add("DS Dịch Vụ", typeof(string));
            table.Columns.Add("Tồng tiền", typeof(string));
                      



            //Show data
            List<BaoBieuDTO> _data = new List<BaoBieuDTO>();
            _data = LayDanhSachBaoBieu();
            foreach (var item in _data)
            {
                string s = Global.Instance().ConvertCurrency(item.TongTien.ToString());
                table.Rows.Add(item.IdBaoBieu.ToString(), item.IdPhong.ToString(), item.IdNhanVien.ToString(), item.IdKhachHang.ToString(), item.ThoiGianBatDau.ToString(), item.ThoiGianKetThuc.ToString(), item.DsDichVu.ToString(), s.ToString());
            }

            return table;
        }
        public DataTable LayDuDieuTheoDieuKien(string kitu)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID Báo Biểu", typeof(string)).ReadOnly = true;
            table.Columns.Add("ID Phòng", typeof(string));
            table.Columns.Add("ID Nhân Viên", typeof(string));
            table.Columns.Add("ID Khách Hàng", typeof(string));
            table.Columns.Add("TG Bắt Đầu", typeof(string));
            table.Columns.Add("TG Kết Thúc", typeof(string));
            table.Columns.Add("DS Dịch Vụ", typeof(string));
            table.Columns.Add("Tồng tiền", typeof(string));

            //Show data
            List<BaoBieuDTO> _data = new List<BaoBieuDTO>();
            _data = LayDanhSachBaoBieu();
            foreach (var item in _data)
            {
                if (item.IdBaoBieu.Contains(kitu))
                {
                    string s = Global.Instance().ConvertCurrency(item.TongTien.ToString());
                    table.Rows.Add(item.IdBaoBieu.ToString(), item.IdPhong.ToString(), item.IdNhanVien.ToString(), item.IdKhachHang.ToString(), item.ThoiGianBatDau.ToString(), item.ThoiGianKetThuc.ToString(), item.DsDichVu.ToString(), s);
                }

            }

            return table;
        }
    }
}
