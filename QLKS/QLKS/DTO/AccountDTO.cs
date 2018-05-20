using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class AccountDTO
    {
        #region Attribute
        private string _idTaiKhoan;
        private string _taiKhoan;
        private string _matKhau;

        public string IDTaiKhoan
        {
            get
            {
                return _idTaiKhoan;
            }

            set
            {
                _idTaiKhoan = value;
            }
        }

        public string TaiKhoan
        {
            get
            {
                return _taiKhoan;
            }

            set
            {
                _taiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _matKhau;
            }

            set
            {
                _matKhau = value;
            }
        }
        #endregion
    }
}
