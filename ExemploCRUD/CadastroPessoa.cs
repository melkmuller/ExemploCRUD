using ExemploCRUD.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExemploCRUD
{
    public partial class CadastroPessoa : Form
    {
        public CadastroPessoa()
        {
            InitializeComponent();

            //Adicionando elementos ao combobox
            box_sexo.Items.Add("Selecione");
            box_sexo.Items.Add("Masculino");
            box_sexo.Items.Add("Feminino");
            box_sexo.Items.Add("Outros");

            //Setando para o ComboBox qual o texto que deve iniciar previamente visível
            box_sexo.SelectedIndex = box_sexo.FindStringExact("Selecione");

            //Bloqueando a edição de ComboBox para que o usuário não consiga digitar nada nesta caixa
            box_sexo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroPessoa_Load(object sender, EventArgs e)
        {

        }

        private void box_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btt_gravar_Click(object sender, EventArgs e)
        {
            if(ttb_nome.TextLength > 5 && !(string.IsNullOrWhiteSpace(ttb_nome.Text.ToString())))
            {
                //Verifica se o texto CPF é diferente de vazio, no caso vazio são os caracteres pré digitados
                if (ttb_cpf.Text.ToString() != "   .   .   -")
                {
                    //Verifica se o celuar é diferente de vazio
                    if (ttb_celular.Text.ToString() != "(  )     -")
                    {
                        // Sexo selecionado não pode ser igual a "SELECIONE"
                        if (box_sexo.SelectedItem.ToString() != "Selecione")
                        {
                            //Declarar um novo objeto pessoa
                            Pessoa novaPessoa = new Pessoa();

                            //Atribuindo o valor digitado para a propriedade do objeto
                            novaPessoa.Nome = ttb_nome.Text.ToString();
                            novaPessoa.Cpf = ttb_cpf.Text.ToString();
                            novaPessoa.Celular = ttb_celular.Text.ToString();
                            novaPessoa.Sexo = box_sexo.SelectedItem.ToString();

                            //Adicionar na lista para simular cadastro
                            Dados.ListaPessoa.Add(novaPessoa);

                            MessageBox.Show("Cadastro gravado", "Aviso");
                        }

                        else
                            MessageBox.Show("Selecione um sexo", "Aviso");
                    }
                    else
                        MessageBox.Show("Preencha um telefone", "Aviso");
                }
                else
                    MessageBox.Show("Preencha o CPF", "Aviso");
            }
            else
                MessageBox.Show("Preencha o nome", "Aviso");

        }
    }
}
