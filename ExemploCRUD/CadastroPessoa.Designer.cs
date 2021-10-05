
namespace ExemploCRUD
{
    partial class CadastroPessoa
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
            this.label2 = new System.Windows.Forms.Label();
            this.ttb_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ttb_celular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.box_sexo = new System.Windows.Forms.ComboBox();
            this.btt_gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Pessoa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // ttb_nome
            // 
            this.ttb_nome.Location = new System.Drawing.Point(13, 70);
            this.ttb_nome.Name = "ttb_nome";
            this.ttb_nome.Size = new System.Drawing.Size(199, 23);
            this.ttb_nome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPF:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // ttb_cpf
            // 
            this.ttb_cpf.Location = new System.Drawing.Point(13, 131);
            this.ttb_cpf.Mask = "000,000,000-00";
            this.ttb_cpf.Name = "ttb_cpf";
            this.ttb_cpf.Size = new System.Drawing.Size(78, 23);
            this.ttb_cpf.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(128, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nº Celular:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // ttb_celular
            // 
            this.ttb_celular.Location = new System.Drawing.Point(134, 131);
            this.ttb_celular.Mask = "(00)00000-0000";
            this.ttb_celular.Name = "ttb_celular";
            this.ttb_celular.Size = new System.Drawing.Size(78, 23);
            this.ttb_celular.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sexo:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // box_sexo
            // 
            this.box_sexo.FormattingEnabled = true;
            this.box_sexo.Location = new System.Drawing.Point(13, 199);
            this.box_sexo.Name = "box_sexo";
            this.box_sexo.Size = new System.Drawing.Size(96, 23);
            this.box_sexo.TabIndex = 3;
            this.box_sexo.SelectedIndexChanged += new System.EventHandler(this.box_sexo_SelectedIndexChanged);
            // 
            // btt_gravar
            // 
            this.btt_gravar.BackColor = System.Drawing.Color.Coral;
            this.btt_gravar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btt_gravar.Location = new System.Drawing.Point(137, 199);
            this.btt_gravar.Name = "btt_gravar";
            this.btt_gravar.Size = new System.Drawing.Size(75, 23);
            this.btt_gravar.TabIndex = 4;
            this.btt_gravar.Text = "GRAVAR";
            this.btt_gravar.UseVisualStyleBackColor = false;
            this.btt_gravar.Click += new System.EventHandler(this.btt_gravar_Click);
            // 
            // CadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 247);
            this.Controls.Add(this.btt_gravar);
            this.Controls.Add(this.box_sexo);
            this.Controls.Add(this.ttb_celular);
            this.Controls.Add(this.ttb_cpf);
            this.Controls.Add(this.ttb_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroPessoa";
            this.Text = "Cadastro de Pessoa";
            this.Load += new System.EventHandler(this.CadastroPessoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttb_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ttb_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox ttb_celular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox box_sexo;
        private System.Windows.Forms.Button btt_gravar;
    }
}