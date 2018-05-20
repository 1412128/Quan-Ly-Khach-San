using MySql.Data.MySqlClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS.GUI.Component
{
    public partial class ptbTroVe : System.Windows.Forms.PictureBox
    {
        public ptbTroVe()
        {
            InitializeComponent();
            this.Name = "ptbTroVe";
            this.BackColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.Image = new Bitmap(QLKS.Properties.Resources.back_hand_drawn_arrow_outline_318_519611);
            this.Location = new Point(0, 0);
            this.Size = new Size(76, 74);
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public ptbTroVe(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnClick(EventArgs e)
        {
            this.FindForm().Hide();
            QLTrangChu ql = new QLTrangChu();
            ql.Show();
            base.OnClick(e);
        }
    }
}
