using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DTO;
using System.Globalization;

namespace QLKS.DAO
{
    public class NhanVienDAO
    {
        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            List<string[]> _list = new List<string[]>();
            List<NhanVienDTO> _data = new List<NhanVienDTO>();

            string query = string.Format("SELECT * FROM nhanvien");
            _list = DBConnection.getInstance().Select(query);
            
            foreach (var item in _list)
            {
                NhanVienDTO _temp = new NhanVienDTO();
                _temp.IdNhanVien = item[0].ToString();               
                _temp.TenNhanVien = item[1].ToString();
                _temp.NgaySinh = item[2].ToString();                
                _temp.Cmnd = Int32.Parse(item[3].ToString());
                _temp.ChucVu = item[4].ToString();          
                _temp.Luong = Int32.Parse(item[5].ToString());               
                _data.Add(_temp);
            }            
            return _data;
        }
        public List<NhanVienDTO> LayDanhSachNhanVienTheoChucVu(string chucvu)
        {
            List<string[]> _list = new List<string[]>();
            List<NhanVienDTO> _data = new List<NhanVienDTO>();

            string query = string.Format("SELECT * FROM nhanvien WHERE ChucVu='{0}'", chucvu);            
            _list = DBConnection.getInstance().Select(query);

            foreach (var item in _list)
            {
                NhanVienDTO _temp = new NhanVienDTO();
                _temp.IdNhanVien = item[0].ToString();             
                _temp.TenNhanVien = item[1].ToString();
                _temp.NgaySinh = item[2].ToString();
                _temp.Cmnd = Int32.Parse(item[3].ToString());
                _temp.ChucVu = item[4].ToString();
                _temp.Luong = Int32.Parse(item[5].ToString());
                _data.Add(_temp);
            }
            return _data;
        }
        public NhanVienDTO LayThongTinNhanVien(string _id)
        {
            List<string[]> _list = new List<string[]>();
            NhanVienDTO _data = new NhanVienDTO();

            string query = string.Format("SELECT * FROM nhanvien WHERE IDNhanVien='{0}'", _id);
            _list = DBConnection.getInstance().Select(query);

            _data.IdNhanVien = _list[0][0];
            _data.TenNhanVien = _list[0][1];
            _data.NgaySinh = _list[0][2];
            _data.Cmnd = Int32.Parse(_list[0][3]);
            _data.ChucVu = _list[0][4];
            _data.Luong = Int32.Parse(_list[0][5]);

            return _data;
        }
        public bool XoaThongTinKNhanVien(string _id)
        {
            string query = string.Format("DELETE FROM nhanvien WHERE IDNhanVien= '{0}'", _id);
            return DBConnection.getInstance().Delete(query) ? true : false;
        }
        public bool ThemThongTinNhanVien(NhanVienDTO _nhanVien)
        {
            string query = string.Format("INSERT INTO khachhang (IDNhanVien, TenNhanVien, NgaySinh, CMND, ChucVu, Luong) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", _nhanVien.IdNhanVien, _nhanVien.TenNhanVien, _nhanVien.NgaySinh, _nhanVien.Cmnd, _nhanVien.ChucVu, _nhanVien.Luong);
            return DBConnection.getInstance().Insert(query) ? true : false;
        }
        public bool CapNhatThongTinNhanVien(NhanVienDTO _nhanVien)
        {
            string query = string.Format("UPDATE nhanvien SET TenNhanVien = '{0}', NgaySinh = '{1}', CMND = '{2}', ChucVu = '{3}', Luong = '{4}' WHERE  IDNhanVien= '{5}'", _nhanVien.TenNhanVien, _nhanVien.NgaySinh, _nhanVien.Cmnd, _nhanVien.ChucVu, _nhanVien.Luong, _nhanVien.IdNhanVien);    
            return DBConnection.getInstance().Update(query) ? true : false;
        }
    }
}
