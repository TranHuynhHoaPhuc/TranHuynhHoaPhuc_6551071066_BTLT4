namespace Bai15WinForm
{
    partial class Ex2Form
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
            this.mcTravel = new System.Windows.Forms.MonthCalendar();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblLaunch = new System.Windows.Forms.Label();
            this.dtpLaunch = new System.Windows.Forms.DateTimePicker();
            this.rbLong = new System.Windows.Forms.RadioButton();
            this.rbShort = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Select the days you will travel:";
            //
            // mcTravel
            //
            this.mcTravel.Location = new System.Drawing.Point(20, 45);
            this.mcTravel.Name = "mcTravel";
            this.mcTravel.TabIndex = 1;
            this.mcTravel.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcTravel_DateChanged);
            //
            // lblStartDate
            //
            this.lblStartDate.Location = new System.Drawing.Point(260, 45);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(190, 40);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "StartDate:";
            //
            // lblEndDate
            //
            this.lblEndDate.Location = new System.Drawing.Point(260, 90);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(190, 40);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date:";
            //
            // lblLaunch
            //
            this.lblLaunch.Location = new System.Drawing.Point(20, 220);
            this.lblLaunch.Name = "lblLaunch";
            this.lblLaunch.Size = new System.Drawing.Size(200, 23);
            this.lblLaunch.TabIndex = 4;
            this.lblLaunch.Text = "Product Launch Date:";
            //
            // dtpLaunch
            //
            this.dtpLaunch.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpLaunch.Location = new System.Drawing.Point(20, 245);
            this.dtpLaunch.Name = "dtpLaunch";
            this.dtpLaunch.Size = new System.Drawing.Size(300, 23);
            this.dtpLaunch.TabIndex = 5;
            //
            // rbLong
            //
            this.rbLong.Checked = true;
            this.rbLong.Location = new System.Drawing.Point(20, 280);
            this.rbLong.Name = "rbLong";
            this.rbLong.Size = new System.Drawing.Size(100, 24);
            this.rbLong.TabIndex = 6;
            this.rbLong.TabStop = true;
            this.rbLong.Text = "Long Date";
            this.rbLong.CheckedChanged += new System.EventHandler(this.rbFormat_CheckedChanged);
            //
            // rbShort
            //
            this.rbShort.Location = new System.Drawing.Point(140, 280);
            this.rbShort.Name = "rbShort";
            this.rbShort.Size = new System.Drawing.Size(100, 24);
            this.rbShort.TabIndex = 7;
            this.rbShort.Text = "Short Date";
            this.rbShort.CheckedChanged += new System.EventHandler(this.rbFormat_CheckedChanged);
            //
            // Ex2Form
            //
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.rbShort);
            this.Controls.Add(this.rbLong);
            this.Controls.Add(this.dtpLaunch);
            this.Controls.Add(this.lblLaunch);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.mcTravel);
            this.Controls.Add(this.lblTitle);
            this.Name = "Ex2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ex2 - MonthCalendar & DateTimePicker";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MonthCalendar mcTravel;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblLaunch;
        private System.Windows.Forms.DateTimePicker dtpLaunch;
        private System.Windows.Forms.RadioButton rbLong;
        private System.Windows.Forms.RadioButton rbShort;
    }
}
