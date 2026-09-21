namespace BTCh4_Bai4
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
            menuStrip1 = new MenuStrip();
            nghiệpVụToolStripMenuItem = new ToolStripMenuItem();
            menuBenhNhan = new ToolStripMenuItem();
            menuLichHen = new ToolStripMenuItem();
            menuCuaSo = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nghiệpVụToolStripMenuItem, menuCuaSo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = menuCuaSo;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1000, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuBenhNhan, menuLichHen });
            nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            nghiệpVụToolStripMenuItem.Size = new Size(110, 29);
            nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // menuBenhNhan
            // 
            menuBenhNhan.Name = "menuBenhNhan";
            menuBenhNhan.Size = new Size(279, 34);
            menuBenhNhan.Text = "Thông tin bệnh nhân";
            menuBenhNhan.Click += menuBenhNhan_Click;
            // 
            // menuLichHen
            // 
            menuLichHen.Name = "menuLichHen";
            menuLichHen.Size = new Size(279, 34);
            menuLichHen.Text = "Đặt lịch hẹn";
            menuLichHen.Click += menuLichHen_Click;
            // 
            // menuCuaSo
            // 
            menuCuaSo.Name = "menuCuaSo";
            menuCuaSo.Size = new Size(83, 29);
            menuCuaSo.Text = "Cửa sổ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 238);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 3;
            label1.Text = "6551071066";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Hệ thống quản lý phòng khám";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem menuBenhNhan;
        private ToolStripMenuItem menuLichHen;
        private ToolStripMenuItem menuCuaSo;
        private Label label1;
    }
}
