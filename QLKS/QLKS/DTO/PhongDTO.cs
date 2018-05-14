using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class PhongDTO
    {
        #region Attribute
        private string _idPhong;
        private string _tenPhong;
        private int _loaiPhong;
        private string _trangThai;
        private float _dongia;

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

        public string TenPhong
        {
            get
            {
                return _tenPhong;
            }

            set
            {
                _tenPhong = value;
            }
        }

        public int LoaiPhong
        {
            get
            {
                return _loaiPhong;
            }

            set
            {
                _loaiPhong = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return _trangThai;
            }

            set
            {
                _trangThai = value;
            }
        }

        public float Dongia
        {
            get
            {
                return _dongia;
            }

            set
            {
                _dongia = value;
            }
        }
        #endregion
    }
}
