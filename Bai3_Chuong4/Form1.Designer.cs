namespace ToDoListDemo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtCongViecMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox lstCongViec;
        private System.Windows.Forms.Panel pnlTop;

        private System.Windows.Forms.ContextMenuStrip cmsCongViec;
        private System.Windows.Forms.ToolStripMenuItem mnuHoanThanh;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaMotCongViec;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaTatCa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlTop = new System.Windows.Forms.Panel();
            btnThem = new System.Windows.Forms.Button();
            txtCongViecMoi = new System.Windows.Forms.TextBox();
            lstCongViec = new System.Windows.Forms.ListBox();
            cmsCongViec = new System.Windows.Forms.ContextMenuStrip(components);
            mnuHoanThanh = new System.Windows.Forms.ToolStripMenuItem();
            mnuXoaMotCongViec = new System.Windows.Forms.ToolStripMenuItem();
            mnuXoaTatCa = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            pnlTop.SuspendLayout();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnThem);
            pnlTop.Controls.Add(txtCongViecMoi);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new System.Windows.Forms.Padding(14, 17, 14, 17);
            pnlTop.Size = new System.Drawing.Size(714, 83);
            pnlTop.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(557, 22);
            btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(129, 42);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new System.Drawing.Point(14, 23);
            txtCongViecMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new System.Drawing.Size(527, 31);
            txtCongViecMoi.TabIndex = 0;
            // 
            // lstCongViec
            // 
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            lstCongViec.ItemHeight = 25;
            lstCongViec.Location = new System.Drawing.Point(0, 83);
            lstCongViec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new System.Drawing.Size(714, 500);
            lstCongViec.TabIndex = 1;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new System.Drawing.Size(24, 24);
            cmsCongViec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuHoanThanh, mnuXoaMotCongViec, mnuXoaTatCa });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new System.Drawing.Size(257, 100);
            // 
            // mnuHoanThanh
            // 
            mnuHoanThanh.Name = "mnuHoanThanh";
            mnuHoanThanh.Size = new System.Drawing.Size(256, 32);
            mnuHoanThanh.Text = "Đánh dấu hoàn thành";
            mnuHoanThanh.Click += mnuHoanThanh_Click;
            // 
            // mnuXoaMotCongViec
            // 
            mnuXoaMotCongViec.Name = "mnuXoaMotCongViec";
            mnuXoaMotCongViec.Size = new System.Drawing.Size(256, 32);
            mnuXoaMotCongViec.Text = "Xóa công việc này";
            mnuXoaMotCongViec.Click += mnuXoaMotCongViec_Click;
            // 
            // mnuXoaTatCa
            // 
            mnuXoaTatCa.Name = "mnuXoaTatCa";
            mnuXoaTatCa.Size = new System.Drawing.Size(256, 32);
            mnuXoaTatCa.Text = "Xóa tất cả";
            mnuXoaTatCa.Click += mnuXoaTatCa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(321, 312);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 25);
            label1.TabIndex = 2;
            label1.Text = "6551071066";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(714, 583);
            Controls.Add(label1);
            Controls.Add(lstCongViec);
            Controls.Add(pnlTop);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Danh sách việc cần làm hằng ngày";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
    }
}
