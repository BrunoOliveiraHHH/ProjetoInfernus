using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InfernusApp
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        #region Butões do Menu Principal
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArma_Click(object sender, EventArgs e)
        {
            Armas janelaArma = new Armas();
            janelaArma.Show();
        }   

        private void btnArmadura_Click(object sender, EventArgs e)
        {
            Armaduras armaduras = new Armaduras();
            armaduras.Show();
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            Itens itens = new Itens();
            itens.Show();
        }

        private void btnMagias_Click(object sender, EventArgs e)
        {
            Magias magias = new Magias();
            magias.Show();
        }

        private void btnMonstros_Click(object sender, EventArgs e)
        {
            Monstros monstros = new Monstros();
            monstros.Show();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            Veiculos veiculos = new Veiculos();
            veiculos.Show();
        }
        #endregion
    }
}
