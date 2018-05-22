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
using System.IO;

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
        private void btnXuat_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }     
        private void ExportToExcel()
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dataGrdV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGrdV.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGrdV.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGrdV.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {       
            DocDuLieu(_bus.LayDuDieuLocTheoNgayThang(dtBatDau.Value, dtKetThuc.Value));
        }
    }
}
