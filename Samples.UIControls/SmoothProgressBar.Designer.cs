namespace Samples.UIForms
{
    partial class SmoothProgressBar
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblProgress = new Label();
            SuspendLayout();
            // 
            // lblProgress
            // 
            lblProgress.Dock = DockStyle.Fill;
            lblProgress.Font = new Font("Verdana", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProgress.Location = new Point(1, 1);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(254, 8);
            lblProgress.TabIndex = 0;
            lblProgress.Text = "0%";
            lblProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SmoothProgressBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblProgress);
            Name = "SmoothProgressBar";
            Padding = new Padding(1);
            Size = new Size(256, 10);
            ResumeLayout(false);
        }

        #endregion

        private Label lblProgress;
    }
}
