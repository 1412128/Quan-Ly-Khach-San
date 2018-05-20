using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.BUS;
using QLKS.DTO;

namespace QLKS
{
    class Global
    {
        private static Global _instance;
        private Global() { }
        public static Global Instance()
        {
            if (_instance == null)
            {
                _instance = new Global();
            }
            return _instance;
        }          
        public string ConvertCurrency(string s)
        {
            return string.Format("{0:#,0.#}", float.Parse(s));
        }
        public string idPhong()
        {
            PhongBUS dv = new PhongBUS();
            List<PhongDTO> _list = dv.LayDanhSachPhong();
            int idDichVu = 0;
            if (_list.Count != 0)
                idDichVu = Int32.Parse(_list[_list.Count - 1].IdPhong.ToString()) + 1;
            return idDichVu.ToString();
        }

        public string idDichVu()
        {      
            DichVuBUS dv = new DichVuBUS();
            List<DichVuDTO> _list = dv.LayDanhSachDichVu();
            int idDichVu = 0;
            if (_list.Count != 0)
                idDichVu = Int32.Parse(_list[_list.Count - 1].IdDichVu.ToString()) + 1;   
            return idDichVu.ToString();
        }
        public string idNhanVien()
        {
            NhanVienBUS dv = new NhanVienBUS();
            List<NhanVienDTO> _list = dv.LayDanhSachNhanVien();
            int idDichVu = 0;
            if (_list.Count != 0)
                idDichVu = Int32.Parse(_list[_list.Count - 1].IdNhanVien.ToString()) + 1;
            return idDichVu.ToString();
        }
        public string idAccount()
        {
            AccountBUS dv = new AccountBUS();
            List<AccountDTO> _list = dv.getAllAccount();
            int idDichVu = 0;
            if (_list.Count != 0) 
                idDichVu = Int32.Parse(_list[_list.Count - 1].IDTaiKhoan.ToString()) + 1;
            return idDichVu.ToString();
        }
    }
}
