namespace Bai15WinForm
{
    // Ex1: Using DomainUpDown and NumericUpDown Controls
    public partial class Ex1Form : Form
    {
        public Ex1Form()
        {
            InitializeComponent();

            dudColor.Items.Add("Red");
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Blue");
            dudColor.Items.Add("Black");
            dudColor.Items.Add("Orange");
            dudColor.SelectedIndex = 1; // mặc định "Green" giống ảnh mẫu

            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, (float)nudSize.Value);
            lblSampleText.ForeColor = Color.FromName(dudColor.Text);
        }

        private void dudColor_SelectedItemChanged(object sender, EventArgs e)
        {
            // Typecast the object to DomainUpDown
            DomainUpDown dud = (DomainUpDown)sender;
            // Change color of lblSampleText to selected color
            lblSampleText.ForeColor = Color.FromName(dud.Text);
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            // Typecast the object to NumericUpDown
            NumericUpDown nud = (NumericUpDown)sender;
            // Change the font of lblSampleText to selected font size
            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, (float)nud.Value);
        }
    }
}
