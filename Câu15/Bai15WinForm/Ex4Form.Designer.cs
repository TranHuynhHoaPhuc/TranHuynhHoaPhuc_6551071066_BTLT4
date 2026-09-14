namespace Bai15WinForm
{
    partial class Ex4Form
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
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabMessage = new System.Windows.Forms.TabPage();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tabButtons = new System.Windows.Forms.TabPage();
            this.rbYesNoCancel = new System.Windows.Forms.RadioButton();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbRetryCancel = new System.Windows.Forms.RadioButton();
            this.rbOKCancel = new System.Windows.Forms.RadioButton();
            this.rbOK = new System.Windows.Forms.RadioButton();
            this.tabIcon = new System.Windows.Forms.TabPage();
            this.rbWarning = new System.Windows.Forms.RadioButton();
            this.rbQuestion = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbInformation = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.grpLayout = new System.Windows.Forms.GroupBox();
            this.rbLayoutBottom = new System.Windows.Forms.RadioButton();
            this.rbLayoutTop = new System.Windows.Forms.RadioButton();
            this.rbLayoutRight = new System.Windows.Forms.RadioButton();
            this.rbLayoutLeft = new System.Windows.Forms.RadioButton();
            this.tabOptions.SuspendLayout();
            this.tabMessage.SuspendLayout();
            this.tabButtons.SuspendLayout();
            this.tabIcon.SuspendLayout();
            this.grpLayout.SuspendLayout();
            this.SuspendLayout();
            //
            // tabOptions
            //
            this.tabOptions.Controls.Add(this.tabMessage);
            this.tabOptions.Controls.Add(this.tabButtons);
            this.tabOptions.Controls.Add(this.tabIcon);
            this.tabOptions.Location = new System.Drawing.Point(20, 20);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(360, 300);
            this.tabOptions.TabIndex = 0;
            //
            // tabMessage
            //
            this.tabMessage.Controls.Add(this.txtCaption);
            this.tabMessage.Controls.Add(this.lblCaption);
            this.tabMessage.Controls.Add(this.txtMessage);
            this.tabMessage.Controls.Add(this.lblMsg);
            this.tabMessage.Location = new System.Drawing.Point(4, 24);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Size = new System.Drawing.Size(352, 272);
            this.tabMessage.TabIndex = 0;
            this.tabMessage.Text = "Message";
            //
            // lblMsg
            //
            this.lblMsg.Location = new System.Drawing.Point(15, 15);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(250, 23);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Enter the message to display:";
            //
            // txtMessage
            //
            this.txtMessage.Location = new System.Drawing.Point(15, 40);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(300, 60);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "Sample Message";
            //
            // lblCaption
            //
            this.lblCaption.Location = new System.Drawing.Point(15, 110);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(250, 23);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "Enter a Caption for MessageBox:";
            //
            // txtCaption
            //
            this.txtCaption.Location = new System.Drawing.Point(15, 135);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(300, 23);
            this.txtCaption.TabIndex = 3;
            this.txtCaption.Text = "TabControl Demo";
            //
            // tabButtons
            //
            this.tabButtons.Controls.Add(this.rbYesNoCancel);
            this.tabButtons.Controls.Add(this.rbYesNo);
            this.tabButtons.Controls.Add(this.rbRetryCancel);
            this.tabButtons.Controls.Add(this.rbOKCancel);
            this.tabButtons.Controls.Add(this.rbOK);
            this.tabButtons.Location = new System.Drawing.Point(4, 24);
            this.tabButtons.Name = "tabButtons";
            this.tabButtons.Size = new System.Drawing.Size(352, 272);
            this.tabButtons.TabIndex = 1;
            this.tabButtons.Text = "Buttons";
            //
            // rbOK
            //
            this.rbOK.Checked = true;
            this.rbOK.Location = new System.Drawing.Point(15, 15);
            this.rbOK.Name = "rbOK";
            this.rbOK.Size = new System.Drawing.Size(200, 24);
            this.rbOK.TabIndex = 0;
            this.rbOK.TabStop = true;
            this.rbOK.Text = "OK";
            //
            // rbOKCancel
            //
            this.rbOKCancel.Location = new System.Drawing.Point(15, 45);
            this.rbOKCancel.Name = "rbOKCancel";
            this.rbOKCancel.Size = new System.Drawing.Size(200, 24);
            this.rbOKCancel.TabIndex = 1;
            this.rbOKCancel.Text = "OK and Cancel";
            //
            // rbRetryCancel
            //
            this.rbRetryCancel.Location = new System.Drawing.Point(15, 75);
            this.rbRetryCancel.Name = "rbRetryCancel";
            this.rbRetryCancel.Size = new System.Drawing.Size(200, 24);
            this.rbRetryCancel.TabIndex = 2;
            this.rbRetryCancel.Text = "Retry and Cancel";
            //
            // rbYesNo
            //
            this.rbYesNo.Location = new System.Drawing.Point(15, 105);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(200, 24);
            this.rbYesNo.TabIndex = 3;
            this.rbYesNo.Text = "Yes and No";
            //
            // rbYesNoCancel
            //
            this.rbYesNoCancel.Location = new System.Drawing.Point(15, 135);
            this.rbYesNoCancel.Name = "rbYesNoCancel";
            this.rbYesNoCancel.Size = new System.Drawing.Size(200, 24);
            this.rbYesNoCancel.TabIndex = 4;
            this.rbYesNoCancel.Text = "Yes, No and Cancel";
            //
            // tabIcon
            //
            this.tabIcon.Controls.Add(this.rbWarning);
            this.tabIcon.Controls.Add(this.rbQuestion);
            this.tabIcon.Controls.Add(this.rbNone);
            this.tabIcon.Controls.Add(this.rbInformation);
            this.tabIcon.Controls.Add(this.rbError);
            this.tabIcon.Location = new System.Drawing.Point(4, 24);
            this.tabIcon.Name = "tabIcon";
            this.tabIcon.Size = new System.Drawing.Size(352, 272);
            this.tabIcon.TabIndex = 2;
            this.tabIcon.Text = "Icon";
            //
            // rbError
            //
            this.rbError.Location = new System.Drawing.Point(15, 15);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(200, 24);
            this.rbError.TabIndex = 0;
            this.rbError.Text = "Error";
            //
            // rbInformation
            //
            this.rbInformation.Checked = true;
            this.rbInformation.Location = new System.Drawing.Point(15, 45);
            this.rbInformation.Name = "rbInformation";
            this.rbInformation.Size = new System.Drawing.Size(200, 24);
            this.rbInformation.TabIndex = 1;
            this.rbInformation.TabStop = true;
            this.rbInformation.Text = "Information";
            //
            // rbNone
            //
            this.rbNone.Location = new System.Drawing.Point(15, 75);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(200, 24);
            this.rbNone.TabIndex = 2;
            this.rbNone.Text = "None";
            //
            // rbQuestion
            //
            this.rbQuestion.Location = new System.Drawing.Point(15, 105);
            this.rbQuestion.Name = "rbQuestion";
            this.rbQuestion.Size = new System.Drawing.Size(200, 24);
            this.rbQuestion.TabIndex = 3;
            this.rbQuestion.Text = "Question";
            //
            // rbWarning
            //
            this.rbWarning.Location = new System.Drawing.Point(15, 135);
            this.rbWarning.Name = "rbWarning";
            this.rbWarning.Size = new System.Drawing.Size(200, 24);
            this.rbWarning.TabIndex = 4;
            this.rbWarning.Text = "Warning";
            //
            // btnShow
            //
            this.btnShow.Location = new System.Drawing.Point(150, 330);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show!";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            //
            // grpLayout
            //
            this.grpLayout.Controls.Add(this.rbLayoutBottom);
            this.grpLayout.Controls.Add(this.rbLayoutTop);
            this.grpLayout.Controls.Add(this.rbLayoutRight);
            this.grpLayout.Controls.Add(this.rbLayoutLeft);
            this.grpLayout.Location = new System.Drawing.Point(20, 370);
            this.grpLayout.Name = "grpLayout";
            this.grpLayout.Size = new System.Drawing.Size(360, 70);
            this.grpLayout.TabIndex = 2;
            this.grpLayout.TabStop = false;
            this.grpLayout.Text = "Tab Layout";
            //
            // rbLayoutLeft
            //
            this.rbLayoutLeft.Location = new System.Drawing.Point(20, 20);
            this.rbLayoutLeft.Name = "rbLayoutLeft";
            this.rbLayoutLeft.Size = new System.Drawing.Size(70, 24);
            this.rbLayoutLeft.TabIndex = 0;
            this.rbLayoutLeft.Text = "Left";
            this.rbLayoutLeft.CheckedChanged += new System.EventHandler(this.rbLayout_CheckedChanged);
            //
            // rbLayoutRight
            //
            this.rbLayoutRight.Location = new System.Drawing.Point(100, 20);
            this.rbLayoutRight.Name = "rbLayoutRight";
            this.rbLayoutRight.Size = new System.Drawing.Size(70, 24);
            this.rbLayoutRight.TabIndex = 1;
            this.rbLayoutRight.Text = "Right";
            this.rbLayoutRight.CheckedChanged += new System.EventHandler(this.rbLayout_CheckedChanged);
            //
            // rbLayoutTop
            //
            this.rbLayoutTop.Checked = true;
            this.rbLayoutTop.Location = new System.Drawing.Point(20, 40);
            this.rbLayoutTop.Name = "rbLayoutTop";
            this.rbLayoutTop.Size = new System.Drawing.Size(70, 24);
            this.rbLayoutTop.TabIndex = 2;
            this.rbLayoutTop.TabStop = true;
            this.rbLayoutTop.Text = "Top";
            this.rbLayoutTop.CheckedChanged += new System.EventHandler(this.rbLayout_CheckedChanged);
            //
            // rbLayoutBottom
            //
            this.rbLayoutBottom.Location = new System.Drawing.Point(100, 40);
            this.rbLayoutBottom.Name = "rbLayoutBottom";
            this.rbLayoutBottom.Size = new System.Drawing.Size(70, 24);
            this.rbLayoutBottom.TabIndex = 3;
            this.rbLayoutBottom.Text = "Bottom";
            this.rbLayoutBottom.CheckedChanged += new System.EventHandler(this.rbLayout_CheckedChanged);
            //
            // Ex4Form
            //
            this.ClientSize = new System.Drawing.Size(420, 460);
            this.Controls.Add(this.grpLayout);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.tabOptions);
            this.Name = "Ex4Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ex4 - TabControl";
            this.tabOptions.ResumeLayout(false);
            this.tabMessage.ResumeLayout(false);
            this.tabMessage.PerformLayout();
            this.tabButtons.ResumeLayout(false);
            this.tabIcon.ResumeLayout(false);
            this.grpLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabMessage;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.TabPage tabButtons;
        private System.Windows.Forms.RadioButton rbOK;
        private System.Windows.Forms.RadioButton rbOKCancel;
        private System.Windows.Forms.RadioButton rbRetryCancel;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.RadioButton rbYesNoCancel;
        private System.Windows.Forms.TabPage tabIcon;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.RadioButton rbInformation;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbQuestion;
        private System.Windows.Forms.RadioButton rbWarning;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox grpLayout;
        private System.Windows.Forms.RadioButton rbLayoutLeft;
        private System.Windows.Forms.RadioButton rbLayoutRight;
        private System.Windows.Forms.RadioButton rbLayoutTop;
        private System.Windows.Forms.RadioButton rbLayoutBottom;
    }
}
