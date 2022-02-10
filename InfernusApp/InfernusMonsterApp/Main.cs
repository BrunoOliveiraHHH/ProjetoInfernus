using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InfernusMonsterApp
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
        #endregion

        private void btnMonsterSheet_Click(object sender, EventArgs e)
        {
            FichaMonstro monsterSheet = new FichaMonstro();
            monsterSheet.Show();
        }

        private void btnNPCSheet_Click(object sender, EventArgs e)
        {

        }
    }
}
