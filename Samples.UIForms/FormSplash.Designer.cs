namespace Samples.UIForms
{
    partial class FormSplash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblAppName = new Label();
            lblAppVersion = new Label();
            circularProgressBar1 = new CircularProgressBar_NET5.CircularProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            pgb = new ProgressBar();
            pnlProgresso = new Panel();
            spb = new SmoothProgressBar();
            pnlProgresso.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Dock = DockStyle.Top;
            lblAppName.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.Location = new Point(24, 22);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(372, 77);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "App Name";
            // 
            // lblAppVersion
            // 
            lblAppVersion.AutoSize = true;
            lblAppVersion.Dock = DockStyle.Top;
            lblAppVersion.Location = new Point(24, 99);
            lblAppVersion.Name = "lblAppVersion";
            lblAppVersion.Padding = new Padding(10, 0, 0, 0);
            lblAppVersion.Size = new Size(133, 22);
            lblAppVersion.TabIndex = 1;
            lblAppVersion.Text = "App Version";
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            circularProgressBar1.AnimationSpeed = 500;
            circularProgressBar1.BackColor = Color.Transparent;
            circularProgressBar1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            circularProgressBar1.ForeColor = Color.White;
            circularProgressBar1.InnerColor = Color.Transparent;
            circularProgressBar1.InnerMargin = 2;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(531, 43);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.Gainsboro;
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 20;
            circularProgressBar1.ProgressColor = Color.FromArgb(255, 128, 0);
            circularProgressBar1.ProgressWidth = 20;
            circularProgressBar1.SecondaryFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar1.Size = new Size(125, 122);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.Step = 5;
            circularProgressBar1.SubscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = "";
            circularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "";
            circularProgressBar1.TabIndex = 2;
            circularProgressBar1.Text = "100%";
            circularProgressBar1.TextMargin = new Padding(2);
            circularProgressBar1.Value = 90;
            // 
            // pgb
            // 
            pgb.BackColor = Color.DarkOrange;
            pgb.Dock = DockStyle.Fill;
            pgb.ForeColor = Color.White;
            pgb.Location = new Point(4, 4);
            pgb.Name = "pgb";
            pgb.Size = new Size(610, 9);
            pgb.TabIndex = 3;
            // 
            // pnlProgresso
            // 
            pnlProgresso.BackColor = Color.White;
            pnlProgresso.Controls.Add(pgb);
            pnlProgresso.Location = new Point(38, 214);
            pnlProgresso.Name = "pnlProgresso";
            pnlProgresso.Padding = new Padding(4);
            pnlProgresso.Size = new Size(618, 17);
            pnlProgresso.TabIndex = 4;
            // 
            // spb
            // 
            spb.BorderColor = Color.White;
            spb.BorderStyle = SmoothProgressBar.EBorderStyle.Flat;
            spb.Location = new Point(38, 191);
            spb.Maximum = 100;
            spb.Minimum = 0;
            spb.Name = "spb";
            spb.Padding = new Padding(1);
            spb.ProgressBarColor = Color.White;
            spb.Size = new Size(618, 17);
            spb.TabIndex = 6;
            spb.TextAlign = ContentAlignment.MiddleCenter;
            spb.Value = 0;
            spb.VisibleLabel = true;
            // 
            // FormSplash
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(683, 253);
            Controls.Add(spb);
            Controls.Add(pnlProgresso);
            Controls.Add(circularProgressBar1);
            Controls.Add(lblAppVersion);
            Controls.Add(lblAppName);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormSplash";
            Padding = new Padding(24, 22, 24, 22);
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += FormSplash_FormClosing;
            pnlProgresso.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Label lblAppVersion;
        private CircularProgressBar_NET5.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar pgb;
        private Panel pnlProgresso;
        private SmoothProgressBar spb;
    }
}