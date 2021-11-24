using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfernusDAO
{
    public class Monstro
    {
        #region Variaveis

        private string Item;
        private string Nome;
        private string Tipo;
        private string Tamanho;
        private string Tendencia;
        private string HP;
        private string CA;
        private string Desloc_T;
        private string Desloc_E;
        private string Desloc_N;
        private string Desloc_V;
        private string Desloc_S;
        private string BP;
        private string STR;
        private string DEX;
        private string CON;
        private string INT;
        private string WIS;
        private string CHA;
        private string ND;
        private string Tracos;
        private string Pericias;
        private string Caracteristicas;
        private string Acoes;
        private string AcoesLendarias;

        #endregion

        #region Get's e Set's
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
        public string tamanho
        {
            get { return Tamanho; }
            set { Tamanho = value; }
        }
        public string tendencia
        {
            get { return Tendencia; }
            set { Tendencia = value; }
        }
        public string hp
        {
            get { return HP; }
            set { HP = value; }
        }
        public string ca
        {
            get { return CA; }
            set { CA = value; }
        }
        public string desloc_t
        {
            get { return Desloc_T; }
            set { Desloc_T = value; }
        }
        public string desloc_e
        {
            get { return Desloc_E; }
            set { Desloc_E = value; }
        }
        public string desloc_n
        {
            get { return Desloc_N; }
            set { Desloc_N = value; }
        }
        public string desloc_v
        {
            get { return Desloc_V; }
            set { Desloc_V = value; }
        }
        public string desloc_s
        {
            get { return Desloc_S; }
            set { Desloc_S = value; }
        }
        public string bp
        {
            get { return BP; }
            set { BP = value; }
        }
        public string str
        {
            get { return STR; }
            set { STR = value; }
        }
        public string dex
        {
            get { return DEX; }
            set { DEX = value; }
        }
        public string con
        {
            get { return CON; }
            set { CON = value; }
        }
        public string inte
        {
            get { return INT; }
            set { INT = value; }
        }
        public string wis
        {
            get { return WIS; }
            set { WIS = value; }
        }
        public string cha
        {
            get { return CHA; }
            set { CHA = value; }
        }
        public string nd
        {
            get { return ND; }
            set { ND = value; }
        }
        public string tracos
        {
            get { return Tracos; }
            set { Tracos = value; }
        }
        public string caracteristicas
        {
            get { return Caracteristicas; }
            set { Caracteristicas = value; }
        }
        public string pericias
        {
            get { return Pericias; }
            set { Pericias = value; }
        }
        public string acoes
        {
            get { return Acoes; }
            set { Acoes = value; }
        }
        public string acoesLendarias
        {
            get { return AcoesLendarias; }
            set { AcoesLendarias = value; }
        }
        #endregion
    }
}
