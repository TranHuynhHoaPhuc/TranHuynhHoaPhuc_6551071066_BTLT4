namespace Bai15WinForm
{
    partial class Ex1Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblColor = new System.Windows.Forms.Label();
            this.dudColor = new System.Windows.Forms.DomainUpDown();
            this.lblSize = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblSampleText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            //
            // lblColor
            //
            this.lblColor.Location = new System.Drawing.Point(30, 30);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(60, 23);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color:";
            //
            // dudColor
            //
            this.dudColor.Location = new System.Drawing.Point(100, 27);
            this.dudColor.Name = "dudColor";
            this.dudColor.Size = new System.Drawing.Size(200, 23);
            this.dudColor.TabIndex = 1;
            this.dudColor.SelectedItemChanged += new System.EventHandler(this.dudColor_SelectedItemChanged);
            //
            // lblSize
            //
            this.lblSize.Location = new System.Drawing.Point(30, 80);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(60, 23);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size:";
            //
            // nudSize
            //
            this.nudSize.Location = new System.Drawing.Point(100, 77);
            this.nudSize.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            this.nudSize.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(200, 23);
            this.nudSize.TabIndex = 3;
            this.nudSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            //
            // lblSampleText
            //
            this.lblSampleText.Location = new System.Drawing.Point(30, 140);
            this.lblSampleText.Name = "lblSampleText";
            this.lblSampleText.Size = new System.Drawing.Size(340, 100);
            this.lblSampleText.TabIndex = 4;
            this.lblSampleText.Text = "Sample Text";
            this.lblSampleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // Ex1Form
            //
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.lblSampleText);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.dudColor);
            this.Controls.Add(this.lblColor);
            this.Name = "Ex1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ex1 - DomainUpDown & NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.DomainUpDown dudColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblSampleText;
    }
}
