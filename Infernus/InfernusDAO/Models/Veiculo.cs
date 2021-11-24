using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfernusDAO
{
    public class Veiculo
    {
        private string Item;
        private string Nome;
        private string Tipo;
        private string Custo;
        private string Moeda;
        private string Velocidade;
        private string Durabilidade;

        public string item
        {
            get { return Item; }
            set { Item = value; }
        }

        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        public string tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
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

        public string velocidade
        {
            get { return Velocidade; }
            set { Velocidade = value; }
        }

        public string durabilidade
        {
            get { return Durabilidade; }
            set { Durabilidade = value; }
        }
    }
}
