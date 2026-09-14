namespace Bai15WinForm
{
    // Ex2: The MonthCalendar and DateTimePicker Controls
    public partial class Ex2Form : Form
    {
        public Ex2Form()
        {
            InitializeComponent();

            mcTravel.MaxSelectionCount = 7; // cho phép chọn một khoảng ngày
            lblStartDate.Text = "StartDate:\n" + mcTravel.SelectionStart.ToShortDateString();
            lblEndDate.Text = "End Date:\n" + mcTravel.SelectionEnd.ToShortDateString();
        }

        private void mcTravel_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblStartDate.Text = "StartDate:\n" + e.Start.ToShortDateString();
            lblEndDate.Text = "End Date:\n" + e.End.ToShortDateString();
        }

        private void rbFormat_CheckedChanged(object sender, EventArgs e)
        {
            dtpLaunch.Format = rbLong.Checked ? DateTimePickerFormat.Long : DateTimePickerFormat.Short;
        }
    }
}
