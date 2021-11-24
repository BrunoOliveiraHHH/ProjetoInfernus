using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfernusService;
using System.Data;

namespace Infernus
{
    public class ConsultaItem
    {
        private ConsultaService _service = new ConsultaService();


        public DataSet ConsultarItem(DataSet dtsEntrada)
        {
            DataSet dtsSaida = null;
            if (dtsEntrada != null && dtsEntrada.Tables.Count > 0)
            {
                dtsSaida = _service.ConsultaDropDown(dtsEntrada.Tables["tipo_combo"]);
            }

            return dtsSaida;
        }
    }
}
