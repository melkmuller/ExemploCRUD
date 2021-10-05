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
    public partial class RelatorioPessoa : Form
    {
        public RelatorioPessoa()
        {
            InitializeComponent();

            //Atribuir valores para o Data Grid View
            dgv_pessoa.DataSource = Dados.ListaPessoa;

        }

        private void dgv_pessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
