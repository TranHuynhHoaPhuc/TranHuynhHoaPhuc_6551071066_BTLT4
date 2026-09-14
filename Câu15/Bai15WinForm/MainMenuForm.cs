namespace Bai15WinForm
{
    // Form chính: menu để mở từng Exercise của Bài 15
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            new Ex1Form().Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            new Ex2Form().Show();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            new Ex3Form().Show();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            new Ex4Form().Show();
        }
    }
}
