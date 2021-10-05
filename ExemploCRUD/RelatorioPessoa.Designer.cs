
namespace ExemploCRUD
{
    partial class RelatorioPessoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_pessoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Pessoas Cadastradas";
            // 
            // dgv_pessoa
            // 
            this.dgv_pessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pessoa.Location = new System.Drawing.Point(13, 49);
            this.dgv_pessoa.Name = "dgv_pessoa";
            this.dgv_pessoa.RowTemplate.Height = 25;
            this.dgv_pessoa.Size = new System.Drawing.Size(443, 271);
            this.dgv_pessoa.TabIndex = 1;
            this.dgv_pessoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pessoa_CellContentClick);
            // 
            // RelatorioPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 330);
            this.Controls.Add(this.dgv_pessoa);
            this.Controls.Add(this.label1);
            this.Name = "RelatorioPessoa";
            this.Text = "Relatorio de Pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_pessoa;
    }
}