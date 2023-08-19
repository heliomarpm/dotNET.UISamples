using Samples.UIControls;

namespace Samples.UIForms
{
    partial class FormMessage
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
            line3 = new Line();
            line4 = new Line();
            line6 = new Line();
            pictureBox1 = new PictureBox();
            line1 = new Line();
            btnFormClose = new Button();
            lblTitle = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // line3
            // 
            line3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            line3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            line3.BorderStyle = Line.ELineStyle.LineFlat;
            line3.ForeColor = Color.FromArgb(44, 92, 28);
            line3.Location = new Point(51, -1);
            line3.Margin = new Padding(0);
            line3.MinimumSize = new Size(5, 4);
            line3.Name = "line3";
            line3.Size = new Size(12, 200);
            line3.TabIndex = 2;
            line3.Thickness = 12;
            line3.Vertical = true;
            // 
            // line4
            // 
            line4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            line4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            line4.BorderStyle = Line.ELineStyle.LineFlat;
            line4.ForeColor = Color.FromArgb(69, 143, 45);
            line4.Location = new Point(63, -1);
            line4.Margin = new Padding(0);
            line4.MinimumSize = new Size(5, 4);
            line4.Name = "line4";
            line4.Size = new Size(12, 180);
            line4.TabIndex = 5;
            line4.Thickness = 12;
            line4.Vertical = true;
            // 
            // line6
            // 
            line6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            line6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            line6.BorderStyle = Line.ELineStyle.LineFlat;
            line6.ForeColor = Color.FromArgb(87, 181, 57);
            line6.Location = new Point(75, -1);
            line6.Margin = new Padding(0);
            line6.MinimumSize = new Size(5, 4);
            line6.Name = "line6";
            line6.Size = new Size(12, 160);
            line6.TabIndex = 6;
            line6.Thickness = 12;
            line6.Vertical = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(38, 38, 38);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.accept;
            pictureBox1.Location = new Point(28, 33);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // line1
            // 
            line1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            line1.BorderStyle = Line.ELineStyle.LineFlat;
            line1.Dock = DockStyle.Top;
            line1.ForeColor = Color.FromArgb(87, 181, 57);
            line1.Location = new Point(0, 0);
            line1.Margin = new Padding(0);
            line1.Name = "line1";
            line1.Size = new Size(585, 3);
            line1.TabIndex = 8;
            line1.Thickness = 3;
            line1.Vertical = false;
            // 
            // btnFormClose
            // 
            btnFormClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFormClose.FlatAppearance.BorderSize = 0;
            btnFormClose.FlatStyle = FlatStyle.Flat;
            btnFormClose.Font = new Font("Wingdings 2", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFormClose.ForeColor = Color.White;
            btnFormClose.Location = new Point(553, 5);
            btnFormClose.Name = "btnFormClose";
            btnFormClose.Size = new Size(32, 25);
            btnFormClose.TabIndex = 9;
            btnFormClose.Text = "Í";
            btnFormClose.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(131, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(49, 25);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Title";
            // 
            // label1
            // 
            label1.Location = new Point(131, 52);
            label1.Name = "label1";
            label1.Size = new Size(442, 107);
            label1.TabIndex = 11;
            label1.Text = "message";
            // 
            // FormMessage
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(585, 240);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(btnFormClose);
            Controls.Add(line1);
            Controls.Add(pictureBox1);
            Controls.Add(line6);
            Controls.Add(line4);
            Controls.Add(line3);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Line line3;
        private Line line4;
        private Line line6;
        private PictureBox pictureBox1;
        private Line line1;
        private Button btnFormClose;
        private Label lblTitle;
        private Label label1;
    }
}