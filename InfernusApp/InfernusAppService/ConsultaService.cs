using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infernus;
using System.Data;

namespace InfernusAppService
{
    public class ConsultaService
    {
        public String ConsultaItem(DataSet obj)
        {
            Mensagens _msg = new Mensagens();
            ConsultaItem _service = new ConsultaItem();
            DataSet retorno = null;

            if (obj != null)
            {
                retorno = _service.ConsultarItem(obj);
            }
            else
            {
                obj = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "msg_info";
                dt.Columns.Add("msg");
                DataRow linha = dt.NewRow();
                linha["msg"] = _msg.ConsultaMensagem(999);
                dt.Rows.Add(linha);
                retorno.Tables.Add(dt);
            }

            return retorno.GetXml();
        }
    }
}
