using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLKS.DTO;

namespace QLKS.DAO
{
    public class AccountDAO
    {
        public AccountDTO getAccount(string _taiKhoan)
        {
            List<string[]> _list;
            AccountDTO _data = new AccountDTO(); ;
            string query = string.Format("SELECT * FROM account_nhanvien WHERE TaiKhoan ={0}",_taiKhoan);
            _list = DBConnection.getInstance().Select(query);
            _data.IdNhanVien = _list[0][0];
            _data.TaiKhoan = _list[0][1];
            _data.MatKhau = _list[0][2];
            return _data;
        }   
        public bool updateAccount(AccountDTO _user)
        {            
            string query = string.Format("UPDATE account_nhanvien SET MATKHAU ={0} WHERE TaiKhoan ={1}", _user.MatKhau, _user.TaiKhoan);
            return DBConnection.getInstance().Update(query) ? true : false;
        }
        public bool addAccount(AccountDTO _user)
        {
            string query = string.Format("INSERT INTO account_nhanvien (IDNhanVien, TaiKhoan, MatKhau)  VALUE=({0},{1},{2},{3})", _user.IdNhanVien, _user.TaiKhoan, _user.MatKhau);
            return DBConnection.getInstance().Insert(query) ? true : false;
        }
    }
}
