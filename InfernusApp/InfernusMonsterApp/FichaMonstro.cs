using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfernusAppService;
using System.IO;
using InfernusDAO;

namespace InfernusMonsterApp
{
    public partial class FichaMonstro : Form
    {
        private static AdicionarService _service = new AdicionarService();
        private static AdicionaItemService _item = new AdicionaItemService();
        private static ConsultaParametro _consulta = new ConsultaParametro();
        private static ConsultaService _dropdown = new ConsultaService();

        public FichaMonstro()
        {
            InitializeComponent();
            InicializaDropDown();
        }

        private void InicializaDropDown()
        {
            DataSet dts = new DataSet();

            DataTable dtND = new DataTable();
            DataTable dtTipoM = new DataTable();

            DataTable dtTipo = new DataTable();
            dtTipo.TableName = "tipo_combo";
            dtTipo.Columns.Add("tipo", typeof(System.String));
            int Tipo = 5;
            int alcance = 2;

            for (int i = 0; i < alcance; i++)
            {
                DataRow linha = dtTipo.NewRow();
                linha["tipo"] = Tipo.ToString();
                dtTipo.Rows.Add(linha);
                Tipo++;
            }

            dts.Tables.Add(dtTipo);

            #region dtErro e dtInfo
            DataTable dtErro = new DataTable();
            DataTable dtInfo = new DataTable();

            dtErro.TableName = "msg_erro";
            dtInfo.TableName = "msg_info";
            dtErro.Columns.Add("des_msg", typeof(System.String));
            dtInfo.Columns.Add("des_msg", typeof(System.String));

            DataRow linhaE = dtErro.NewRow();
            DataRow linhaI = dtInfo.NewRow();

            dtInfo.Rows.Add(linhaI);
            dtErro.Rows.Add(linhaE);

            dtErro.Rows[0]["des_msg"] = "erro";
            dtInfo.Rows[0]["des_msg"] = "info";

            dts.Tables.Add(dtInfo);
            dts.Tables.Add(dtErro);

            #endregion

            string xml = _dropdown.ConsultaItem(dts);
            dts = new DataSet();
            dts.ReadXml(new StringReader(xml));

            foreach (DataTable dt in dts.Tables)
            {

                if (dt.TableName == "tb_tipo_monstro")
                {
                    dtTipoM = dt;
                }
                else if (dt.TableName == "tb_nd_monstro")
                {
                    dtND = dt;
                }
                else if (dt.TableName == "msg_info")
                {
                    lblRetorno.Text = dt.Rows[0]["msg"].ToString();
                }

            }
            //
            cbTipo.DataSource = dtTipoM;
            cbTipo.DisplayMember = "nome";
            cbTipo.ValueMember = "nome";

            //
            cbND.DataSource = dtND;
            cbND.DisplayMember = "nd";
            cbND.ValueMember = "nd";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Monstro obj = new Monstro();

            obj.item = _consulta.ConsultarParametro("ItemUnico");
            obj.acoes = txtAcoes.Text.ToString();
            obj.acoesLendarias = txtAcoesLendarias.Text.ToString();
            obj.bp = retornaValue(cbND.SelectedValue.ToString(), 1);
            obj.ca = txtCA.Text.ToString();
            obj.caracteristicas = txtCaracteristicas.Text.ToString();
            obj.cha = txtCha.Text.ToString();
            obj.con = txtCon.Text.ToString();
            obj.desloc_e = txtDesloc_e.Text.ToString();
            obj.desloc_n = txtDesloc_n.Text.ToString();
            obj.desloc_s = txtDesloc_s.Text.ToString();
            obj.desloc_t = txtDesloc_t.Text.ToString();
            obj.desloc_v = txtDesloc_v.Text.ToString();
            obj.dex = txtDex.Text.ToString();
            obj.hp = txtHP.Text.ToString();
            obj.inte = txtInt.Text.ToString();
            obj.nd = retornaValue(cbND.SelectedValue.ToString(), 2);
            obj.nome = txtNome.Text.ToString();
            obj.pericias = txtPericias.Text.ToString();
            obj.str = txtStr.Text.ToString();
            obj.tamanho = txtTamanho.Text.ToString();
            obj.tendencia = txtTendencia.Text.ToString();
            obj.tipo = cbTipo.SelectedValue.ToString();
            obj.tracos = txtTracos.Text.ToString();
            obj.wis = txtWis.Text.ToString();

            string retorno = _service.adicionaItenRPG(_item.montaDtsMonstro(obj));

            lblRetorno.Text = "Retorno: " + retorno.ToString();

        }

        private string retornaValue(string input, int dt)
        {
            DataSet dts = new DataSet();
            string retorno = "";

            DataTable dtTipo = new DataTable();
            dtTipo.TableName = "tipo_combo";
            dtTipo.Columns.Add("tipo", typeof(System.String));
            DataRow linha = dtTipo.NewRow();
            linha["tipo"] = "6";
            dtTipo.Rows.Add(linha);

            #region dtErro e dtInfo
            DataTable dtErro = new DataTable();
            DataTable dtInfo = new DataTable();

            dtErro.TableName = "msg_erro";
            dtInfo.TableName = "msg_info";
            dtErro.Columns.Add("des_msg", typeof(System.String));
            dtInfo.Columns.Add("des_msg", typeof(System.String));

            DataRow linhaE = dtErro.NewRow();
            DataRow linhaI = dtInfo.NewRow();

            dtInfo.Rows.Add(linhaI);
            dtErro.Rows.Add(linhaE);

            dtErro.Rows[0]["des_msg"] = "erro";
            dtInfo.Rows[0]["des_msg"] = "info";

            dts.Tables.Add(dtInfo);
            dts.Tables.Add(dtErro);
            dts.Tables.Add(dtTipo);

            #endregion

            string xml = _dropdown.ConsultaItem(dts);
            dts = new DataSet();
            dts.ReadXml(new StringReader(xml));

            if (dts.Tables.Contains("tb_nd_monstro"))
            {
                foreach (DataRow row in dts.Tables["tb_nd_monstro"].Rows)
                {
                    if (row["nd"].ToString() == input && dt == 1)
                    {
                        retorno = row["bp"].ToString();
                    }

                    if (row["nd"].ToString() == input && dt == 2)
                    {
                        retorno = input + " (" + row["XP"].ToString() + ")";
                    }
                }
            }

            return retorno;
        }

        #region CheckBox
        private void cbTerrestre_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTerrestre.Checked == true)
            {
                txtDesloc_t.Visible = true;
            }
            else
            {
                txtDesloc_t.Visible = false;
            }

        }

        private void cbNado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNado.Checked == true)
            {
                txtDesloc_n.Visible = true;
            }
            else
            {
                txtDesloc_n.Visible = false;
            }
        }

        private void cbVoo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVoo.Checked == true)
            {
                txtDesloc_v.Visible = true;
            }
            else
            {
                txtDesloc_v.Visible = false;
            }
        }

        private void cbSub_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSub.Checked == true)
            {
                txtDesloc_s.Visible = true;
            }
            else
            {
                txtDesloc_s.Visible = false;
            }
        }

        private void cbEscalada_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEscalada.Checked == true)
            {
                txtDesloc_e.Visible = true;
            }
            else
            {
                txtDesloc_e.Visible = false;
            }
        }
        #endregion

        private void cbMudanca(object sender, EventArgs e)
        {
            DataSet dts = new DataSet();
            string retorno = "";

            DataTable dtTipo = new DataTable();
            dtTipo.TableName = "tipo_combo";
            dtTipo.Columns.Add("tipo", typeof(System.String));
            DataRow linha = dtTipo.NewRow();
            linha["tipo"] = "6";
            dtTipo.Rows.Add(linha);

            #region dtErro e dtInfo
            DataTable dtErro = new DataTable();
            DataTable dtInfo = new DataTable();

            dtErro.TableName = "msg_erro";
            dtInfo.TableName = "msg_info";
            dtErro.Columns.Add("des_msg", typeof(System.String));
            dtInfo.Columns.Add("des_msg", typeof(System.String));

            DataRow linhaE = dtErro.NewRow();
            DataRow linhaI = dtInfo.NewRow();

            dtInfo.Rows.Add(linhaI);
            dtErro.Rows.Add(linhaE);

            dtErro.Rows[0]["des_msg"] = "erro";
            dtInfo.Rows[0]["des_msg"] = "info";

            dts.Tables.Add(dtInfo);
            dts.Tables.Add(dtErro);
            dts.Tables.Add(dtTipo);

            #endregion

            string xml = _dropdown.ConsultaItem(dts);
            dts = new DataSet();
            dts.ReadXml(new StringReader(xml));
            string input = cbND.SelectedValue.ToString();

            if (dts.Tables.Contains("tb_nd_monstro"))
            {
                foreach (DataRow row in dts.Tables["tb_nd_monstro"].Rows)
                {
                    if (row["nd"].ToString() == input)
                    {
                        retorno = row["bp"].ToString();
                    }
                }
            }

            lblBonus.Text = retorno;
        }
    }
}
