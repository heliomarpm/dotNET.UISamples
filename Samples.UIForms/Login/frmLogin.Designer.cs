namespace Samples.UIForms
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            btnRegister = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            picPassword = new PictureBox();
            picUsername = new PictureBox();
            pictureBox1 = new PictureBox();
            lineUsername = new UIControls.Line();
            linePassword = new UIControls.Line();
            ((System.ComponentModel.ISupportInitialize)picPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(34, 36, 49);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.WhiteSmoke;
            txtUser.Location = new Point(81, 175);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(186, 24);
            txtUser.TabIndex = 2;
            txtUser.Text = "Username";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(34, 36, 49);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(81, 257);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(186, 24);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "Password";
            txtPassword.WordWrap = false;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(90, 148, 233);
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.ForeColor = Color.FromArgb(34, 36, 49);
            btnSignIn.Location = new Point(35, 332);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(250, 44);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(34, 36, 49);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(35, 392);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(250, 44);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 5;
            timer2.Tick += timer2_Tick;
            // 
            // picPassword
            // 
            picPassword.BackgroundImage = Properties.Resources.pass1;
            picPassword.BackgroundImageLayout = ImageLayout.None;
            picPassword.Location = new Point(35, 251);
            picPassword.Name = "picPassword";
            picPassword.Size = new Size(32, 32);
            picPassword.TabIndex = 4;
            picPassword.TabStop = false;
            // 
            // picUsername
            // 
            picUsername.BackgroundImage = Properties.Resources.userW;
            picUsername.BackgroundImageLayout = ImageLayout.None;
            picUsername.Location = new Point(35, 169);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(32, 32);
            picUsername.TabIndex = 1;
            picUsername.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(128, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lineUsername
            // 
            lineUsername.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lineUsername.BorderStyle = UIControls.Line.ELineStyle.LineFlat;
            lineUsername.ForeColor = Color.White;
            lineUsername.Location = new Point(36, 207);
            lineUsername.Margin = new Padding(0);
            lineUsername.MinimumSize = new Size(3, 3);
            lineUsername.Name = "lineUsername";
            lineUsername.Size = new Size(249, 3);
            lineUsername.TabIndex = 9;
            lineUsername.Thickness = 1;
            lineUsername.Vertical = false;
            // 
            // linePassword
            // 
            linePassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            linePassword.BorderStyle = UIControls.Line.ELineStyle.LineFlat;
            linePassword.ForeColor = Color.White;
            linePassword.Location = new Point(35, 286);
            linePassword.Margin = new Padding(0);
            linePassword.MinimumSize = new Size(3, 3);
            linePassword.Name = "linePassword";
            linePassword.Size = new Size(249, 3);
            linePassword.TabIndex = 10;
            linePassword.Thickness = 1;
            linePassword.Vertical = false;
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(325, 475);
            Controls.Add(linePassword);
            Controls.Add(lineUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(picPassword);
            Controls.Add(txtUser);
            Controls.Add(picUsername);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)picPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox picUsername;
        private TextBox txtUser;
        private TextBox txtPassword;
        private PictureBox picPassword;
        private Button btnSignIn;
        private Button btnRegister;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private UIControls.Line lineUsername;
        private UIControls.Line linePassword;
    }
}

