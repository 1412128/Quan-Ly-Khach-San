using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QLKS.DTO;
using QLKS.DAO;

namespace QLKS.BUS
{
    class DichVuBUS
    {
         DichVuDAO dvDAO = new DichVuDAO();

        public List<DichVuDTO> LayDanhSachDichVu()
        {
            try
            {
                return dvDAO.LayDanhSachDichVu();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<DichVuDTO> LayThongTinDichVuTheoTrangThai(string s)
        {
            try
            {
                return dvDAO.LayThongTinDichVuTheoTrangThai(s);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public DichVuDTO LayThongTinDichVu(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return dvDAO.LayThongTinDichVu(_id);
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public bool XoaThongTinDichVu(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return dvDAO.XoaThongTinDichVu(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool CapNhatThongTinDichVu(DichVuDTO dv)
        {
            return dvDAO.CapNhatThongTinDichVu(dv);

        }
        public bool ThemThongTinDivhVu(DichVuDTO dv)
        {
            //Xu ly nghiep vu
            string idxDichVu = dv.IdDichVu;
           if (dvDAO.ThemThongTinDichVu(dv)){
                return true;
            }
            return false;
        }
        public DataTable LayDuDieu()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID Dịch Vụ", typeof(string)).ReadOnly = true;
            table.Columns.Add("Tên Dịch Vụ", typeof(string));
            table.Columns.Add("Giá", typeof(string));
            table.Columns.Add("Tình Trạng", typeof(string));           

            //Show data
            List<DichVuDTO> _data = new List<DichVuDTO>();
            _data = LayDanhSachDichVu();
            foreach (var item in _data)
            {
                string s = Global.Instance().ConvertCurrency(item.Gia.ToString());
                table.Rows.Add(item.IdDichVu.ToString(), item.TenDichVu.ToString(),s , item.TinhTrang.ToString());
            }

            return table;
        }
        public DataTable LayDuDieuTheoDieuKien(string kitu)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID Dịch Vụ", typeof(string)).ReadOnly = true;
            table.Columns.Add("Tên Dịch Vụ", typeof(string));    
            table.Columns.Add("Tình Trạng", typeof(string));
            table.Columns.Add("Đơn Giá", typeof(string));

            //Show data
            List<DichVuDTO> _data = new List<DichVuDTO>();
            _data = LayDanhSachDichVu();
            foreach (var item in _data)
            {
                if (item.IdDichVu.Contains(kitu))
                {
                    string s = Global.Instance().ConvertCurrency(item.Gia.ToString());
                    table.Rows.Add(item.IdDichVu.ToString(), item.TenDichVu.ToString(), item.TinhTrang.ToString(),  s);
                }

            }

            return table;
        }
    }
}
