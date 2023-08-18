namespace Samples.UIForms
{
    public partial class frmLogin : Form
    {
        private enum eField
        {
            None,
            User,
            Pass

        }
        frmRegister formRegister;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void AlterFocusColor(eField field)
        {
            Color colorFocu = Color.FromArgb(90, 148, 233); // Color.FromArgb(78, 184, 206);

            txtUser.ForeColor = Color.WhiteSmoke;
            lineUsername.ForeColor = Color.WhiteSmoke;
            picUsername.BackgroundImage = Properties.Resources.userW;

            txtPassword.ForeColor = Color.WhiteSmoke;
            linePassword.ForeColor = Color.WhiteSmoke;
            picPassword.BackgroundImage = Properties.Resources.pass1;

            switch (field)
            {
                case eField.User:
                    txtUser.Clear();
                    txtUser.ForeColor = colorFocu;
                    lineUsername.ForeColor = colorFocu;
                    picUsername.BackgroundImage = Properties.Resources.user;
                    break;

                case eField.Pass:
                    txtPassword.Clear();
                    txtPassword.ForeColor = colorFocu;
                    linePassword.ForeColor = colorFocu;
                    picPassword.BackgroundImage = Properties.Resources.pass2;
                    break;

                default:
                    break;
            }

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            AlterFocusColor(eField.User);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            AlterFocusColor(eField.Pass);
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            AlterFocusColor(eField.None);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            AlterFocusColor(eField.None);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (formRegister is null)
                formRegister = new frmRegister();

            formRegister.SendToBack();
            formRegister.Show();

            timer1.Start();
        }

        private bool hideThis = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!hideThis)
            {

                formRegister.Left += 10;
                if (formRegister.Left >= (this.Left + this.Width - 20))
                {
                    //timer1.Stop();
                    this.TopMost = false;
                    this.Refresh();
                    formRegister.TopMost = true;
                    formRegister.BringToFront();
                    hideThis = true;
                }
            }
            else
            {
                formRegister.Left -= 10;
                if (formRegister.Left <= this.Left - 5)
                {
                    formRegister.Left = this.Left;
                    timer1.Stop();
                    hideThis = false;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            formRegister.Left -= 10;
            if (formRegister.Left <= this.Left - 5)
            {
                formRegister.Left = this.Left;
                timer2.Stop();
            }
        }


    }
}
