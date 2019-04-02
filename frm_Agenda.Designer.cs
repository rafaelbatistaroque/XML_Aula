namespace C_Sharp_Intermediario
{
    partial class frm_Agenda
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbx_Contato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(73, 37);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Lista";
            // 
            // lbx_Contato
            // 
            this.lbx_Contato.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_Contato.FormattingEnabled = true;
            this.lbx_Contato.ItemHeight = 30;
            this.lbx_Contato.Location = new System.Drawing.Point(19, 50);
            this.lbx_Contato.Name = "lbx_Contato";
            this.lbx_Contato.Size = new System.Drawing.Size(427, 214);
            this.lbx_Contato.TabIndex = 1;
            // 
            // frm_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 293);
            this.Controls.Add(this.lbx_Contato);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "frm_Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frm_Agenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ListBox lbx_Contato;
    }
}

