using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfernusDAO;
using System.Data;

namespace InfernusAppService
{
    public class ConsultaParametro
    {
        private static ParametroDAO _dao = new ParametroDAO();

        public string ConsultarParametro(string parametro)
        {
           return _dao.ConsultarParametro(parametro); ;
        }
    }
}
