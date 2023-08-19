namespace VerticalMenu
{
    partial class MenuItemWithSubItem
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenuItem = new VerticalMenu.ImageButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMenuItem
            // 
            this.btnMenuItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuItem.FlatAppearance.BorderSize = 0;
            this.btnMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItem.Location = new System.Drawing.Point(0, 0);
            this.btnMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuItem.Name = "btnMenuItem";
            this.btnMenuItem.Size = new System.Drawing.Size(150, 43);
            this.btnMenuItem.TabIndex = 2;
            this.btnMenuItem.Text = "\r\nNormal button";
            this.btnMenuItem.UseVisualStyleBackColor = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 43);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(150, 0);
            this.pnlContainer.TabIndex = 3;
            // 
            // MenuItemWithSubItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnMenuItem);
            this.Name = "MenuItemWithSubItem";
            this.Size = new System.Drawing.Size(150, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private ImageButton btnMenuItem;
        private System.Windows.Forms.Panel pnlContainer;
    }
}
