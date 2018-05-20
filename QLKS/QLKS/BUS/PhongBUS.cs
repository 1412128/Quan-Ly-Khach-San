using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLKS.DTO;
using QLKS.DAO;

namespace QLKS.BUS
{
    public class PhongBUS
    {
        PhongDAO _phongDAO = new PhongDAO();
        
        public List<PhongDTO> LayDanhSachPhong()
        {
            try
            {
                return _phongDAO.LayDanhSachPhong();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<PhongDTO> LayDanhSachPhongTheoLoaiPhong(int loaiPhong)
        {
            try
            {
                return _phongDAO.LayDanhSachPhongTheoLoaiPhong(loaiPhong);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public PhongDTO LayThongTinPhong(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return _phongDAO.LayThongTinPhong(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool XoaThongTinPhong(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return _phongDAO.XoaThongTinPhong(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool CapNhatThongTinPhong(PhongDTO phong)
        {
            return _phongDAO.CapNhatThongTinPhong(phong);

        }
        public bool ThemThongTinPhong(PhongDTO phong)
        {
            //Xu ly nghiep vu        
            if (_phongDAO.ThemThongTinPhong(phong))
            {
                return true;
            }
            return false;            
        }
        public DataTable LayDuDieu()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID Phòng", typeof(string)).ReadOnly = true;
            table.Columns.Add("Tên Phòng", typeof(string));
            table.Columns.Add("Loại Phòng", typeof(int));
            table.Columns.Add("Trạng Thái", typeof(string));
            table.Columns.Add("Đơn Giá", typeof(string));

            //Show data
            List<PhongDTO> _data = new List<PhongDTO>();
            _data = LayDanhSachPhong();
            foreach (var item in _data)
            {
                string s = Global.Instance().ConvertCurrency(item.Dongia.ToString());
                table.Rows.Add(item.IdPhong.ToString(), item.TenPhong.ToString(), item.LoaiPhong.ToString(), item.TrangThai.ToString(), s);
            }

            return table;
        }
        public DataTable LayDuDieuTheoDieuKien(string kitu)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID Phòng", typeof(string)).ReadOnly = true;
            table.Columns.Add("Tên Phòng", typeof(string));
            table.Columns.Add("Loại Phòng", typeof(int));
            table.Columns.Add("Trạng Thái", typeof(string));
            table.Columns.Add("Đơn Giá", typeof(string));

            //Show data
            List<PhongDTO> _data = new List<PhongDTO>();
            _data = LayDanhSachPhong();
            foreach (var item in _data)
            {
                if (item.IdPhong.Contains(kitu))
                {
                    string s = Global.Instance().ConvertCurrency(item.Dongia.ToString());
                    table.Rows.Add(item.IdPhong.ToString(), item.TenPhong.ToString(), item.LoaiPhong.ToString(), item.TrangThai.ToString(), s);
                }

            }

            return table;
        }

        //phong dang su dung
        public PhongDangSuDungDTO LayThongTinPhongDangSuDung(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return _phongDAO.LayThongTinPhongDangSuDung(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool ThemThongTinPhongDangSuDung(PhongDangSuDungDTO phong)
        {
            //Xu ly nghiep vu        
            if (_phongDAO.ThemThongTinPhongDangSuDung(phong))
            {
                return true;
            }
            return false;
        }
        public bool XoaThongTinPhongDangSuDung(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return _phongDAO.XoaThongTinPhongDangSuDung(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
