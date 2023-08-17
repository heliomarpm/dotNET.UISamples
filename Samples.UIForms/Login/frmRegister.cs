using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.UIForms
{
    public partial class frmRegister : Form
    {
        private enum eField
        {
            None,
            User,
            Pass

        }

        frmLogin formLogin;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void AlterFocusColor(eField field)
        {
            Color colorFocu = Color.FromArgb(90, 148, 233); // Color.FromArgb(78, 184, 206);

            txtUser.ForeColor = Color.WhiteSmoke;
            lineUsername.BackColor = Color.WhiteSmoke;
            picUsername.BackgroundImage = Properties.Resources.userW;

            txtPassword.ForeColor = Color.WhiteSmoke;
            linePassword.BackColor = Color.WhiteSmoke;
            picPassword.BackgroundImage = Properties.Resources.pass1;

            switch (field)
            {
                case eField.User:
                    txtUser.Clear();
                    txtUser.ForeColor = colorFocu;
                    lineUsername.BackColor = colorFocu;
                    picUsername.BackgroundImage = Properties.Resources.user;
                    break;

                case eField.Pass:
                    txtPassword.Clear();
                    txtPassword.ForeColor = colorFocu;
                    linePassword.BackColor = colorFocu;
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Blink();

            //Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (formLogin is null)
                formLogin = new frmLogin();

            formLogin.SendToBack();
            formLogin.Show();
            timer1.Start();
        }

        private bool hideThis = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!hideThis)
            {
                formLogin.Left += 10;
                if (formLogin.Left >= (this.Left + this.Width - 20))
                {
                    this.TopMost = false;
                    this.Refresh();
                    formLogin.TopMost = true;
                    formLogin.BringToFront();
                    hideThis = true;
                }
            }
            else
            {
                formLogin.Left -= 10;
                if (formLogin.Left <= this.Left - 5)
                {
                    formLogin.Left = this.Left;
                    timer1.Stop();

                    hideThis = false;
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            formLogin.Left -= 10;
            if (formLogin.Left <= this.Left - 5)
            {
                formLogin.Left = this.Left;
                timer2.Stop();
            }
        }

        private void picShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            picShowPass.BackgroundImage = Properties.Resources.notification_warning;
            txtPassword.PasswordChar = new char();
        }

        private void picShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            picShowPass.BackgroundImage = Properties.Resources.notification_warningW;
            txtPassword.PasswordChar = '*';
        }

        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                this.ForeColor = this.ForeColor == Color.Chocolate ? Color.Turquoise : Color.Chocolate;
                this.BackColor = this.BackColor == Color.Turquoise ? Color.Chocolate : Color.Turquoise;
                lineUsername.BackColor = lineUsername.BackColor == Color.Red ? Color.Black : Color.Red;
                linePassword.BackColor = linePassword.BackColor == Color.Black ? Color.Red : Color.Black;
                btnRegister.ForeColor = btnRegister.ForeColor == Color.CadetBlue ? Color.Black : Color.CadetBlue;
                btnRegister.BackColor = btnRegister.BackColor == Color.Black ? Color.CadetBlue : Color.Black;
            }
        }
    }
}
