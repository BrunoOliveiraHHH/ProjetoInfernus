using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace InfernusDAO
{
    public class ParametroDAO
    {
        #region Members
        private static string cs = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
        private SqlConnection con = new SqlConnection(cs);
        private SqlDataReader reader = null;
        #endregion

        #region ConsultarParametro
        public string ConsultarParametro(string nomParametro)
        {
            string parametro = "";
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String query = "EXECUTE [dbo].[consultar_parametro] @nom_parametro";

                SqlParameter parametros = new SqlParameter();
                parametros.ParameterName = "@nom_parametro";
                parametros.Value = nomParametro;
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add(parametros);

                reader = cmd.ExecuteReader();

                dt.Load(reader);

                if (dt != null && dt.Rows.Count > 0)
                {
                    parametro = dt.Rows[0]["des_parametro"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return parametro;
        }
        #endregion

        #region ConsultarListaParametros
        public List<string> ConsultarListaParametros(string nomParametro)
        {
            string parametro = "";
            List<string> stringList = new List<string>();
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String query = "EXECUTE [dbo].[consultar_parametro] @nom_parametro";
                SqlParameter parametros = new SqlParameter();
                parametros.ParameterName = "@nom_parametro";
                parametros.Value = nomParametro;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(parametros);

                reader = cmd.ExecuteReader();

                dt.Load(reader);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        parametro = row["des_parametro"].ToString();
                        stringList.Add(parametro);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return stringList;
        }
        #endregion
    }

}
