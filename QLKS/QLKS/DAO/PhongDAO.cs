using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DTO;
using System.Globalization;

namespace QLKS.DAO
{
    public class PhongDAO
    {
        public PhongDTO PhongDTO
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<PhongDTO> LayDanhSachPhongTheoLoaiPhong(int _loaiPhong)
        {
            List<string[]> _list = new List<string[]>();
            List<PhongDTO> _data = new List<PhongDTO>();

            string query = string.Format("SELECT * FROM phong WHERE LoaiPhong='{0}'", _loaiPhong);
            _list = DBConnection.getInstance().Select(query);

            foreach (var item in _list)
            {
                PhongDTO _temp = new PhongDTO();
                _temp.IdPhong = item[0];
                _temp.TenPhong = item[1];
                _temp.LoaiPhong = Int32.Parse(item[2]);
                _temp.TrangThai = item[3];
                _temp.Dongia = Int32.Parse(item[4]);

                _data.Add(_temp);
            }
            return _data;
        }
        public List<PhongDTO> LayDanhSachPhong()
        {
            List<string[]> _list = new List<string[]>();
            List<PhongDTO> _data = new List<PhongDTO>();

            string query = string.Format("SELECT * FROM phong");
            _list = DBConnection.getInstance().Select(query);

            foreach (var item in _list)
            {
                PhongDTO _temp = new PhongDTO();
                _temp.IdPhong = item[0];
                _temp.TenPhong = item[1];
                _temp.LoaiPhong = Int32.Parse(item[2]);
                _temp.TrangThai = item[3];
                _temp.Dongia = Int32.Parse(item[4]);                

                _data.Add(_temp);
            }
            return _data;
        }
        public PhongDTO LayThongTinPhong(string _id)
        {
            List<string[]> _list = new List<string[]>();
            PhongDTO _data = new PhongDTO();

            string query = string.Format("SELECT * FROM phong WHERE IDPhong='{0}'", _id);
            _list = DBConnection.getInstance().Select(query);

            _data.IdPhong = _list[0][0];
            _data.TenPhong = _list[0][1];
            _data.LoaiPhong = Int32.Parse(_list[0][2]);
            _data.TrangThai = _list[0][3];
            _data.Dongia = Int32.Parse(_list[0][4]);

            return _data;
        }
        public bool XoaThongTinPhong(string _id)
        {
            string query = string.Format("DELETE FROM phong WHERE IDPhong= '{0}'", _id);
            return DBConnection.getInstance().Delete(query) ? true : false;
        }
        public bool ThemThongTinPhong(PhongDTO _phong)
        {
            string query = string.Format("INSERT INTO phong (IDPhong, TenPhong, LoaiPhong, TrangThai, DonGia) VALUES('{0}','{1}','{2}','{3}','{4}')", _phong.IdPhong, _phong.TenPhong, _phong.LoaiPhong, _phong.TrangThai, _phong.Dongia);
            return DBConnection.getInstance().Insert(query) ? true : false;
        }
        public bool CapNhatThongTinPhong(PhongDTO _phong)
        {
            string query = string.Format("UPDATE phong SET TenPhong = '{0}', LoaiPhong = '{1}', TrangThai = '{2}', DonGia = '{3}' WHERE  IDPhong= '{4}'", _phong.TenPhong, _phong.LoaiPhong, _phong.TrangThai, _phong.Dongia, _phong.IdPhong.ToString());
            return DBConnection.getInstance().Update(query) ? true : false;
        }

        //Phong Dang Su DUng
        public PhongDangSuDungDTO LayThongTinPhongDangSuDung(string _id)
        {
            List<string[]> _list = new List<string[]>();
            PhongDangSuDungDTO _data = new PhongDangSuDungDTO();

            string query = string.Format("SELECT * FROM phong_dangsudung WHERE IDPhong='{0}'", _id);
            _list = DBConnection.getInstance().Select(query);

            _data.IdPhong = _list[0][0];
            _data.ThoiGianBatDau = _list[0][1];
            _data.IdKhachHang = Int32.Parse(_list[0][2]).ToString();
            _data.DsDichVu = _list[0][3];
            _data.GiaDichVu = _list[0][4];      

            return _data;
        }
        public bool ThemThongTinPhongDangSuDung(PhongDangSuDungDTO _phong)
        {
            DateTime dateValue;
            if (DateTime.TryParse(_phong.ThoiGianBatDau, out dateValue))
            {
                string m = dateValue.ToString("yyyy-MM-dd'T'HH:mm:ss");

                string query = string.Format("INSERT INTO phong_dangsudung (IDPhong, ThoiGianBatDau, IDKhachHang, DsDichVu,GiaDichVu) VALUES('{0}','{1}','{2}','{3}','{4}')", _phong.IdPhong, m, _phong.IdKhachHang, _phong.DsDichVu, _phong.GiaDichVu);
                return DBConnection.getInstance().Insert(query);
            }
            return false;
        }
        public bool CapNhatThongTinPhongDangSuDung(PhongDangSuDungDTO _phong)
        {
            //var n = DateTime.Parse(_phong.ThoiGianBatDau);          
      
            DateTime dateValue;
            if (DateTime.TryParse(_phong.ThoiGianBatDau, out dateValue))
            {
                string m = dateValue.ToString("yyyy-MM-dd'T'HH:mm:ss");

                string query = string.Format("UPDATE phong_dangsudung SET ThoiGianBatDau = '{0}', IDKhachHang = '{1}', DsDichVu = '{2}', GiaDichVu = '{3}' WHERE  IDPhong= '{4}'", m, _phong.IdKhachHang.ToString(), _phong.DsDichVu.ToString(), _phong.GiaDichVu, _phong.IdPhong.ToString());
                return DBConnection.getInstance().Update(query);
            }
            return false;
        }
        public bool XoaThongTinPhongDangSuDung(string _id)
        {
            string query = string.Format("DELETE FROM phong_dangsudung WHERE IDPhong= '{0}'", _id);
            return DBConnection.getInstance().Delete(query) ? true : false;
        }

    }
}
