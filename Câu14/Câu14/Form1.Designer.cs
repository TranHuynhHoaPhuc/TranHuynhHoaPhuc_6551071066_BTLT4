namespace Câu14
{
    partial class frmCapNhat2ListBox
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
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            lblTenSV = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnSangPhai = new Button();
            btnSangHetPhai = new Button();
            btnSangTrai = new Button();
            btnSangHetTrai = new Button();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            statusStrip1 = new StatusStrip();
            tslThoiGian = new ToolStripStatusLabel();
            tslDesigned = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(102, 29);
            cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(103, 29);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Location = new Point(130, 83);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(68, 25);
            lblTenSV.TabIndex = 1;
            lblTenSV.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(216, 77);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(150, 31);
            txtTen.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(390, 74);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(112, 34);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Items.AddRange(new object[] { "Truong Xuan Quang", "", "Vu Thi Tuyet Minh" });
            lstLopA.Location = new Point(71, 150);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(180, 129);
            lstLopA.TabIndex = 4;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Items.AddRange(new object[] { "Le Duy Tinh" });
            lstLopB.Location = new Point(562, 150);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(180, 129);
            lstLopB.TabIndex = 5;
            // 
            // btnSangPhai
            // 
            btnSangPhai.Location = new Point(356, 150);
            btnSangPhai.Name = "btnSangPhai";
            btnSangPhai.Size = new Size(112, 34);
            btnSangPhai.TabIndex = 6;
            btnSangPhai.Text = ">";
            btnSangPhai.UseVisualStyleBackColor = true;
            btnSangPhai.Click += btnSangPhai_Click;
            // 
            // btnSangHetPhai
            // 
            btnSangHetPhai.Location = new Point(356, 179);
            btnSangHetPhai.Name = "btnSangHetPhai";
            btnSangHetPhai.Size = new Size(112, 34);
            btnSangHetPhai.TabIndex = 7;
            btnSangHetPhai.Text = ">>";
            btnSangHetPhai.UseVisualStyleBackColor = true;
            btnSangHetPhai.Click += btnSangHetPhai_Click;
            // 
            // btnSangTrai
            // 
            btnSangTrai.Location = new Point(356, 206);
            btnSangTrai.Name = "btnSangTrai";
            btnSangTrai.Size = new Size(112, 34);
            btnSangTrai.TabIndex = 8;
            btnSangTrai.Text = "<";
            btnSangTrai.UseVisualStyleBackColor = true;
            btnSangTrai.Click += btnSangTrai_Click;
            // 
            // btnSangHetTrai
            // 
            btnSangHetTrai.Location = new Point(356, 235);
            btnSangHetTrai.Name = "btnSangHetTrai";
            btnSangHetTrai.Size = new Size(112, 34);
            btnSangHetTrai.TabIndex = 9;
            btnSangHetTrai.Text = "<<";
            btnSangHetTrai.UseVisualStyleBackColor = true;
            btnSangHetTrai.Click += btnSangHetTrai_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Location = new Point(71, 375);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(112, 34);
            btnXoaLopA.TabIndex = 10;
            btnXoaLopA.Text = "Xóa Lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(356, 375);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(112, 34);
            btnKetThuc.TabIndex = 11;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Location = new Point(630, 375);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(112, 34);
            btnXoaLopB.TabIndex = 12;
            btnXoaLopB.Text = "Xóa Lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslThoiGian, tslDesigned });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslThoiGian
            // 
            tslThoiGian.Name = "tslThoiGian";
            tslThoiGian.Size = new Size(212, 25);
            tslThoiGian.Text = "11/30/2011 10:51:52 AM";
            // 
            // tslDesigned
            // 
            tslDesigned.Name = "tslDesigned";
            tslDesigned.Size = new Size(165, 25);
            tslDesigned.Text = "Designed by Xavier";
            // 
            // frmCapNhat2ListBox
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnSangHetTrai);
            Controls.Add(btnSangTrai);
            Controls.Add(btnSangHetPhai);
            Controls.Add(btnSangPhai);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(lblTenSV);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmCapNhat2ListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Cập Nhật 2 ListBox";
            FormClosing += frmCapNhat2ListBox_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private Label lblTenSV;
        private TextBox txtTen;
        private Button btnCapNhat;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btnSangPhai;
        private Button btnSangHetPhai;
        private Button btnSangTrai;
        private Button btnSangHetTrai;
        private Button btnXoaLopA;
        private Button btnKetThuc;
        private Button btnXoaLopB;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslThoiGian;
        private ToolStripStatusLabel tslDesigned;
    }
}
