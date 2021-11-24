using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.IO;
using Infernus;
using System.ComponentModel;

namespace InfernusWS
{
    /// <summary>
    /// Summary description for InfernusWS
    /// </summary>
    [WebService(Namespace = "InfernusWS")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class InfernusWS : System.Web.Services.WebService
    {

        #region Component Designer generated code

        //Required by the Web Services Designer 
        private IContainer components = null;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        [WebMethod]
        public string InserirItem(string xml)
        {
            DataSet dts = new DataSet();
            dts.Clear();
            AdicionaItem _service = new AdicionaItem();
            string retorno = "";

            try
            {
                dts.ReadXml(new StringReader(xml));

                if (dts.Tables.Count > 0)
                {
                    retorno = _service.AdicionarItem(dts);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
            }

            return retorno;

        }

        [WebMethod]
        public string ConsultarItem(string xml)
        {
            DataSet dts = new DataSet();
            dts.Clear();
            ConsultaItem _service = new ConsultaItem();
            DataSet retorno = null;

            try
            {
                dts.ReadXml(new StringReader(xml));

                if (dts.Tables.Count > 0)
                {
                    retorno = _service.ConsultarItem(dts);
                }
            }
            catch (Exception ex)
            {
                DataTable dtSaida = new DataTable();
                dtSaida.Columns.Add("des_msg", typeof(System.String));
                dtSaida.TableName = "msg_erro";
                DataRow linha = dtSaida.NewRow();
                linha["des_msg"] = "0" + ex.Message.ToString();
                dtSaida.Rows.Add(linha);
                retorno.Tables.Add(dtSaida);
            }

            return retorno.GetXml();

        }

        [WebMethod]
        public static string ConsultarMensagem(int codMensagem)
        {
            Mensagens _service = new Mensagens();
            string retorno = "";

            DataSet dtsSaida = new DataSet();
            DataTable dtSaida = new DataTable();
            dtSaida.Columns.Add("des_msg", typeof(System.String));
            dtSaida.TableName = "mensagem";
            DataRow linha = dtSaida.NewRow();

            try
            {

                if (codMensagem > 99)
                {
                    retorno = _service.ConsultaMensagem(codMensagem);
                    linha["des_msg"] = retorno;
                    dtSaida.Rows.Add(linha);
                    dtsSaida.Tables.Add(dtSaida);

                }
            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                linha["des_msg"] = retorno;
                dtSaida.Rows.Add(linha);
                dtsSaida.Tables.Add(dtSaida);
            }

            return dtsSaida.GetXml();
        }
    }
}
