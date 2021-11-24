using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfernusDAO
{
    public class Armadura
    {
        private string Item;
        private string Nome;
        private string Tipo_armadura;
        private string Custo;
        private string Moeda;
        private string Ca;
        private string Furtv;
        private string Forca;
        private string Peso;
        private string Durabilidade;
        private string Observacao;

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

        public string tipoArmadura
        {
            get { return Tipo_armadura; }
            set { Tipo_armadura = value; }
        }

        public string ca
        {
            get { return Ca; }
            set { Ca = value; }
        }

        public string peso
        {
            get { return Peso; }
            set { Peso = value; }
        }

        public string forca
        {
            get { return Forca; }
            set { Forca = value; }
        }

        public string durabilidade
        {
            get { return Durabilidade; }
            set { Durabilidade = value; }
        }

        public string furtv
        {
            get { return Furtv; }
            set { Furtv = value; }
        }

        public string observacao
        {
            get { return Observacao; }
            set { Observacao = value; }
        }
    }
}
