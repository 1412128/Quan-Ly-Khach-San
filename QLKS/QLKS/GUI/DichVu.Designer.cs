namespace QLKS.GUI
{
    partial class DichVu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChiPhi = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblChiPhi);
            this.panel2.Controls.Add(this.metroTextBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 325);
            this.panel2.TabIndex = 3;
            // 
            // lblChiPhi
            // 
            this.lblChiPhi.BackColor = System.Drawing.Color.White;
            this.lblChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiPhi.ForeColor = System.Drawing.Color.Black;
            this.lblChiPhi.Location = new System.Drawing.Point(101, 281);
            this.lblChiPhi.Name = "lblChiPhi";
            this.lblChiPhi.Size = new System.Drawing.Size(154, 31);
            this.lblChiPhi.TabIndex = 47;
            this.lblChiPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblChiPhi.TextChanged += new System.EventHandler(this.lblChiPhi_TextChanged);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(432, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox1.Icon = global::QLKS.Properties.Resources.kripto_search_b;
            this.metroTextBox1.IconRight = true;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(27, 19);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(450, 20);
            this.metroTextBox1.TabIndex = 32;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Nhập mã số dịch vụ cần tìm";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(27, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 210);
            this.panel3.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(272, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 55);
            this.label8.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImage = global::QLKS.Properties.Resources.circled_left;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(387, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 55);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.BackgroundImage = global::QLKS.Properties.Resources.buttons;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(273, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 55);
            this.button1.TabIndex = 25;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(0, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 5);
            this.label3.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 75);
            this.panel1.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::QLKS.Properties.Resources.v_03_512;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(472, 1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(27, 25);
            this.button9.TabIndex = 31;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
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
            this.label2.Size = new System.Drawing.Size(395, 65);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH CÁC DỊCH VỤ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 55);
            this.label1.TabIndex = 24;
            this.label1.Text = "Chi phí: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DichVu";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblChiPhi;
        private System.Windows.Forms.Label label1;
    }
}