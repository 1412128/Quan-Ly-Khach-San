using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using QLKS.BUS;
using QLKS.DTO;

namespace QLKS.GUI
{
    public partial class DichVu : MetroForm
    {
        List<DichVuDTO> _data;
        int tongChiPhi = 0;
        private string dsDv ="";
        string idPhong;
      //  ObserverPattern op;
        public DichVu()
        {
            InitializeComponent();
            SettingControl();

        }
        public DichVu(string idPhong)
        {
            InitializeComponent();
            SettingControl();
            this.idPhong = idPhong;
        }
        private void SettingControl()
        {
            lblChiPhi.Text = tongChiPhi.ToString();
            lblChiPhi.TextChanged += new System.EventHandler(this.lblChiPhi_TextChanged);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.DataSource = LoadData();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = false;
        }
        private DataTable LoadData()
        {
            var table = new DataTable();
            table.Columns.Add(new DataColumn("ID Dịch Vụ", typeof(string)));
            table.Columns.Add(new DataColumn("Tên Dịch Vụ", typeof(string)));   
            table.Columns.Add(new DataColumn("Giá", typeof(string)));
            table.Columns.Add(new DataColumn("Tình Trạng", typeof(string)));
            table.Columns.Add(new DataColumn("Chọn", typeof(bool))); //this will show checkboxes
          

            DichVuBUS _dvBus = new DichVuBUS();
            _data = _dvBus.LayThongTinDichVuTheoTrangThai("Đang hoạt động");

            foreach (var item in _data)
            {
                string s = Global.Instance().ConvertCurrency(item.Gia.ToString());
                table.Rows.Add(item.IdDichVu.ToString(),item.TenDichVu.ToString(), s, item.TinhTrang.ToString(),false);
            }

            return table;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu op = new TrangChu();
            op.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu op = new TrangChu();
            if(dsDv == "") {
                op.Show();
            }
            else
            {
                op.onSubmit(dsDv, tongChiPhi, idPhong);
                op.Show();
            }
                        
           
        }

        private void button1_Click(object sender, EventArgs e)
        {          
                      
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if((bool)row.Cells["Chọn"].Value)
                {
                    dsDv += "," + row.Cells["ID Dịch Vụ"].Value.ToString();
                }
                //More code here
            }  
            
            PhongBUS phongBus = new PhongBUS();
            PhongDangSuDungDTO p = phongBus.LayThongTinPhongDangSuDung(idPhong);

            int s;          
            if (p.GiaDichVu == "")
            {
                s = 0;
            }
            else
            {
                s = Int32.Parse(p.GiaDichVu);
            }           
            p.GiaDichVu = (s + tongChiPhi).ToString();

            p.DsDichVu += dsDv;
           // string str = p.ThoiGianBatDau.ToString("mm/dd/yyyy");
            phongBus.CapNhatThongTinPhongDangSuDung(p);
            // Observer Pattern       
            TrangChu op = new TrangChu();  
            op.onSubmit(dsDv, tongChiPhi,idPhong);          
            this.Close();
            op.Show();
            //
            

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) // third-column 
            {
                int tmp = dataGridView1.CurrentCell.RowIndex;
                string sValue;            

                if ((bool)dataGridView1.Rows[tmp].Cells[4].Value)
                {
                    lblChiPhi_TextChanged(sender, e);
                    dataGridView1.Rows[tmp].Cells[4].Value = false;
                    sValue = dataGridView1.Rows[tmp].Cells[2].Value.ToString().Replace(",", "");
                    tongChiPhi -= Int32.Parse(sValue);
                }
                else
                {
                    lblChiPhi_TextChanged(sender, e);
                    dataGridView1.Rows[tmp].Cells[4].Value = true;
                    sValue = dataGridView1.Rows[tmp].Cells[2].Value.ToString().Replace(",", "");
                    tongChiPhi += Int32.Parse(sValue);
                }
                lblChiPhi_TextChanged(sender, e);
            }
            
           
        }

        private void lblChiPhi_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(s.ToString());
            string tmp = Global.Instance().ConvertCurrency(tongChiPhi.ToString());
            lblChiPhi.Text = tmp + " VND";
        }
    }
}
