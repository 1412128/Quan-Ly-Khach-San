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
    public partial class btnExit : System.Windows.Forms.Button
    {
        public btnExit()
        {
            InitializeComponent();
            this.Name = "btnClose";
            this.Cursor = Cursors.Hand;
            this.BackgroundImage = new Bitmap(QLKS.Properties.Resources.v_03_512);
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.FlatStyle = FlatStyle.Flat;
            this.UseVisualStyleBackColor = true;
        }

        public btnExit(IContainer container)
        {
            container.Add(this);
            InitializeComponent();

        }
        protected override void OnClick(EventArgs e)
        {
            Application.Exit();
            base.OnClick(e);
        }
    }
}
