using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace InfernusDAO
{
    public class MensagensDAO
    {
        #region Members
        private static string cs = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
        private SqlConnection con = new SqlConnection(cs);
        private SqlDataReader reader = null;
        #endregion

        #region ConsultarMensagem
        public DataTable ConsultarMensagem(int codMensagem)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                
                String query = "EXECUTE [dbo].[consultar_mensagens] @cod_msg";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlParameter codMsg = new SqlParameter();
                codMsg.ParameterName = "@cod_msg";
                codMsg.Value = codMensagem;
                codMsg.SqlDbType = SqlDbType.Int;
                
                cmd.Parameters.Add(codMsg);

                reader = cmd.ExecuteReader();

                dt.Load(reader);

                return dt;
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
        }
        #endregion
    }
}
