using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using InfernusDAO;

namespace InfernusService
{
    public class TrataMensagem
    {
        private static MensagensDAO _dao = new MensagensDAO();

        public string retornaMensagemFormatada(int codMensagem)
        {
            string mensagem = "Código de mensagem inválido";

            if (codMensagem > 99)
            {
                DataTable dt = _dao.ConsultarMensagem(codMensagem);

                if (dt.Rows.Count > 0 && dt.Columns.Contains("cod_msg") && dt.Columns.Contains("des_msg") 
                    && !String.IsNullOrEmpty(dt.Rows[0]["cod_msg"].ToString()) && !String.IsNullOrEmpty(dt.Rows[0]["des_msg"].ToString()))
                {
                    mensagem = dt.Rows[0]["cod_msg"].ToString() + " - " + dt.Rows[0]["des_msg"].ToString();
                }
            }

            return mensagem;
        }
    }
}
