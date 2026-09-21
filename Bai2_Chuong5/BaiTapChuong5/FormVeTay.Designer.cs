namespace BaiTapChuong5
{
    partial class FormVeTay
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (butVe != null) butVe.Dispose();
                if (gVe != null) gVe.Dispose();
                if (bmpVe != null) bmpVe.Dispose();

                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblHuongDan = new System.Windows.Forms.Label();
            pnlCanvas = new CanvasPanel();
            lblViTri = new System.Windows.Forms.Label();
            lblTrangThai = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pnlCanvas.SuspendLayout();
            SuspendLayout();
            // 
            // lblHuongDan
            // 
            lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            lblHuongDan.ForeColor = System.Drawing.Color.DimGray;
            lblHuongDan.Location = new System.Drawing.Point(33, 29);
            lblHuongDan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new System.Drawing.Size(1000, 42);
            lblHuongDan.TabIndex = 0;
            lblHuongDan.Text = "Giữ chuột TRÁI và kéo để vẽ  |  Chuột PHẢI để xóa trắng bảng vẽ";
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = System.Drawing.Color.White;
            pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCanvas.Controls.Add(label2);
            pnlCanvas.Controls.Add(label1);
            pnlCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            pnlCanvas.Location = new System.Drawing.Point(33, 87);
            pnlCanvas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new System.Drawing.Size(1265, 844);
            pnlCanvas.TabIndex = 1;
            pnlCanvas.Paint += pnlCanvas_Paint;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;
            // 
            // lblViTri
            // 
            lblViTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblViTri.ForeColor = System.Drawing.Color.FromArgb(0, 90, 160);
            lblViTri.Location = new System.Drawing.Point(33, 958);
            lblViTri.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new System.Drawing.Size(433, 48);
            lblViTri.TabIndex = 2;
            lblViTri.Text = "Tọa độ: X = 0, Y = 0";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTrangThai.ForeColor = System.Drawing.Color.Green;
            lblTrangThai.Location = new System.Drawing.Point(500, 958);
            lblTrangThai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new System.Drawing.Size(333, 48);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Sẵn sàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(150, 199);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(229, 202);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 25);
            label2.TabIndex = 1;
            label2.Text = "6551071066";
            // 
            // FormVeTay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            ClientSize = new System.Drawing.Size(1360, 1050);
            Controls.Add(lblTrangThai);
            Controls.Add(lblViTri);
            Controls.Add(pnlCanvas);
            Controls.Add(lblHuongDan);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "FormVeTay";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bảng vẽ mini - Ghi chú nhanh bằng tay";
            pnlCanvas.ResumeLayout(false);
            pnlCanvas.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHuongDan;
        private BaiTapChuong5.CanvasPanel pnlCanvas;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
