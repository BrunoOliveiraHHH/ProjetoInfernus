using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfernusAppService;
using InfernusDAO;
using System.IO;

namespace InfernusApp
{
    public partial class Armas : Form
    {
        private static AdicionarService _service = new AdicionarService();
        private static AdicionaItemService _item = new AdicionaItemService();
        private static ConsultaParametro _consulta = new ConsultaParametro();
        private static ConsultaService _dropdown = new ConsultaService();

        public Armas()
        {
            InitializeComponent();
            InicializaDropDown();
        }

        private void InicializaDropDown()
        {
            DataSet dts = new DataSet();

            DataTable dtMoeda = new DataTable();
            DataTable dtDurabilidade = new DataTable();

            DataTable dtTipo = new DataTable();
            dtTipo.TableName = "tipo_combo";
            dtTipo.Columns.Add("tipo", typeof(System.String));
            int Tipo = 2;
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

                if (dt.TableName == "tb_moeda")
                {
                    dtMoeda = dt;
                }
                else if (dt.TableName == "tb_durabilidade")
                {
                    dtDurabilidade = dt;
                }
                else if (dt.TableName == "msg_info")
                {
                    lblRetorno.Text = dt.Rows[0]["msg"].ToString();
                }

            }
            //
            cbxDurabilidade.DataSource = dtDurabilidade;
            cbxDurabilidade.DisplayMember = "descricao";
            cbxDurabilidade.ValueMember = "id_durabilidade";

            //
            cbxMoeda.DataSource = dtMoeda;
            cbxMoeda.DisplayMember = "nome";
            cbxMoeda.ValueMember = "id_moeda";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Arma obj = new Arma();

            obj.item = _consulta.ConsultarParametro("ItemUnico");
            obj.nome = txtNome.Text.ToString();
            obj.custo = txtCusto.Text.ToString();
            obj.moeda = cbxMoeda.SelectedValue.ToString();
            obj.dano = txtDano.Text.ToString();
            obj.tipoDeDano = txtTipoDano.Text.ToString();
            obj.peso = txtPeso.Text.ToString();
            obj.propriedade = txtPropriedades.Text.ToString();
            obj.durabilidade = cbxDurabilidade.SelectedValue.ToString();
            obj.efeitos = txtEfeitos.Text.ToString();
            obj.observacao = txtObservacoes.Text.ToString();

            string retorno = _service.adicionaItenRPG(_item.montaDtsArma(obj));

            lblRetorno.Text = "Retorno: " + retorno;

            obj = null;
        }
    }
}
