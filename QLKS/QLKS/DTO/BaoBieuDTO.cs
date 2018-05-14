using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class BaoBieuDTO
    {
        #region Attribute
        private string _idBaoBieu;
        private string _idPhong;
        private string _idNhanVien;
        private string _idKhachHang;
        private string _thoiGianBatDau;
        private string _thoiGianKetThuc;
        private string _dsDichVu;
        private float _tongTien;

        public string IdBaoBieu
        {
            get
            {
                return _idBaoBieu;
            }

            set
            {
                _idBaoBieu = value;
            }
        }

        public string IdPhong
        {
            get
            {
                return _idPhong;
            }

            set
            {
                _idPhong = value;
            }
        }

        public string IdNhanVien
        {
            get
            {
                return _idNhanVien;
            }

            set
            {
                _idNhanVien = value;
            }
        }

      

        public string ThoiGianBatDau
        {
            get
            {
                return _thoiGianBatDau;
            }

            set
            {
                _thoiGianBatDau = value;
            }
        }

        public string ThoiGianKetThuc
        {
            get
            {
                return _thoiGianKetThuc;
            }

            set
            {
                _thoiGianKetThuc = value;
            }
        }

        public string DsDichVu
        {
            get
            {
                return _dsDichVu;
            }

            set
            {
                _dsDichVu = value;
            }
        }

        public float TongTien
        {
            get
            {
                return _tongTien;
            }

            set
            {
                _tongTien = value;
            }
        }

        public string IdKhachHang
        {
            get
            {
                return _idKhachHang;
            }

            set
            {
                _idKhachHang = value;
            }
        }
        #endregion
    }
}
