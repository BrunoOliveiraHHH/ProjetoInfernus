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
    public partial class Magias : Form
    {

        private static AdicionarService _service = new AdicionarService();
        private static AdicionaItemService _item = new AdicionaItemService();
        private static ConsultaParametro _consulta = new ConsultaParametro();
        private static ConsultaService _dropdown = new ConsultaService();

        public Magias()
        {
            InitializeComponent();
            InicializaDropDown();
        }

        private void InicializaDropDown()
        {
            DataSet dts = new DataSet();

            DataTable dtEscola = new DataTable();

            DataTable dtTipo = new DataTable();
            dtTipo.TableName = "tipo_combo";
            dtTipo.Columns.Add("tipo", typeof(System.String));
            int Tipo = 4;

            DataRow linha = dtTipo.NewRow();
            linha["tipo"] = Tipo.ToString();
            dtTipo.Rows.Add(linha);

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

                if (dt.TableName == "tb_escola_magia")
                {
                    dtEscola = dt;
                }
                else if (dt.TableName == "msg_info")
                {
                    lblRetorno.Text = dt.Rows[0]["msg"].ToString();
                }

            }
            //
            cbxEscola.DataSource = dtEscola;
            cbxEscola.DisplayMember = "nome";
            cbxEscola.ValueMember = "id_escola";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Magia obj = new Magia();

            obj.item = _consulta.ConsultarParametro("ItemUnico");
            obj.nome = txtNome.Text.ToString();
            obj.nivel = txtNivel.Text.ToString();
            obj.escola = cbxEscola.SelectedValue.ToString();
            obj.duracao = txtDuracao.Text.ToString();
            obj.descricao = txtDescricao.Text.ToString();
            obj.componentes = txtComponentes.Text.ToString();
            obj.alcance = txtAlcance.Text.ToString();
            obj.tempoDeConjuracao = txtTempConj.Text.ToString();

            string retorno = _service.adicionaItenRPG(_item.montaDtsMagia(obj));

            lblRetorno.Text = "Retorno: " + retorno;

            obj = null;
        }
    }
}
