namespace Bai15WinForm
{
    partial class MainMenuForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bài 15: Sử dụng các control của Visual Studio";
            //
            // btnEx1
            //
            this.btnEx1.Location = new System.Drawing.Point(20, 70);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(320, 35);
            this.btnEx1.TabIndex = 1;
            this.btnEx1.Text = "Ex1: DomainUpDown && NumericUpDown";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            //
            // btnEx2
            //
            this.btnEx2.Location = new System.Drawing.Point(20, 115);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(320, 35);
            this.btnEx2.TabIndex = 2;
            this.btnEx2.Text = "Ex2: MonthCalendar && DateTimePicker";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            //
            // btnEx3
            //
            this.btnEx3.Location = new System.Drawing.Point(20, 160);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(320, 35);
            this.btnEx3.TabIndex = 3;
            this.btnEx3.Text = "Ex3: Timer, TrackBar, ProgressBar";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            //
            // btnEx4
            //
            this.btnEx4.Location = new System.Drawing.Point(20, 205);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(320, 35);
            this.btnEx4.TabIndex = 4;
            this.btnEx4.Text = "Ex4: TabControl";
            this.btnEx4.UseVisualStyleBackColor = true;
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            //
            // MainMenuForm
            //
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.btnEx4);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.btnEx1);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 15 - Using Controls of Visual Studio";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx4;
    }
}
