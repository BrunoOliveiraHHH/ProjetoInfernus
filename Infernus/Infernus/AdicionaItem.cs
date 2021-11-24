using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfernusService;
using System.Data;

namespace Infernus
{
    public class AdicionaItem
    {
        private AdicionarService _service = new AdicionarService();


        public string AdicionarItem(DataSet dtsEntrada)
        {
            string retorno = "";
            if (dtsEntrada != null && dtsEntrada.Tables.Count > 0)
            {
                retorno = _service.AdicionaItem(dtsEntrada);
            }

            return retorno;
        }
    }
}
