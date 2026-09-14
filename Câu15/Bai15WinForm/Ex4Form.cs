namespace Bai15WinForm
{
    // Ex4: Using TabControl Controls
    // Demo: chọn Message / Buttons / Icon qua các Tab rồi bấm Show! để hiển thị MessageBox tương ứng
    public partial class Ex4Form : Form
    {
        public Ex4Form()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (rbOKCancel.Checked) buttons = MessageBoxButtons.OKCancel;
            else if (rbRetryCancel.Checked) buttons = MessageBoxButtons.RetryCancel;
            else if (rbYesNo.Checked) buttons = MessageBoxButtons.YesNo;
            else if (rbYesNoCancel.Checked) buttons = MessageBoxButtons.YesNoCancel;

            MessageBoxIcon icon = MessageBoxIcon.None;
            if (rbError.Checked) icon = MessageBoxIcon.Error;
            else if (rbInformation.Checked) icon = MessageBoxIcon.Information;
            else if (rbQuestion.Checked) icon = MessageBoxIcon.Question;
            else if (rbWarning.Checked) icon = MessageBoxIcon.Warning;

            MessageBox.Show(txtMessage.Text, txtCaption.Text, buttons, icon);
        }

        private void rbLayout_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not RadioButton rb || !rb.Checked) return;

            if (rb == rbLayoutLeft) tabOptions.Alignment = TabAlignment.Left;
            else if (rb == rbLayoutRight) tabOptions.Alignment = TabAlignment.Right;
            else if (rb == rbLayoutTop) tabOptions.Alignment = TabAlignment.Top;
            else if (rb == rbLayoutBottom) tabOptions.Alignment = TabAlignment.Bottom;
        }
    }
}
