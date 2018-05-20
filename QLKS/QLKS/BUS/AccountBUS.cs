using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QLKS.DTO;
using QLKS.DAO;
namespace QLKS.BUS
{
    class AccountBUS
    {
        AccountDAO _dao = new AccountDAO();

        public List<AccountDTO> getAllAccount()
        {
            try
            {
                return _dao.getAllAccount();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public AccountDTO getAccount(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return _dao.getAccount(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool deleteAccount(string _id)
        {
            //Xu ly nghiep vu
            try
            {
                return _dao.deleteAccount(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool updateAccount(AccountDTO nv)
        {
            return _dao.updateAccount(nv);

        }
        public bool addAccount(AccountDTO nv)
        {
            //Xu ly nghiep vu    
            if (_dao.addAccount(nv))
            {
                return true;
            }
            return false;
        }
        public DataTable LayDuDieu()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID Account", typeof(string)).ReadOnly = true;
            table.Columns.Add("UserName", typeof(string));
            table.Columns.Add("PassWord", typeof(string));
           

            //Show data

            List<AccountDTO> _data = new List<AccountDTO>();
            _data = getAllAccount();
            foreach (var item in _data)
            {
                table.Rows.Add(item.IDTaiKhoan.ToString(), item.TaiKhoan.ToString(), item.MatKhau.ToString());
            }

            return table;
        }
        public DataTable LayDuDieuTheoDieuKien(string kitu)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID Account", typeof(string)).ReadOnly = true;
            table.Columns.Add("UserName", typeof(string));
            table.Columns.Add("PassWord", typeof(string));

            //Show data
            List<AccountDTO> _data = new List<AccountDTO>();
            _data = getAllAccount();
            foreach (var item in _data)
            {
                if (item.IDTaiKhoan.Contains(kitu))
                {
                    table.Rows.Add(item.IDTaiKhoan.ToString(), item.TaiKhoan.ToString(), item.MatKhau.ToString());
                }

            }

            return table;
        }

        public int KiemTraDangNhap(string taikhoan,string matkhau)
        {
            List<AccountDTO> _array = getAllAccount();
            foreach (var item in _array)
            {
                
                if (Compare(taikhoan,item.TaiKhoan) && Compare(matkhau,item.MatKhau))
                {
                   
                    string tmp = "nhanvien";    
                    if (taikhoan.IndexOf(tmp) >= 0)
                    {
                        
                        //Nhan vien
                        return 1;
                    }
                    else
                    {
                        //Quan ly
                        return 0;
                    }
                }                
            }
            return -1;
        }
        bool Compare(string s1, string s2)
        {
            return String.Compare(s1, s2) == 0;
        }
    }
}
