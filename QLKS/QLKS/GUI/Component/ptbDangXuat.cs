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
    public partial class ptbDangXuat : System.Windows.Forms.PictureBox
    {
        public ptbDangXuat()
        {
            InitializeComponent();

            this.Name = "ptbDangNhap";
            this.BackColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.Image = new Bitmap(QLKS.Properties.Resources._018_320_door_exit_logout_5121);
            this.Location = new Point(0, 0);
            this.Size = new Size(76, 74);
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public ptbDangXuat(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnClick(EventArgs e)
        {        
            foreach (Form item in Application.OpenForms)
            {
                item.Hide();
            }
            DangNhap dn = new DangNhap();
            
            dn.Show();
            base.OnClick(e);
        }
    }
}
