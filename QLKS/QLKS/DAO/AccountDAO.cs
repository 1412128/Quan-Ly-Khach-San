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
        public AccountDTO AccountDTO
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public AccountDTO getAccount(string _taiKhoan)
        {
            List<string[]> _list;
            AccountDTO _data = new AccountDTO(); ;
            string query = string.Format("SELECT * FROM account_nhanvien WHERE IDTaiKhoan ={0}",_taiKhoan);
            _list = DBConnection.getInstance().Select(query);
            _data.IDTaiKhoan = _list[0][0];
            _data.TaiKhoan = _list[0][1];
            _data.MatKhau = _list[0][2];
            return _data;
        }
        public List<AccountDTO> getAllAccount()
        {
            List<string[]> _list = new List<string[]>();
            List<AccountDTO> _data = new List<AccountDTO>();

            string query = string.Format("SELECT * FROM account_nhanvien");
            _list = DBConnection.getInstance().Select(query);

            foreach (var item in _list)
            {
                AccountDTO _temp = new AccountDTO();
                _temp.IDTaiKhoan = item[0];
                _temp.TaiKhoan = item[1];
                _temp.MatKhau = item[2];

                _data.Add(_temp);
            }
            return _data;
        }
        public bool updateAccount(AccountDTO _user)
        {            
            string query = string.Format("UPDATE account_nhanvien SET MATKHAU ='{0}' WHERE IDTaiKhoan ='{1}'", _user.MatKhau, _user.IDTaiKhoan);
            return DBConnection.getInstance().Update(query) ? true : false;
        }
        public bool addAccount(AccountDTO _user)
        {
            string query = string.Format("INSERT INTO account_nhanvien (IDTaiKhoan, TaiKhoan, MatKhau)  VALUES('{0}','{1}','{2}')", _user.IDTaiKhoan, _user.TaiKhoan, _user.MatKhau);           
            return DBConnection.getInstance().Insert(query) ? true : false;
        }
        public bool deleteAccount(string _id)
        {
            string query = string.Format("DELETE FROM account_nhanvien WHERE IDTaiKhoan= {0}", _id);
            return DBConnection.getInstance().Delete(query) ? true : false;
        }
    }
}
