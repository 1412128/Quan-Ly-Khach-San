namespace QLKS.GUI
{
    partial class QLDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLDichVu));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbTrangThai = new MetroFramework.Controls.MetroComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonGia = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenPhong = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPhong = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.lblTroVe = new MetroFramework.Controls.MetroLabel();
            this.lblDangXuat = new MetroFramework.Controls.MetroLabel();
            this.lblLoad = new MetroFramework.Controls.MetroLabel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbDangXuat1 = new QLKS.GUI.Component.ptbDangXuat(this.components);
            this.ptbTroVe1 = new QLKS.GUI.Component.ptbTroVe(this.components);
            this.btnExit1 = new QLKS.GUI.Component.btnExit(this.components);
            this.ptbLogo1 = new QLKS.GUI.Component.ptbLogo(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrdV = new System.Windows.Forms.DataGridView();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDangXuat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTroVe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdV)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkBlue;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnCapNhat);
            this.panel4.Controls.Add(this.btnNhapLai);
            this.panel4.Location = new System.Drawing.Point(556, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 321);
            this.panel4.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.cbbTrangThai);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtDonGia);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtTenPhong);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtIdPhong);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(15, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 260);
            this.panel5.TabIndex = 39;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2"});
            this.cbbTrangThai.DisplayFocus = true;
            this.cbbTrangThai.DisplayMember = "0,1,2";
            this.cbbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbTrangThai.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.IntegralHeight = false;
            this.cbbTrangThai.ItemHeight = 19;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Tạm hết dịch vụ",
            "Tạm ngưng dịch vụ"});
            this.cbbTrangThai.Location = new System.Drawing.Point(65, 170);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(141, 25);
            this.cbbTrangThai.Sorted = true;
            this.cbbTrangThai.Style = MetroFramework.MetroColorStyle.Black;
            this.cbbTrangThai.TabIndex = 55;
            this.cbbTrangThai.UseSelectable = true;
            this.cbbTrangThai.ValueMember = "0,1,2";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 37);
            this.label8.TabIndex = 53;
            this.label8.Text = "Thêm/Cập nhật Dịch Vụ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDonGia
            // 
            // 
            // 
            // 
            this.txtDonGia.CustomButton.Image = null;
            this.txtDonGia.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtDonGia.CustomButton.Name = "";
            this.txtDonGia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDonGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDonGia.CustomButton.TabIndex = 1;
            this.txtDonGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDonGia.CustomButton.UseSelectable = true;
            this.txtDonGia.CustomButton.Visible = false;
            this.txtDonGia.Lines = new string[0];
            this.txtDonGia.Location = new System.Drawing.Point(65, 219);
            this.txtDonGia.MaxLength = 32767;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.SelectionLength = 0;
            this.txtDonGia.SelectionStart = 0;
            this.txtDonGia.Size = new System.Drawing.Size(141, 23);
            this.txtDonGia.TabIndex = 52;
            this.txtDonGia.UseSelectable = true;
            this.txtDonGia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDonGia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Đơn Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tình Trạng";
            // 
            // txtTenPhong
            // 
            // 
            // 
            // 
            this.txtTenPhong.CustomButton.Image = null;
            this.txtTenPhong.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtTenPhong.CustomButton.Name = "";
            this.txtTenPhong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenPhong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenPhong.CustomButton.TabIndex = 1;
            this.txtTenPhong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenPhong.CustomButton.UseSelectable = true;
            this.txtTenPhong.CustomButton.Visible = false;
            this.txtTenPhong.Lines = new string[0];
            this.txtTenPhong.Location = new System.Drawing.Point(65, 118);
            this.txtTenPhong.MaxLength = 32767;
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.PasswordChar = '\0';
            this.txtTenPhong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenPhong.SelectedText = "";
            this.txtTenPhong.SelectionLength = 0;
            this.txtTenPhong.SelectionStart = 0;
            this.txtTenPhong.Size = new System.Drawing.Size(141, 23);
            this.txtTenPhong.TabIndex = 46;
            this.txtTenPhong.UseSelectable = true;
            this.txtTenPhong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenPhong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tên Dịch Vụ";
            // 
            // txtIdPhong
            // 
            // 
            // 
            // 
            this.txtIdPhong.CustomButton.Image = null;
            this.txtIdPhong.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtIdPhong.CustomButton.Name = "";
            this.txtIdPhong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdPhong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdPhong.CustomButton.TabIndex = 1;
            this.txtIdPhong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdPhong.CustomButton.UseSelectable = true;
            this.txtIdPhong.CustomButton.Visible = false;
            this.txtIdPhong.Lines = new string[0];
            this.txtIdPhong.Location = new System.Drawing.Point(65, 66);
            this.txtIdPhong.MaxLength = 32767;
            this.txtIdPhong.Name = "txtIdPhong";
            this.txtIdPhong.PasswordChar = '\0';
            this.txtIdPhong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdPhong.SelectedText = "";
            this.txtIdPhong.SelectionLength = 0;
            this.txtIdPhong.SelectionStart = 0;
            this.txtIdPhong.Size = new System.Drawing.Size(141, 23);
            this.txtIdPhong.TabIndex = 44;
            this.txtIdPhong.UseSelectable = true;
            this.txtIdPhong.WaterMark = "ID Dịch vụ tự động tạo";
            this.txtIdPhong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdPhong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "ID Dịch Vụ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(15, 283);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 30);
            this.btnCapNhat.TabIndex = 37;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNhapLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhapLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapLai.FlatAppearance.BorderSize = 0;
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Location = new System.Drawing.Point(131, 283);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(100, 30);
            this.btnNhapLai.TabIndex = 38;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // lblTroVe
            // 
            this.lblTroVe.AutoSize = true;
            this.lblTroVe.BackColor = System.Drawing.Color.Transparent;
            this.lblTroVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTroVe.Location = new System.Drawing.Point(656, 45);
            this.lblTroVe.Name = "lblTroVe";
            this.lblTroVe.Size = new System.Drawing.Size(46, 19);
            this.lblTroVe.TabIndex = 37;
            this.lblTroVe.Text = "Trở về";
            this.lblTroVe.UseCustomBackColor = true;
            this.lblTroVe.UseCustomForeColor = true;
            this.lblTroVe.UseStyleColors = true;
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.AutoSize = true;
            this.lblDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.lblDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDangXuat.Location = new System.Drawing.Point(709, 45);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(68, 19);
            this.lblDangXuat.TabIndex = 36;
            this.lblDangXuat.Text = "Đăng xuất";
            this.lblDangXuat.UseCustomBackColor = true;
            this.lblDangXuat.UseCustomForeColor = true;
            this.lblDangXuat.UseStyleColors = true;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.BackColor = System.Drawing.Color.Transparent;
            this.lblLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoad.Location = new System.Drawing.Point(601, 45);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(43, 19);
            this.lblLoad.TabIndex = 34;
            this.lblLoad.Text = "Tải lại";
            this.lblLoad.UseCustomBackColor = true;
            this.lblLoad.UseCustomForeColor = true;
            this.lblLoad.UseStyleColors = true;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.BackgroundImage = global::QLKS.Properties.Resources.UI_Glyph_03_18_5121;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoad.Location = new System.Drawing.Point(601, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(43, 29);
            this.btnLoad.TabIndex = 33;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 70);
            this.label2.TabIndex = 0;
            this.label2.Text = "QUẢN LÝ DỊCH VỤ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ptbDangXuat1);
            this.panel1.Controls.Add(this.ptbTroVe1);
            this.panel1.Controls.Add(this.btnExit1);
            this.panel1.Controls.Add(this.ptbLogo1);
            this.panel1.Controls.Add(this.lblTroVe);
            this.panel1.Controls.Add(this.lblDangXuat);
            this.panel1.Controls.Add(this.lblLoad);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 75);
            this.panel1.TabIndex = 41;
            // 
            // ptbDangXuat1
            // 
            this.ptbDangXuat1.BackColor = System.Drawing.Color.Transparent;
            this.ptbDangXuat1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbDangXuat1.Image = ((System.Drawing.Image)(resources.GetObject("ptbDangXuat1.Image")));
            this.ptbDangXuat1.Location = new System.Drawing.Point(716, 13);
            this.ptbDangXuat1.Name = "ptbDangXuat1";
            this.ptbDangXuat1.Size = new System.Drawing.Size(43, 29);
            this.ptbDangXuat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDangXuat1.TabIndex = 44;
            this.ptbDangXuat1.TabStop = false;
            // 
            // ptbTroVe1
            // 
            this.ptbTroVe1.BackColor = System.Drawing.Color.Transparent;
            this.ptbTroVe1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbTroVe1.Image = ((System.Drawing.Image)(resources.GetObject("ptbTroVe1.Image")));
            this.ptbTroVe1.Location = new System.Drawing.Point(658, 10);
            this.ptbTroVe1.Name = "ptbTroVe1";
            this.ptbTroVe1.Size = new System.Drawing.Size(43, 29);
            this.ptbTroVe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbTroVe1.TabIndex = 43;
            this.ptbTroVe1.TabStop = false;
            // 
            // btnExit1
            // 
            this.btnExit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit1.BackgroundImage")));
            this.btnExit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit1.FlatAppearance.BorderSize = 0;
            this.btnExit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit1.Location = new System.Drawing.Point(770, 2);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(27, 25);
            this.btnExit1.TabIndex = 42;
            this.btnExit1.UseVisualStyleBackColor = true;
            // 
            // ptbLogo1
            // 
            this.ptbLogo1.Location = new System.Drawing.Point(0, 0);
            this.ptbLogo1.Name = "ptbLogo1";
            this.ptbLogo1.Size = new System.Drawing.Size(76, 74);
            this.ptbLogo1.TabIndex = 41;
            this.ptbLogo1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(177, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 3);
            this.label4.TabIndex = 28;
            // 
            // dataGrdV
            // 
            this.dataGrdV.AllowUserToAddRows = false;
            this.dataGrdV.AllowUserToDeleteRows = false;
            this.dataGrdV.AllowUserToOrderColumns = true;
            this.dataGrdV.AllowUserToResizeColumns = false;
            this.dataGrdV.AllowUserToResizeRows = false;
            this.dataGrdV.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGrdV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrdV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrdV.Location = new System.Drawing.Point(-1, 0);
            this.dataGrdV.Name = "dataGrdV";
            this.dataGrdV.ReadOnly = true;
            this.dataGrdV.Size = new System.Drawing.Size(500, 240);
            this.dataGrdV.TabIndex = 5;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.SpringGreen;
            this.btnChinhSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(309, 287);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(100, 30);
            this.btnChinhSua.TabIndex = 36;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SpringGreen;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(427, 287);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.CustomButton.Image = null;
            this.txtTimKiem.CustomButton.Location = new System.Drawing.Point(482, 2);
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
            this.txtTimKiem.Location = new System.Drawing.Point(27, 19);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.Size = new System.Drawing.Size(500, 20);
            this.txtTimKiem.TabIndex = 32;
            this.txtTimKiem.UseSelectable = true;
            this.txtTimKiem.WaterMark = "Nhập mã số dịch vụ cần tìm";
            this.txtTimKiem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimKiem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGrdV);
            this.panel3.Location = new System.Drawing.Point(27, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 240);
            this.panel3.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChinhSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 325);
            this.panel2.TabIndex = 40;
            // 
            // QLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "QLDichVu";
            this.Resizable = false;
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDangXuat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTroVe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroComboBox cbbTrangThai;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtTenPhong;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtIdPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnNhapLai;
        private Component.ptbDangXuat ptbDangXuat1;
        private Component.ptbTroVe ptbTroVe1;
        private Component.btnExit btnExit1;
        private Component.ptbLogo ptbLogo1;
        private MetroFramework.Controls.MetroLabel lblTroVe;
        private MetroFramework.Controls.MetroLabel lblDangXuat;
        private MetroFramework.Controls.MetroLabel lblLoad;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGrdV;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private MetroFramework.Controls.MetroTextBox txtTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}