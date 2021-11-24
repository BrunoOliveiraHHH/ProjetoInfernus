using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Infernus;

namespace InfernusAppService
{
    public class AdicionarService
    {

        public string adicionaItenRPG(DataSet obj)
        {
            Mensagens _msg = new Mensagens();
            AdicionaItem _service = new AdicionaItem();
            string retorno = "";

            if (obj != null)
            {
                retorno = _service.AdicionarItem(obj);
            }
            else
            {
                retorno = _msg.ConsultaMensagem(999);
            }

            return retorno;
        }
    }
}
