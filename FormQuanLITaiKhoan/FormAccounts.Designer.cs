﻿namespace Project.View
{
    partial class FormAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Data_Bikes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Panel_ThongTin = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Panel_ChucNang = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Panel_DuLieu = new System.Windows.Forms.Panel();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_btn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_btn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Copy_btn = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Bikes)).BeginInit();
            this.Panel_ThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Panel_ChucNang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Panel_DuLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(203, 127);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1033, 31);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Excel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tìm kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tất cả",
            "Họ tên",
            "Số điện thoại",
            "Email",
            "ID",
            "Vai trò"});
            this.comboBox1.Location = new System.Drawing.Point(396, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(524, 39);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(344, 30);
            this.textBox7.TabIndex = 1;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(76, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "QUẢN LÝ TÀI KHOẢN ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Project.Properties.Resources.edit;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 20;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Project.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 20;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Project.Properties.Resources.icons8_copy_16;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Data_Bikes);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(13, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1139, 679);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ liệu";
            // 
            // Data_Bikes
            // 
            this.Data_Bikes.BackgroundColor = System.Drawing.Color.White;
            this.Data_Bikes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Bikes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.SoDienThoai,
            this.Email,
            this.ID,
            this.PASS,
            this.ROLE,
            this.Add_btn,
            this.Delete_btn,
            this.Copy_btn});
            this.Data_Bikes.Location = new System.Drawing.Point(8, 91);
            this.Data_Bikes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Data_Bikes.Name = "Data_Bikes";
            this.Data_Bikes.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Data_Bikes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Data_Bikes.Size = new System.Drawing.Size(1125, 576);
            this.Data_Bikes.TabIndex = 5;
            this.Data_Bikes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Bikes_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(76, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vai trò:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(156, 287);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 26);
            this.textBox3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mật khẩu:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(156, 238);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 26);
            this.textBox5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(156, 143);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(209, 26);
            this.textBox6.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập ID:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(156, 191);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 26);
            this.textBox4.TabIndex = 4;
            // 
            // Panel_ThongTin
            // 
            this.Panel_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Panel_ThongTin.Controls.Add(this.label8);
            this.Panel_ThongTin.Controls.Add(this.groupBox1);
            this.Panel_ThongTin.Location = new System.Drawing.Point(0, 0);
            this.Panel_ThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_ThongTin.Name = "Panel_ThongTin";
            this.Panel_ThongTin.Size = new System.Drawing.Size(417, 501);
            this.Panel_ThongTin.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(399, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số điện thoại:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(156, 91);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(156, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 0;
            // 
            // Panel_ChucNang
            // 
            this.Panel_ChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Panel_ChucNang.Controls.Add(this.groupBox2);
            this.Panel_ChucNang.Location = new System.Drawing.Point(0, 487);
            this.Panel_ChucNang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_ChucNang.Name = "Panel_ChucNang";
            this.Panel_ChucNang.Size = new System.Drawing.Size(417, 201);
            this.Panel_ChucNang.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(5, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(399, 193);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // Panel_DuLieu
            // 
            this.Panel_DuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Panel_DuLieu.Controls.Add(this.groupBox3);
            this.Panel_DuLieu.Location = new System.Drawing.Point(412, 0);
            this.Panel_DuLieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_DuLieu.Name = "Panel_DuLieu";
            this.Panel_DuLieu.Size = new System.Drawing.Size(1157, 688);
            this.Panel_DuLieu.TabIndex = 4;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // PASS
            // 
            this.PASS.DataPropertyName = "PASS";
            this.PASS.HeaderText = "Mật khẩu";
            this.PASS.MinimumWidth = 6;
            this.PASS.Name = "PASS";
            this.PASS.Width = 125;
            // 
            // ROLE
            // 
            this.ROLE.DataPropertyName = "ROLE";
            this.ROLE.HeaderText = "Vai trò";
            this.ROLE.MinimumWidth = 6;
            this.ROLE.Name = "ROLE";
            this.ROLE.Width = 125;
            // 
            // Add_btn
            // 
            this.Add_btn.HeaderText = "";
            this.Add_btn.Image = global::Project.Properties.Resources.edit;
            this.Add_btn.MinimumWidth = 6;
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Width = 20;
            // 
            // Delete_btn
            // 
            this.Delete_btn.HeaderText = "";
            this.Delete_btn.Image = global::Project.Properties.Resources.delete;
            this.Delete_btn.MinimumWidth = 6;
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Width = 20;
            // 
            // Copy_btn
            // 
            this.Copy_btn.HeaderText = "";
            this.Copy_btn.Image = global::Project.Properties.Resources.icons8_copy_16;
            this.Copy_btn.MinimumWidth = 6;
            this.Copy_btn.Name = "Copy_btn";
            this.Copy_btn.Width = 20;
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 687);
            this.Controls.Add(this.Panel_ThongTin);
            this.Controls.Add(this.Panel_ChucNang);
            this.Controls.Add(this.Panel_DuLieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAccounts";
            this.Text = "FormAccounts";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Bikes)).EndInit();
            this.Panel_ThongTin.ResumeLayout(false);
            this.Panel_ThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Panel_ChucNang.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Panel_DuLieu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Data_Bikes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel Panel_ThongTin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Panel_ChucNang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel Panel_DuLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLE;
        private System.Windows.Forms.DataGridViewImageColumn Add_btn;
        private System.Windows.Forms.DataGridViewImageColumn Delete_btn;
        private System.Windows.Forms.DataGridViewImageColumn Copy_btn;
    }
}