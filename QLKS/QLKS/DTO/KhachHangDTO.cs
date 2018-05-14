using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class KhachHangDTO
    {
        #region Attribute
        private string _idKhachHang;
        private string _hoTen;
        private int _cmnd;
        private string _ngaySinh;
        private int _sdt;

        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
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

        public int Sdt
        {
            get
            {
                return _sdt;
            }

            set
            {
                _sdt = value;
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
