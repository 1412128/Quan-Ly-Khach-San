namespace QLKS.GUI
{
    partial class DanhSachBaoBieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachBaoBieu));
            this.dataGrdV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.txtTimKiem = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDangXuat = new MetroFramework.Controls.MetroLabel();
            this.ptbDangXuat1 = new QLKS.GUI.Component.ptbDangXuat(this.components);
            this.btnExit1 = new QLKS.GUI.Component.btnExit(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDangXuat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrdV
            // 
            this.dataGrdV.AllowUserToAddRows = false;
            this.dataGrdV.AllowUserToDeleteRows = false;
            this.dataGrdV.AllowUserToResizeColumns = false;
            this.dataGrdV.AllowUserToResizeRows = false;
            this.dataGrdV.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGrdV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrdV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrdV.Location = new System.Drawing.Point(-1, -3);
            this.dataGrdV.Name = "dataGrdV";
            this.dataGrdV.ReadOnly = true;
            this.dataGrdV.Size = new System.Drawing.Size(750, 241);
            this.dataGrdV.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTroVe);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnChiTiet);
            this.panel2.Location = new System.Drawing.Point(1, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 325);
            this.panel2.TabIndex = 9;
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.Plum;
            this.btnTroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTroVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTroVe.FlatAppearance.BorderSize = 0;
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(697, 290);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(80, 30);
            this.btnTroVe.TabIndex = 33;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.CustomButton.Image = null;
            this.txtTimKiem.CustomButton.Location = new System.Drawing.Point(732, 2);
            this.txtTimKiem.CustomButton.Name = "";
            this.txtTimKiem.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtTimKiem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimKiem.CustomButton.TabIndex = 1;
            this.txtTimKiem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimKiem.CustomButton.UseSelectable = true;
            this.txtTimKiem.CustomButton.Visible = false;
            this.txtTimKiem.DisplayIcon = true;
            this.txtTimKiem.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTimKiem.Icon = global::QLKS.Properties.Resources.kripto_search_b;
            this.txtTimKiem.IconRight = true;
            this.txtTimKiem.Lines = new string[0];
            this.txtTimKiem.Location = new System.Drawing.Point(27, 23);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.Size = new System.Drawing.Size(750, 20);
            this.txtTimKiem.TabIndex = 32;
            this.txtTimKiem.UseSelectable = true;
            this.txtTimKiem.WaterMark = "Nhập mã số báo biểu cần tìm";
            this.txtTimKiem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimKiem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGrdV);
            this.panel3.Location = new System.Drawing.Point(27, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 241);
            this.panel3.TabIndex = 28;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.Plum;
            this.btnChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTiet.FlatAppearance.BorderSize = 0;
            this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Location = new System.Drawing.Point(611, 290);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(80, 30);
            this.btnChiTiet.TabIndex = 25;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(639, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH BÁO BIỂU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(244, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 3);
            this.label4.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblDangXuat);
            this.panel1.Controls.Add(this.ptbDangXuat1);
            this.panel1.Controls.Add(this.btnExit1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 75);
            this.panel1.TabIndex = 8;
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.AutoSize = true;
            this.lblDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.lblDangXuat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblDangXuat.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDangXuat.Location = new System.Drawing.Point(719, 38);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(58, 15);
            this.lblDangXuat.TabIndex = 37;
            this.lblDangXuat.Text = "Đăng xuất";
            this.lblDangXuat.UseCustomBackColor = true;
            this.lblDangXuat.UseCustomForeColor = true;
            this.lblDangXuat.UseStyleColors = true;
            // 
            // ptbDangXuat1
            // 
            this.ptbDangXuat1.BackColor = System.Drawing.Color.Transparent;
            this.ptbDangXuat1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbDangXuat1.Image = ((System.Drawing.Image)(resources.GetObject("ptbDangXuat1.Image")));
            this.ptbDangXuat1.Location = new System.Drawing.Point(723, 7);
            this.ptbDangXuat1.Name = "ptbDangXuat1";
            this.ptbDangXuat1.Size = new System.Drawing.Size(43, 29);
            this.ptbDangXuat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDangXuat1.TabIndex = 36;
            this.ptbDangXuat1.TabStop = false;
            // 
            // btnExit1
            // 
            this.btnExit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit1.BackgroundImage")));
            this.btnExit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit1.FlatAppearance.BorderSize = 0;
            this.btnExit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit1.Location = new System.Drawing.Point(772, 6);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(27, 25);
            this.btnExit1.TabIndex = 35;
            this.btnExit1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QLKS.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // DanhSachBaoBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachBaoBieu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDangXuat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrdV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTroVe;
        private MetroFramework.Controls.MetroTextBox txtTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lblDangXuat;
        private Component.ptbDangXuat ptbDangXuat1;
        private Component.btnExit btnExit1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}