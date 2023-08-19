namespace VerticalMenuDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.vMenu1 = new VerticalMenu.VMenu();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vMenu1
            // 
            this.vMenu1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.vMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.vMenu1.Location = new System.Drawing.Point(0, 0);
            this.vMenu1.Name = "vMenu1";
            this.vMenu1.Size = new System.Drawing.Size(216, 733);
            this.vMenu1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(340, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dynamic add button";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 733);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.vMenu1);
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VerticalMenu.VMenu vMenu1;
        private System.Windows.Forms.Button btnAdd;
    }
}

