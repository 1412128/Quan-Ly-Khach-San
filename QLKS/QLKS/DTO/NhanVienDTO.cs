using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class NhanVienDTO
    {
        #region Attribute
        private string _idNhanVien;
        private string _tenNhanVien;
        private string _ngaySinh;
        private int _cmnd;
        private string _chucVu;
        private int _luong;

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

        public string TenNhanVien
        {
            get
            {
                return _tenNhanVien;
            }

            set
            {
                _tenNhanVien = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return _ngaySinh;
            }

            set
            {
                _ngaySinh = value;
            }
        }

        public int Cmnd
        {
            get
            {
                return _cmnd;
            }

            set
            {
                _cmnd = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return _chucVu;
            }

            set
            {
                _chucVu = value;
            }
        }

        public int Luong
        {
            get
            {
                return _luong;
            }

            set
            {
                _luong = value;
            }
        }
        #endregion
    }
}
