using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfernusDAO
{
    public class Arma
    {
        private string Item;
        private string Nome;
        private string Custo; 
        private string Moeda; 
        private string Dano; 
        private string Tipo_de_dano; 
        private string Peso; 
        private string Propriedade; 
        private string Durabilidade; 
        private string Efeitos;
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

        public string dano
        {
            get { return Dano; }
            set { Dano = value; }
        }

        public string tipoDeDano
        {
            get { return Tipo_de_dano; }
            set { Tipo_de_dano = value; }
        }

        public string peso
        {
            get { return Peso; }
            set { Peso = value; }
        }

        public string propriedade
        {
            get { return Propriedade; }
            set { Propriedade = value; }
        }

        public string durabilidade
        {
            get { return Durabilidade; }
            set { Durabilidade = value; }
        }

        public string efeitos
        {
            get { return Efeitos; }
            set { Efeitos = value; }
        }

        public string observacao
        {
            get { return Observacao; }
            set { Observacao = value; }
        }

    }
}
