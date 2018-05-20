using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using QLKS.DTO;
using QLKS.BUS;
using QLKS.GUI.Component;

namespace QLKS.GUI
{
    public partial class QLBaoBieu : MetroFramework.Forms.MetroForm
    {
        BaoBieuBUS _bus;  
        public QLBaoBieu()
        {
            //Component
            InitializeComponent();            

            dataGrdV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGrdV.AllowUserToResizeRows = false;
            dataGrdV.RowTemplate.Height = 40;

            _bus = new BaoBieuBUS();
            DocDuLieu(_bus.LayDuDieu());   
        }


        #region Layout

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DocDuLieu(_bus.LayDuDieu());
        }

        public void DocDuLieu(DataTable dt)
        {
            dataGrdV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrdV.DataSource = dt;
            dataGrdV.AllowUserToAddRows = false;
            dataGrdV.Dock = DockStyle.Bottom;
            dataGrdV.AllowUserToResizeColumns = false;            
        }

        #endregion
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ID Báo Biểu: " + index, "Xóa Báo biểu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!_bus.XoaThongTinBaoBieu(index))
                {
                    MessageBox.Show("Xóa thông tin báo biểu thất bại", "Thất bại",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DocDuLieu(_bus.LayDuDieu());
                    MessageBox.Show("Xóa thông tin báo biểu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DocDuLieu(_bus.LayDuDieuTheoDieuKien(txtTimKiem.Text.ToUpper()));
        }
    }
}
