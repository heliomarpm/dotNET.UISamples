using Samples.UIForms.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Samples.UIForms
{
    internal partial class FormAlert : Form
    {
        public enum enmAction
        {
            wait,
            start,
            close
        }

        private enmAction action;
        private int x, y;

        public FormAlert()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowAlert(string msg, AlertType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                var frm = (FormAlert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case AlertType.Success:
                    this.pictureBox1.Image = Resources.accept;
                    this.BackColor = Color.FromArgb(104, 174, 0);
                    break;
                case AlertType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.Red;
                    break;
                case AlertType.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case AlertType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.lblMsg.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

    }

    public enum AlertType
    {
        Success,
        Warning,
        Error,
        Info
    }

    public static class AlertBox
    {
        public static void ShowAlert(string message, AlertType type)
        {
            var frm = new FormAlert();
            frm.ShowAlert(message, type);
        }
    }
}