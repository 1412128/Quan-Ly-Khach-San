using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DTO;

namespace QLKS.DAO
{
    public class BaoBieuDAO
    {
        public BaoBieuDTO BaoBieuDTO
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<BaoBieuDTO> LayDanhSachBaoBieu()
        {
            List<string[]> _list = new List<string[]>();
            List<BaoBieuDTO> _data = new List<BaoBieuDTO>();

            string query = string.Format("SELECT * FROM baobieu");
            _list = DBConnection.getInstance().Select(query);

            foreach (var item in _list)
            {
                BaoBieuDTO _temp = new BaoBieuDTO();
                _temp.IdBaoBieu = item[0];
                _temp.IdPhong = item[1];
                _temp.IdNhanVien = item[2];
                _temp.IdKhachHang = item[3];
                _temp.ThoiGianBatDau = item[4];
                _temp.ThoiGianKetThuc = item[5];
                _temp.DsDichVu = item[6];
                _temp.TongTien = Int32.Parse(item[7]);

                _data.Add(_temp);
            }
            return _data;
        }
        public BaoBieuDTO LayThongTinBaoBieu(string _id)
        {
            List<string[]> _list = new List<string[]>();
            BaoBieuDTO _data = new BaoBieuDTO();

            string query = string.Format("SELECT * FROM baobieu WHERE IDBaoBieu='{0}'", _id);
            _list = DBConnection.getInstance().Select(query);

            _data.IdBaoBieu = _list[0][0];
            _data.IdPhong = _list[0][1];
            _data.IdNhanVien = _list[0][2];
            _data.IdKhachHang = _list[0][3];
            _data.ThoiGianBatDau = _list[0][4];
            _data.ThoiGianKetThuc = _list[0][5];
            _data.DsDichVu = _list[0][6];
            _data.TongTien = Int32.Parse(_list[0][7]);

            return _data;
        }
        public List<BaoBieuDTO> LayThongTinBaoBieuTheoIDKhachHang(string _id)
        {
            List<string[]> _list = new List<string[]>();
            List<BaoBieuDTO> _data = new List<BaoBieuDTO>();

            string query = string.Format("SELECT * FROM baobieu WHERE IDKhachHang ='{0}'",_id);
            _list = DBConnection.getInstance().Select(query);

            foreach (var item in _list)
            {
                BaoBieuDTO _temp = new BaoBieuDTO();
                _temp.IdBaoBieu = item[0];
                _temp.IdPhong = item[1];
                _temp.IdNhanVien = item[2];
                _temp.IdKhachHang = item[3];
                _temp.ThoiGianBatDau = item[4];
                _temp.ThoiGianKetThuc = item[5];
                _temp.DsDichVu = item[6];
                _temp.TongTien = Int32.Parse(item[7]);

                _data.Add(_temp);
            }
            return _data;
        }
        public bool XoaThongTinBaoBieu(string _id)
        {
            string query = string.Format("DELETE FROM baobieu WHERE IDBaoBieu= {0}", _id);
            return DBConnection.getInstance().Delete(query) ? true : false;
        }
        public bool ThemThongTinBaoBieu(BaoBieuDTO _baobieu)
        {
            DateTime dtBD = DateTime.Parse(_baobieu.ThoiGianBatDau);
            string mBD = dtBD.ToString("yyyy-MM-dd'T'HH:mm:ss");

            DateTime dtKT = DateTime.Parse(_baobieu.ThoiGianKetThuc);
            string mKT = dtKT.ToString("yyyy-MM-dd'T'HH:mm:ss");

            string query = string.Format("INSERT INTO baobieu (IDBaoBieu, IDPhong, IDNhanVien, IDKhachHang, ThoiGianBatDau, ThoiGianKetThuc, DSDichVu, TongTien) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", _baobieu.IdBaoBieu, _baobieu.IdPhong, _baobieu.IdNhanVien, _baobieu.IdKhachHang, mBD, mKT, _baobieu.DsDichVu, _baobieu.TongTien);
            return DBConnection.getInstance().Insert(query) ? true : false;
        }
        public bool CapNhatThongTinBaoBieu(BaoBieuDTO _baobieu)
        {
            DateTime dtBD = DateTime.Parse(_baobieu.ThoiGianBatDau);
            string mBD = dtBD.ToString("yyyy-MM-dd'T'HH:mm:ss");

            DateTime dtKT = DateTime.Parse(_baobieu.ThoiGianKetThuc);
            string mKT = dtKT.ToString("yyyy-MM-dd'T'HH:mm:ss");

            string query = string.Format("UPDATE baobieu SET IDPhong = '{0}', IDNhanVien = '{1}', IDKhachHang = '{2}', ThoiGianBatDau = '{3}', ThoiGianKetThuc = '{4}', DSDichVu = '{5}', TongTien ='{6}' WHERE  IDBaoBieu= '{5}'", _baobieu.IdPhong, _baobieu.IdNhanVien, _baobieu.IdKhachHang, mBD, mKT, _baobieu.DsDichVu, _baobieu.TongTien, _baobieu.IdBaoBieu);
            return DBConnection.getInstance().Update(query) ? true : false;
        }
    }
}
