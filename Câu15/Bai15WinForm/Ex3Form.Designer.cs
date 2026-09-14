namespace Bai15WinForm
{
    partial class Ex3Form
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbIndicator = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Progress Indicator:";
            //
            // pbIndicator
            //
            this.pbIndicator.Location = new System.Drawing.Point(20, 45);
            this.pbIndicator.Name = "pbIndicator";
            this.pbIndicator.Size = new System.Drawing.Size(360, 23);
            this.pbIndicator.TabIndex = 1;
            //
            // lblPercent
            //
            this.lblPercent.Location = new System.Drawing.Point(20, 80);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(300, 23);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "Percentage Complete: 0%";
            //
            // lblTrack
            //
            this.lblTrack.Location = new System.Drawing.Point(20, 130);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(340, 23);
            this.lblTrack.TabIndex = 3;
            this.lblTrack.Text = "Slide the TrackBar to control processing speed:";
            //
            // tbSpeed
            //
            this.tbSpeed.Location = new System.Drawing.Point(20, 160);
            this.tbSpeed.Maximum = 10;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(360, 45);
            this.tbSpeed.TabIndex = 4;
            this.tbSpeed.TickFrequency = 1;
            this.tbSpeed.Value = 5;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            //
            // timer
            //
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            //
            // Ex3Form
            //
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.pbIndicator);
            this.Controls.Add(this.lblTitle);
            this.Name = "Ex3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ex3 - Timer, TrackBar & ProgressBar";
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ProgressBar pbIndicator;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Timer timer;
    }
}
