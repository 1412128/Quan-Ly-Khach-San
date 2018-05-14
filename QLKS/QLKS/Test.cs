using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
           //string query = "INSERT INTO phong (IDPhong, TenPhong, LoaiPhong, TrangThai, DonGia) VALUES('A2', 'Phong Hang A', '0','Trống', '100000')";
            //string query1 = "UPDATE phong SET TrangThai='Đã Sử Dụng' WHERE IDPhong='A1'";
           // DBConnection.getInstance().Update(query);           
           
        }
    }
}
