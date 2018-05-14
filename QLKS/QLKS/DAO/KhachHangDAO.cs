using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DTO;

namespace QLKS.DAO
{
    public class KhachHangDAO
    {
        public List<KhachHangDTO> LayDanhSachKhachHang()
        {
            List<string[]> _list = new List<string[]>();
            List<KhachHangDTO> _data = new List<KhachHangDTO>();

            string query = string.Format("SELECT * FROM khachhang");
            _list = DBConnection.getInstance().Select(query);

            foreach (var item in _list)
            {
                KhachHangDTO _temp = new KhachHangDTO();
                _temp.IdKhachHang = item[0];
                _temp.HoTen = item[1];
                _temp.Cmnd = Int32.Parse(item[2]);
                _temp.NgaySinh = item[3];
                _temp.Sdt = Int32.Parse(item[4]);

                _data.Add(_temp);
            }


            return _data;
        }
        public KhachHangDTO LayThongTinKhachHang(string _id)
        {
            List<string[]> _list = new List<string[]>();
            KhachHangDTO _data = new KhachHangDTO();

            string query = string.Format("SELECT * FROM khachhang WHERE IDKhachHang={0}",_id);
            _list = DBConnection.getInstance().Select(query);

            _data.IdKhachHang = _list[0][0];
            _data.HoTen = _list[0][1];
            _data.Cmnd = Int32.Parse(_list[0][2]);
            _data.NgaySinh = _list[0][3];
            _data.Sdt = Int32.Parse(_list[0][4]);        

            return _data;
        }
        public bool XoaThongTinKhachHang(string _id)
        {
            string query = string.Format("DELETE FROM khachhang WHERE IDKhacHang= {0}", _id);
            return DBConnection.getInstance().Delete(query) ? true : false;
        }
        public bool ThemThongTinKhachHang(KhachHangDTO _khachhang)
        {
            string query = string.Format("INSERT INTO khachhang (IDKhachHang, HoTen, CMND, NgaySinh, SDT) VALUE=({0},{1},{2},{3},{4})",_khachhang.IdKhachHang, _khachhang.HoTen, _khachhang.Cmnd, _khachhang.NgaySinh, _khachhang.Sdt); 
            return DBConnection.getInstance().Insert(query) ? true : false;
        }
        public bool CapNhatThongTinKhachHang(KhachHangDTO _khachhang)
        {
            string query = string.Format("UPDATE khachhang SET HoTen = {0}, CMND = {1}, NgaySinh = {2}, SDT = {3} WHERE  IDKhacHang= {4}", _khachhang.HoTen, _khachhang.Cmnd, _khachhang.NgaySinh, _khachhang.Sdt, _khachhang.IdKhachHang);
            return DBConnection.getInstance().Update(query) ? true : false;
        }
        

    }
}
