using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QLKS.DTO;
using QLKS.DAO;

namespace QLKS.BUS
{
    class NhanVienBUS
    {
        NhanVienDAO NvDAO = new NhanVienDAO();

        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            try
            {               
                return NvDAO.LayDanhSachNhanVien();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<NhanVienDTO> LayDanhSachNhanVienTheoChucVu(string chucvu)
        {
            try
            {
                return NvDAO.LayDanhSachNhanVienTheoChucVu(chucvu);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public NhanVienDTO LayThongTinNhanVien(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return NvDAO.LayThongTinNhanVien(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool XoaThongTinKNhanVien(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return NvDAO.XoaThongTinKNhanVien(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool CapNhatThongTinNhanVien(NhanVienDTO nv)
        {
            return NvDAO.CapNhatThongTinNhanVien(nv);

        }
        public bool ThemThongTinNhanVien(NhanVienDTO nv)
        {
            //Xu ly nghiep vu
            string idxNhanVien = nv.IdNhanVien;
            if (NvDAO.ThemThongTinNhanVien(nv))
            {
                return true;
            }
            return false;
        }
        public DataTable LayDuDieu()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID NV", typeof(string)).ReadOnly = true;
            table.Columns.Add("Tên NV", typeof(string));
            table.Columns.Add("Ngày Sinh", typeof(DateTime));
            table.Columns.Add("CMND", typeof(int));
            table.Columns.Add("Chức Vụ", typeof(string));
            table.Columns.Add("Lương", typeof(int));

            //Show data

            List<NhanVienDTO> _data = new List<NhanVienDTO>();
            _data = LayDanhSachNhanVien();
            foreach (var item in _data)
            {
                table.Rows.Add(item.IdNhanVien.ToString(), item.TenNhanVien.ToString(), item.NgaySinh.ToString(), item.Cmnd.ToString(), item.ChucVu.ToString(), item.Luong.ToString());
            }

            return table;
        }
        public DataTable LayDuDieuTheoDieuKien(string kitu)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID NV", typeof(string)).ReadOnly = true;
            table.Columns.Add("Tên NV", typeof(string));
            table.Columns.Add("Tên NV", typeof(DateTime));
            table.Columns.Add("Tên CMND", typeof(int));
            table.Columns.Add("Tên Chức Vụ", typeof(string));
            table.Columns.Add("Lương", typeof(int));

            //Show data
            List<NhanVienDTO> _data = new List<NhanVienDTO>();
            _data = LayDanhSachNhanVien();
            foreach (var item in _data)
            {
                if (item.IdNhanVien.Contains(kitu))
                {
                    table.Rows.Add(item.IdNhanVien.ToString(), item.TenNhanVien.ToString(), item.NgaySinh.ToString(), item.Cmnd.ToString(), item.ChucVu.ToString(), item.Luong.ToString());
                }

            }

            return table;
        }
    }
}
