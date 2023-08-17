using CircularProgressBar_NET5;

namespace Samples.UIForms
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
            this.Opacity = 0;
            this.FormBorderStyle = FormBorderStyle.None;
            circularProgressBar1.Value = 0;

            this.BorderRadios(20);
            pnlProgresso.BorderRadios(16);
            pgb.BorderRadios(16);
        }

        protected override void OnLoad(EventArgs e)
        {
            lblAppName.Text = Application.ProductName;
            lblAppVersion.Text = "v" + Application.ProductVersion;
            this.TopMost = true;

            this.Animate(700, WinAPI.EFlagAnimate.BLEND);
            spb.Value = 0;

            StartProgress();
            base.OnLoad(e);
        }

        private void FormSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (true)
            {
                Task.Delay(5000);
                if (this.Opacity <= 0)
                    break;
                else
                    this.Opacity -= 0.05;
            }

            this.Dispose();
        }

        private async void StartProgress()
        {
            while (true)
            {
                await Task.Delay(50);
                pgb.Value += 1;
                spb.Value += 1;
                circularProgressBar1.Value += 1;
                circularProgressBar1.Text = $"{circularProgressBar1.Value}%";

                if (pgb.Value >= 100)
                {
                    new frmLogin().Show();
                    this.Hide();
                    break;
                }
            }
        }
    }
}