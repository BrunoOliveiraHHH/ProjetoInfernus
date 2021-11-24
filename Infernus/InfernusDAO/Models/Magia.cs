using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfernusDAO
{
    public class Magia
    {
        private string Item;
        private string Nome;
        private string Nivel;
        private string Escola;
        private string Duracao;
        private string Alcance;
        private string TempoDeConjuracao;
        private string Componentes;
        private string Descricao;

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

        public string escola
        {
            get { return Escola; }
            set { Escola = value; }
        }

        public string duracao
        {
            get { return Duracao; }
            set { Duracao = value; }
        }

        public string alcance
        {
            get { return Alcance; }
            set { Alcance = value; }
        }

        public string tempoDeConjuracao
        {
            get { return TempoDeConjuracao; }
            set { TempoDeConjuracao = value; }
        }

        public string componentes
        {
            get { return Componentes; }
            set { Componentes = value; }
        }

        public string descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }

        public string nivel
        {
            get { return Nivel; }
            set { Nivel = value; }
        }
    }
}
