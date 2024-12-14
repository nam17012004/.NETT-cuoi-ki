namespace BaiTapCuoiki
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            MaXe = new DataGridViewTextBoxColumn();
            TenXe = new DataGridViewTextBoxColumn();
            HangXe = new DataGridViewTextBoxColumn();
            LoaiXe = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            Soluong = new DataGridViewTextBoxColumn();
            Them = new DataGridViewButtonColumn();
            Sua = new DataGridViewButtonColumn();
            Xoa = new DataGridViewButtonColumn();
            label8 = new Label();
            textBox7 = new TextBox();
            Search_Button = new Button();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 99, 102);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 479);
            panel1.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(180, 379);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(138, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(180, 320);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(138, 27);
            textBox6.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(58, 379);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 9;
            label6.Text = "Nhập số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(58, 320);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 8;
            label7.Text = "Nhập giá bán";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(180, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(138, 27);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(58, 260);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 5;
            label4.Text = "Nhập loại xe";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(58, 197);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 4;
            label5.Text = "Nhập hãng xe";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(58, 140);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 1;
            label3.Text = "Nhập tên xe";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(58, 76);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhập mã xe";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 99, 102);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 486);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 137);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(207, 62);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(69, 62);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "CHỨC NĂNG";
            label1.Click += label1_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(7, 99, 102);
            panel3.Controls.Add(Search_Button);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(388, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 622);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaXe, TenXe, HangXe, LoaiXe, GiaBan, Soluong, Them, Sua, Xoa });
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(921, 542);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // MaXe
            // 
            MaXe.HeaderText = "Mã xe";
            MaXe.MinimumWidth = 6;
            MaXe.Name = "MaXe";
            MaXe.Width = 125;
            // 
            // TenXe
            // 
            TenXe.HeaderText = "Tên Xe";
            TenXe.MinimumWidth = 6;
            TenXe.Name = "TenXe";
            TenXe.Width = 125;
            // 
            // HangXe
            // 
            HangXe.HeaderText = "Hãng Xe";
            HangXe.MinimumWidth = 6;
            HangXe.Name = "HangXe";
            HangXe.Width = 125;
            // 
            // LoaiXe
            // 
            LoaiXe.HeaderText = "Loại Xe";
            LoaiXe.MinimumWidth = 6;
            LoaiXe.Name = "LoaiXe";
            LoaiXe.Width = 125;
            // 
            // GiaBan
            // 
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.Width = 125;
            // 
            // Soluong
            // 
            Soluong.HeaderText = "Số lượng";
            Soluong.MinimumWidth = 6;
            Soluong.Name = "Soluong";
            Soluong.Width = 125;
            // 
            // Them
            // 
            Them.HeaderText = "";
            Them.MinimumWidth = 6;
            Them.Name = "Them";
            Them.Width = 40;
            // 
            // Sua
            // 
            Sua.HeaderText = "";
            Sua.MinimumWidth = 6;
            Sua.Name = "Sua";
            Sua.Width = 40;
            // 
            // Xoa
            // 
            Xoa.HeaderText = "";
            Xoa.MinimumWidth = 6;
            Xoa.Name = "Xoa";
            Xoa.Width = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(148, 26);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(187, 23);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(431, 27);
            textBox7.TabIndex = 13;
            textBox7.TextChanged += this.textBox7_TextChanged;
            // 
            // Search_Button
            // 
            Search_Button.Location = new Point(624, 22);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(94, 29);
            Search_Button.TabIndex = 14;
            Search_Button.Text = "Tìm kiếm";
            Search_Button.UseVisualStyleBackColor = true;
            Search_Button.Click += Search_Button_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(69, 14);
            label9.Name = "label9";
            label9.Size = new Size(241, 32);
            label9.TabIndex = 1;
            label9.Text = "THÔNG TIN XE ĐẠP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 623);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += this.Form1_Load_2;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaXe;
        private DataGridViewTextBoxColumn TenXe;
        private DataGridViewTextBoxColumn HangXe;
        private DataGridViewTextBoxColumn LoaiXe;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn Soluong;
        private DataGridViewButtonColumn Them;
        private DataGridViewButtonColumn Sua;
        private DataGridViewButtonColumn Xoa;
        private Label label8;
        private Button Search_Button;
        private TextBox textBox7;
        private Label label9;
    }
}
