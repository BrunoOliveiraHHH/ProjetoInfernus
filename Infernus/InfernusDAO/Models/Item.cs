using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfernusDAO
{
    public class Item
    {
        private string Itemn;
        private string Nome;
        private string Custo;
        private string Moeda;
        private string Peso;
        private string Durabilidade;
        private string Descricao;

        public string item
        {
            get { return Itemn; }
            set { Itemn = value; }
        }

        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        public string custo
        {
            get { return Custo; }
            set { Custo = value; }
        }

        public string moeda
        {
            get { return Moeda; }
            set { Moeda = value; }
        }

        public string peso
        {
            get { return Peso; }
            set { Peso = value; }
        }

        public string durabilidade
        {
            get { return Durabilidade; }
            set { Durabilidade = value; }
        }

        public string descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }
    }
}
