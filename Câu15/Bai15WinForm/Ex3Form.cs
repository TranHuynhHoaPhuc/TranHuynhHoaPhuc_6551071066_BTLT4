namespace Bai15WinForm
{
    // Ex3: The Timer, TrackBar, and ProgressBar Controls
    public partial class Ex3Form : Form
    {
        public Ex3Form()
        {
            InitializeComponent();
            timer.Interval = 1000 / tbSpeed.Value;
            timer.Start();

            FormClosed += (s, e) => timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Tăng dần progress, quay lại 0 khi đầy
            pbIndicator.Value = (pbIndicator.Value + 1) % (pbIndicator.Maximum + 1);
            lblPercent.Text = $"Percentage Complete: {pbIndicator.Value}%";
        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            // TrackBar điều khiển tốc độ chạy của Timer (giá trị càng lớn càng nhanh)
            timer.Interval = Math.Max(50, 1000 / tbSpeed.Value);
        }
    }
}
