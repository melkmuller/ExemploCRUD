using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploCRUD.Entidades
{
    static class Dados
    {
        private static List<Pessoa> listaPessoa = new List<Pessoa>();

        public static List<Pessoa> ListaPessoa
        {
            get { return listaPessoa; }
            set { listaPessoa = value; }
        }
    }
}
