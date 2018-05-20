namespace QLKS.GUI
{
    partial class BaoBieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoBieu));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCMNDKhach = new System.Windows.Forms.Label();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.lblThoiGianTraPhong = new System.Windows.Forms.Label();
            this.lblThoiGianDatPhong = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblIDPhong = new System.Windows.Forms.Label();
            this.lblIDBaoBieu = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChiPhi = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExit1 = new QLKS.GUI.Component.btnExit(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(125, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 3);
            this.label4.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 70);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHI TIẾT BÁO BIỂU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnExit1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 75);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QLKS.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Báo Biểu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(66, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "ID Phòng";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCMNDKhach);
            this.panel3.Controls.Add(this.lblTenKhach);
            this.panel3.Controls.Add(this.lblThoiGianTraPhong);
            this.panel3.Controls.Add(this.lblThoiGianDatPhong);
            this.panel3.Controls.Add(this.lblLoaiPhong);
            this.panel3.Controls.Add(this.lblIDPhong);
            this.panel3.Controls.Add(this.lblIDBaoBieu);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbl);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(27, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 269);
            this.panel3.TabIndex = 28;
            // 
            // lblCMNDKhach
            // 
            this.lblCMNDKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblCMNDKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMNDKhach.Location = new System.Drawing.Point(320, 56);
            this.lblCMNDKhach.Name = "lblCMNDKhach";
            this.lblCMNDKhach.Size = new System.Drawing.Size(115, 23);
            this.lblCMNDKhach.TabIndex = 45;
            this.lblCMNDKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhach.Location = new System.Drawing.Point(318, 13);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(115, 23);
            this.lblTenKhach.TabIndex = 44;
            this.lblTenKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThoiGianTraPhong
            // 
            this.lblThoiGianTraPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblThoiGianTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianTraPhong.Location = new System.Drawing.Point(118, 223);
            this.lblThoiGianTraPhong.Name = "lblThoiGianTraPhong";
            this.lblThoiGianTraPhong.Size = new System.Drawing.Size(100, 23);
            this.lblThoiGianTraPhong.TabIndex = 43;
            this.lblThoiGianTraPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThoiGianDatPhong
            // 
            this.lblThoiGianDatPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblThoiGianDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianDatPhong.Location = new System.Drawing.Point(118, 170);
            this.lblThoiGianDatPhong.Name = "lblThoiGianDatPhong";
            this.lblThoiGianDatPhong.Size = new System.Drawing.Size(100, 23);
            this.lblThoiGianDatPhong.TabIndex = 42;
            this.lblThoiGianDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(118, 119);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(100, 23);
            this.lblLoaiPhong.TabIndex = 41;
            this.lblLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIDPhong
            // 
            this.lblIDPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblIDPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPhong.Location = new System.Drawing.Point(118, 66);
            this.lblIDPhong.Name = "lblIDPhong";
            this.lblIDPhong.Size = new System.Drawing.Size(100, 23);
            this.lblIDPhong.TabIndex = 40;
            this.lblIDPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIDBaoBieu
            // 
            this.lblIDBaoBieu.BackColor = System.Drawing.Color.Transparent;
            this.lblIDBaoBieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBaoBieu.Location = new System.Drawing.Point(118, 15);
            this.lblIDBaoBieu.Name = "lblIDBaoBieu";
            this.lblIDBaoBieu.Size = new System.Drawing.Size(100, 23);
            this.lblIDBaoBieu.TabIndex = 39;
            this.lblIDBaoBieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(233, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 143);
            this.panel4.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(230, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Danh Sách Dịch Vụ Sử Dụng";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(231, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "CMND";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Thời Gian Trả Phòng";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Thời Gian Đặt Phòng";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(58, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Loại Phòng";
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(229, 17);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(83, 23);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Tên Khách Hàng";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblChiPhi);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnTroVe);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 325);
            this.panel2.TabIndex = 5;
            // 
            // lblChiPhi
            // 
            this.lblChiPhi.BackColor = System.Drawing.Color.Red;
            this.lblChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiPhi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblChiPhi.Location = new System.Drawing.Point(138, 284);
            this.lblChiPhi.Name = "lblChiPhi";
            this.lblChiPhi.Size = new System.Drawing.Size(253, 31);
            this.lblChiPhi.TabIndex = 46;
            this.lblChiPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 41);
            this.label12.TabIndex = 39;
            this.label12.Text = "Chi phí: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.Plum;
            this.btnTroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTroVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTroVe.FlatAppearance.BorderSize = 0;
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(397, 288);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(80, 30);
            this.btnTroVe.TabIndex = 34;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(200, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExit1
            // 
            this.btnExit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit1.BackgroundImage")));
            this.btnExit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit1.FlatAppearance.BorderSize = 0;
            this.btnExit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit1.Location = new System.Drawing.Point(470, 2);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(27, 25);
            this.btnExit1.TabIndex = 38;
            this.btnExit1.UseVisualStyleBackColor = true;
            // 
            // BaoBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BaoBieu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Component.btnExit btnExit1;
        private System.Windows.Forms.Label lblIDBaoBieu;
        private System.Windows.Forms.Label lblCMNDKhach;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblThoiGianTraPhong;
        private System.Windows.Forms.Label lblThoiGianDatPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblIDPhong;
        private System.Windows.Forms.Label lblChiPhi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}