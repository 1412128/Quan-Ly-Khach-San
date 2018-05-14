using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class DichVuDTO
    {
        #region Attribute
        private string _idDichVu;
        private string _tenDichVu;
        private float _gia;
        private string _tinhTrang;

        public string IdDichVu
        {
            get
            {
                return _idDichVu;
            }

            set
            {
                _idDichVu = value;
            }
        }

        public string TenDichVu
        {
            get
            {
                return _tenDichVu;
            }

            set
            {
                _tenDichVu = value;
            }
        }

        public float Gia
        {
            get
            {
                return _gia;
            }

            set
            {
                _gia = value;
            }
        }

        public string TinhTrang
        {
            get
            {
                return _tinhTrang;
            }

            set
            {
                _tinhTrang = value;
            }
        }
        #endregion
    }
}
