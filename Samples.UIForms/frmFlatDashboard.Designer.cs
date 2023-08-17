
namespace Samples.UIForms
{
    partial class frmFlatDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pnlNav = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnAnalytics = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            lblUserName = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            btnFormClose = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            label11 = new Label();
            btnFormMax = new Button();
            btnMin = new Button();
            circularProgressBar1 = new CircularProgressBar_NET5.CircularProgressBar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnAnalytics);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.FromArgb(0, 126, 249);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 489);
            panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 144);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(5, 42);
            pnlNav.TabIndex = 6;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Bottom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(0, 447);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 15, 0);
            button4.Size = new Size(180, 42);
            button4.TabIndex = 5;
            button4.Text = "Settings";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = true;
            button4.Click += NavMenuClick;
            button4.Leave += NavMenuLeave;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(0, 270);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 15, 0);
            button3.Size = new Size(180, 42);
            button3.TabIndex = 4;
            button3.Text = "Contact Us";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = true;
            button3.Click += NavMenuClick;
            button3.Leave += NavMenuLeave;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(0, 228);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 15, 0);
            button2.Size = new Size(180, 42);
            button2.TabIndex = 3;
            button2.Text = "Calendar";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = true;
            button2.Click += NavMenuClick;
            button2.Leave += NavMenuLeave;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnalytics.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnalytics.Location = new Point(0, 186);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Padding = new Padding(15, 0, 15, 0);
            btnAnalytics.Size = new Size(180, 42);
            btnAnalytics.TabIndex = 2;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.TextAlign = ContentAlignment.MiddleLeft;
            btnAnalytics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnalytics.UseVisualStyleBackColor = true;
            btnAnalytics.Click += NavMenuClick;
            btnAnalytics.Leave += NavMenuLeave;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 144);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 15, 0);
            btnDashboard.Size = new Size(180, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += NavMenuClick;
            btnDashboard.Leave += NavMenuLeave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 144);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(2, 121);
            label2.Name = "label2";
            label2.Size = new Size(177, 16);
            label2.TabIndex = 2;
            label2.Text = "Perfil";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(46, 101);
            lblUserName.Margin = new Padding(5, 0, 5, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(89, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ICON_128;
            pictureBox1.Location = new Point(42, 5);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 24);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(200, 200, 200);
            textBox1.Location = new Point(351, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = " Search";
            // 
            // btnFormClose
            // 
            btnFormClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFormClose.FlatAppearance.BorderSize = 0;
            btnFormClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnFormClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFormClose.FlatStyle = FlatStyle.Flat;
            btnFormClose.Font = new Font("Wingdings 2", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFormClose.ForeColor = Color.White;
            btnFormClose.Location = new Point(792, -1);
            btnFormClose.Name = "btnFormClose";
            btnFormClose.Size = new Size(32, 25);
            btnFormClose.TabIndex = 3;
            btnFormClose.Text = "Í";
            btnFormClose.UseVisualStyleBackColor = true;
            btnFormClose.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(207, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.insert_to_shopping_cart;
            pictureBox2.Location = new Point(135, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 50);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 77);
            label5.Name = "label5";
            label5.Size = new Size(123, 16);
            label5.TabIndex = 2;
            label5.Text = "Details for last 20 days";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(11, 38);
            label4.Name = "label4";
            label4.Size = new Size(89, 32);
            label4.TabIndex = 1;
            label4.Text = "$2500";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 8);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.TabIndex = 0;
            label3.Text = "Sales";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 64);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(423, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.dollar_currency_sign;
            pictureBox3.Location = new Point(135, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 50);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 77);
            label6.Name = "label6";
            label6.Size = new Size(123, 16);
            label6.TabIndex = 2;
            label6.Text = "Details for last 20 days";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(50, 226, 178);
            label7.Location = new Point(11, 38);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 1;
            label7.Text = "5K+";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 8);
            label8.Name = "label8";
            label8.Size = new Size(63, 30);
            label8.TabIndex = 0;
            label8.Text = "Profit";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(circularProgressBar1);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(207, 212);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 255);
            panel5.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(12, 8);
            label11.Name = "label11";
            label11.Size = new Size(60, 30);
            label11.TabIndex = 0;
            label11.Text = "Sales";
            // 
            // btnFormMax
            // 
            btnFormMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFormMax.FlatAppearance.BorderSize = 0;
            btnFormMax.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 54);
            btnFormMax.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 42, 64);
            btnFormMax.FlatStyle = FlatStyle.Flat;
            btnFormMax.Font = new Font("Wingdings", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormMax.ForeColor = Color.White;
            btnFormMax.Location = new Point(760, -1);
            btnFormMax.Name = "btnFormMax";
            btnFormMax.Size = new Size(32, 25);
            btnFormMax.TabIndex = 5;
            btnFormMax.Text = "ä";
            btnFormMax.UseVisualStyleBackColor = true;
            btnFormMax.Click += button5_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 54);
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 42, 64);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Wingdings", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(728, -1);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(32, 25);
            btnMin.TabIndex = 6;
            btnMin.Text = "â";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += button6_Click;
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
            circularProgressBar1.Location = new Point(25, 52);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.Gainsboro;
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 20;
            circularProgressBar1.ProgressColor = Color.FromArgb(50, 226, 178);
            circularProgressBar1.ProgressWidth = 20;
            circularProgressBar1.SecondaryFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar1.Size = new Size(150, 150);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.Step = 5;
            circularProgressBar1.SubscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = "";
            circularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "";
            circularProgressBar1.TabIndex = 3;
            circularProgressBar1.Text = "100%";
            circularProgressBar1.TextMargin = new Padding(2);
            circularProgressBar1.Value = 90;
            // 
            // frmFlatDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(825, 489);
            Controls.Add(btnMin);
            Controls.Add(btnFormMax);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(btnFormClose);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(158, 161, 176);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "frmFlatDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFlatDashboard";
            Load += frmFlatDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Label label2;
        private Label lblUserName;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnAnalytics;
        private Panel pnlNav;
        private Label label1;
        private TextBox textBox1;
        private Button btnFormClose;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private Label label11;
        private Button btnFormMax;
        private Button btnMin;
        private CircularProgressBar_NET5.CircularProgressBar circularProgressBar1;
    }
}