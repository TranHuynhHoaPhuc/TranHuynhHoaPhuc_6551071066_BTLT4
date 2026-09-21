namespace BTCh4_Bai2
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
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGoiTap = new ComboBox();
            numSoBuoiTap = new NumericUpDown();
            btnDangKy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            toolTip1 = new ToolTip(components);
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTap).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(184, 84);
            txtHoTen.Margin = new Padding(4, 4, 4, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(155, 31);
            txtHoTen.TabIndex = 0;
            toolTip1.SetToolTip(txtHoTen, "Ghi đầy đủ học và tên, viết hoa chữ cái đầu");
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(184, 139);
            txtSDT.Margin = new Padding(4, 4, 4, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(155, 31);
            txtSDT.TabIndex = 1;
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(184, 204);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 31);
            txtEmail.TabIndex = 2;
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(184, 268);
            dtpNgaySinh.Margin = new Padding(4, 4, 4, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(312, 31);
            dtpNgaySinh.TabIndex = 3;
            // 
            // cboGoiTap
            // 
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Location = new Point(184, 331);
            cboGoiTap.Margin = new Padding(4, 4, 4, 4);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(188, 33);
            cboGoiTap.TabIndex = 4;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            cboGoiTap.SelectedIndexChanged += cboGoiTap_SelectedIndexChanged;
            // 
            // numSoBuoiTap
            // 
            numSoBuoiTap.Location = new Point(184, 396);
            numSoBuoiTap.Margin = new Padding(4, 4, 4, 4);
            numSoBuoiTap.Name = "numSoBuoiTap";
            numSoBuoiTap.Size = new Size(188, 31);
            numSoBuoiTap.TabIndex = 5;
            toolTip1.SetToolTip(numSoBuoiTap, "Số buổi tập từ 1-7 buổi trong tuần");
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(184, 469);
            btnDangKy.Margin = new Padding(4, 4, 4, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(118, 36);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(652, 155);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 58);
            label1.TabIndex = 7;
            label1.Text = "ĐĂNG KÝ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(544, 268);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(413, 54);
            label2.TabIndex = 8;
            label2.Text = "PHÒNG GYM FITLIFE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 9;
            label3.Text = "Họ tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 142);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 10;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 212);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 11;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 276);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 12;
            label6.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 341);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 13;
            label7.Text = "Gói tập:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 405);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(118, 25);
            label8.TabIndex = 14;
            label8.Text = "Số buổi tuần:";
            // 
            // toolTip1
            // 
            toolTip1.ShowAlways = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(437, 475);
            label9.Name = "label9";
            label9.Size = new Size(112, 25);
            label9.TabIndex = 15;
            label9.Text = "6551071066";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangKy);
            Controls.Add(numSoBuoiTap);
            Controls.Add(cboGoiTap);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Gym FitLife";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGoiTap;
        private NumericUpDown numSoBuoiTap;
        private Button btnDangKy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ToolTip toolTip1;
        private Label label9;
    }
}
