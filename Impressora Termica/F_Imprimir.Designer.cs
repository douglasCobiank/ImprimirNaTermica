namespace Impressora_Termica
{
    partial class F_Imprimir
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
            this.bt_Imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Imprimir
            // 
            this.bt_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Imprimir.Location = new System.Drawing.Point(12, 12);
            this.bt_Imprimir.Name = "bt_Imprimir";
            this.bt_Imprimir.Size = new System.Drawing.Size(286, 60);
            this.bt_Imprimir.TabIndex = 0;
            this.bt_Imprimir.Text = "Imprimir";
            this.bt_Imprimir.UseVisualStyleBackColor = true;
            this.bt_Imprimir.Click += new System.EventHandler(this.bt_Imprimir_Click);
            // 
            // F_Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 89);
            this.Controls.Add(this.bt_Imprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Imprimir";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Imprimir;
    }
}

