namespace Samples.UIForms
{
    partial class frmRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lineUsername = new System.Windows.Forms.Panel();
            this.linePassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picShowPass = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUser.Location = new System.Drawing.Point(81, 175);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(186, 24);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "Username";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // lineUsername
            // 
            this.lineUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lineUsername.Location = new System.Drawing.Point(35, 207);
            this.lineUsername.Name = "lineUsername";
            this.lineUsername.Size = new System.Drawing.Size(250, 1);
            this.lineUsername.TabIndex = 3;
            // 
            // linePassword
            // 
            this.linePassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.linePassword.Location = new System.Drawing.Point(35, 289);
            this.linePassword.Name = "linePassword";
            this.linePassword.Size = new System.Drawing.Size(250, 1);
            this.linePassword.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Location = new System.Drawing.Point(81, 257);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(186, 24);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(148)))), ((int)(((byte)(233)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRegister.Location = new System.Drawing.Point(35, 326);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(250, 44);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(89)))), ((int)(((byte)(81)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(0, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(325, 44);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picShowPass
            // 
            this.picShowPass.BackgroundImage = global::Samples.UIForms.Properties.Resources.notification_warningW;
            this.picShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowPass.Location = new System.Drawing.Point(270, 267);
            this.picShowPass.Name = "picShowPass";
            this.picShowPass.Size = new System.Drawing.Size(16, 16);
            this.picShowPass.TabIndex = 10;
            this.picShowPass.TabStop = false;
            this.picShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picShowPass_MouseDown);
            this.picShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picShowPass_MouseUp);
            // 
            // picPassword
            // 
            this.picPassword.BackgroundImage = global::Samples.UIForms.Properties.Resources.pass1;
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPassword.Location = new System.Drawing.Point(35, 251);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(32, 32);
            this.picPassword.TabIndex = 4;
            this.picPassword.TabStop = false;
            // 
            // picUsername
            // 
            this.picUsername.BackgroundImage = global::Samples.UIForms.Properties.Resources.userW;
            this.picUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picUsername.Location = new System.Drawing.Point(35, 169);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(32, 32);
            this.picUsername.TabIndex = 1;
            this.picUsername.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegister
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(325, 475);
            this.Controls.Add(this.picShowPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.linePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lineUsername);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.picUsername);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel lineUsername;
        private System.Windows.Forms.Panel linePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picShowPass;
    }
}

