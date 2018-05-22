using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class PhongDangSuDungDTO
    {
        string _idPhong;
        string _thoiGianBatDau;
        string _idKhachHang;
        string _DsDichVu;
        string _GiaDichVu;

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

        public string DsDichVu
        {
            get
            {
                return _DsDichVu;
            }

            set
            {
                _DsDichVu = value;
            }
        }

        public string GiaDichVu
        {
            get
            {
                return _GiaDichVu;
            }

            set
            {
                _GiaDichVu = value;
            }
        }
    }
}
