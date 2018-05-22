using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DTO;

namespace QLKS.DAO
{
    public class DichVuDAO
    {
        public List<DichVuDTO> LayDanhSachDichVu()
        {
            List<string[]> _list = new List<string[]>();
            List<DichVuDTO> _data = new List<DichVuDTO>();

            string query = string.Format("SELECT * FROM dichvu");
            _list = DBConnection.getInstance().Select(query);

            foreach (var item in _list)
            {
                DichVuDTO _temp = new DichVuDTO();
                _temp.IdDichVu = item[0];
                _temp.TenDichVu = item[1];
                _temp.Gia = Int32.Parse(item[2]);
                _temp.TinhTrang = item[3];               

                _data.Add(_temp);
            }
            return _data;
        }
        public DichVuDTO LayThongTinDichVu(string _id)
        {
            List<string[]> _list = new List<string[]>();
            DichVuDTO _data = new DichVuDTO();

            string query = string.Format("SELECT * FROM dichvu WHERE IDDichVu='{0}'", _id);
            _list = DBConnection.getInstance().Select(query);

            _data.IdDichVu = _list[0][0].ToString();
            _data.TenDichVu = _list[0][1];
            _data.Gia = Int32.Parse(_list[0][2]);
            _data.TinhTrang = _list[0][3];       

            return _data;
        }
        public List<DichVuDTO> LayThongTinDichVuTheoTrangThai(string trangthai)
        {   
            List<string[]> _list = new List<string[]>();
            List<DichVuDTO> _data = new List<DichVuDTO>();

            string query = string.Format("SELECT * FROM dichvu WHERE TinhTrang='{0}'", trangthai);
            _list = DBConnection.getInstance().Select(query);

            foreach (var item in _list)
            {
                DichVuDTO _temp = new DichVuDTO();
                _temp.IdDichVu = item[0];
                _temp.TenDichVu = item[1];
                _temp.Gia = Int32.Parse(item[2]);
                _temp.TinhTrang = item[3];

                _data.Add(_temp);
            }
            return _data;
        }
        public bool XoaThongTinDichVu(string _id)
        {
            string query = string.Format("DELETE FROM dichvu WHERE IDDichVu= {0}", _id);
            return DBConnection.getInstance().Delete(query) ? true : false;
        }
        public bool ThemThongTinDichVu(DichVuDTO _dichvu)
        {
            string query = string.Format("INSERT INTO dichvu (IDDichVu, TenDichVu, Gia, TinhTrang) VALUES('{0}','{1}','{2}','{3}')", _dichvu.IdDichVu, _dichvu.TenDichVu, _dichvu.Gia, _dichvu.TinhTrang);
            return DBConnection.getInstance().Insert(query) ? true : false;
        }
        public bool CapNhatThongTinDichVu(DichVuDTO _dichvu)
        {
            string query = string.Format("UPDATE dichvu SET TenDichVu = '{0}', Gia = '{1}', TinhTrang = '{2}' WHERE  IDDichVu = '{3}'", _dichvu.TenDichVu, _dichvu.Gia, _dichvu.TinhTrang,  _dichvu.IdDichVu);
            return DBConnection.getInstance().Update(query) ? true : false;
        }
    }
}
