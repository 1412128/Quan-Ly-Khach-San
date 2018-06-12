using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QLKS.DTO;
using QLKS.DAO;

namespace QLKS.BUS
{
    class KhachHangBUS
    {
        KhachHangDAO KHDAO = new KhachHangDAO();

        public KhachHangDTO KhachHangDTO
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<KhachHangDTO> LayDanhSachKhachHang()
        {
            try
            {
                return KHDAO.LayDanhSachKhachHang();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public KhachHangDTO LayThongTinKhachHang(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return KHDAO.LayThongTinKhachHang(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool XoaThongTinKhachHang(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return KHDAO.XoaThongTinKhachHang(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool CapNhatThongTinKhachHang(KhachHangDTO nv)
        {
            return KHDAO.CapNhatThongTinKhachHang(nv);

        }
        public bool ThemThongTinKhachHang(KhachHangDTO nv)
        {
            //Xu ly nghiep vu    
            if (KHDAO.ThemThongTinKhachHang(nv))
            {
                return true;
            }
            return false;
        }
        public DataTable LayDuDieu()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID KH", typeof(string)).ReadOnly = true;
            table.Columns.Add("Tên KH", typeof(string));
            table.Columns.Add("CMND", typeof(int));
            table.Columns.Add("Ngày Sinh", typeof(string));            
            table.Columns.Add("SDT", typeof(string));        

            //Show data

            List<KhachHangDTO> _data = new List<KhachHangDTO>();
            _data = LayDanhSachKhachHang();
            foreach (var item in _data)
            {
                table.Rows.Add(item.IdKhachHang.ToString(), item.HoTen.ToString(), item.Cmnd.ToString(), item.NgaySinh.ToString(), item.Sdt.ToString());
            }

            return table;
        }
        public DataTable LayDuDieuTheoDieuKien(string kitu)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID KH", typeof(string)).ReadOnly = true;
            table.Columns.Add("Tên KH", typeof(string));
            table.Columns.Add("CMND", typeof(int));
            table.Columns.Add("Ngày Sinh", typeof(string));
            table.Columns.Add("SDT", typeof(string));

            //Show data
            List<KhachHangDTO> _data = new List<KhachHangDTO>();
            _data = LayDanhSachKhachHang();
            foreach (var item in _data)
            {
                if (item.IdKhachHang.Contains(kitu))
                {
                    table.Rows.Add(item.IdKhachHang.ToString(), item.HoTen.ToString(), item.Cmnd.ToString(), item.NgaySinh.ToString(), item.Sdt.ToString());
                }

            }

            return table;
        }
    }
}
