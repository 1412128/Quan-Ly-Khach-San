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
    public partial class DanhSachBaoBieu : MetroForm
    {
        BaoBieuBUS _bus;
        public DanhSachBaoBieu()
        {
            InitializeComponent();

            dataGrdV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGrdV.AllowUserToResizeRows = false;
            dataGrdV.RowTemplate.Height = 40;

            _bus = new BaoBieuBUS();
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

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            DocDuLieu(_bus.LayDuDieuTheoDieuKien(txtTimKiem.Text.ToUpper()));
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu frmTrangChu = new TrangChu();
            frmTrangChu.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            int tmp = dataGrdV.CurrentCell.RowIndex;
            string index = dataGrdV.Rows[tmp].Cells[0].Value.ToString();
            BaoBieuDTO _ChiTietDTO = _bus.LayThongTinBaoBieu(index);

            BaoBieu frmBaoBieu = new BaoBieu(_ChiTietDTO.IdBaoBieu);
            frmBaoBieu.Show();
        }
    }
}
