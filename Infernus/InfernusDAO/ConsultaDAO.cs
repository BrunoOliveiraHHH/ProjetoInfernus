using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace InfernusDAO
{
    public class ConsultaDAO
    {
        #region Members
        private static ParametroDAO parametro = new ParametroDAO();
        private static SqlConnection con = new SqlConnection(Convert.ToString(parametro.ConsultarParametro("sqLConString")));
        private static SqlDataReader reader = null;
        #endregion

        public DataTable consultaDropDown(int tipoDropDown)
        {
            DataTable dtSaida = null;

            int retorno = 0;

            try
            {
                con.Open();


                    #region Monta a query
                    String query = parametro.ConsultarParametro("procedureConsultaDropdown") + " @tipo";
                    SqlCommand cmd = new SqlCommand(query, con);

                    #region Parametro tipo
                    SqlParameter tipo = new SqlParameter();
                    tipo.ParameterName = "tipo";
                    tipo.Value = tipoDropDown.ToString();
                    tipo.SqlDbType = SqlDbType.Int;
                    #endregion

                    cmd.Parameters.Add(tipo);
                    #endregion

                    reader = cmd.ExecuteReader();
                    dtSaida = new DataTable();
                    dtSaida.Load(reader);

                    try
                    {

                        if (tipoDropDown == 1)
                        {
                            dtSaida.TableName = "tb_tipo_armadura";
                        }
                        else if (tipoDropDown == 2)
                        {
                            dtSaida.TableName = "tb_durabilidade";
                        }
                        else if (tipoDropDown == 3)
                        {
                            dtSaida.TableName = "tb_moeda";
                        }
                        else if (tipoDropDown == 4)
                        {
                            dtSaida.TableName = "tb_escola_magia";
                        }
                        else if (tipoDropDown == 5)
                        {
                            dtSaida.TableName = "tb_tipo_monstro";
                        }
                        else if (tipoDropDown == 6)
                        {
                            dtSaida.TableName = "tb_nd_monstro";
                        }
                    }
                    catch (Exception ex)
                    {
                        dtSaida.Columns.Add("des_msg",typeof(System.String));
                        dtSaida.TableName = "msg_erro";
                        DataRow linha = dtSaida.NewRow();
                        linha["des_msg"] = retorno.ToString() + ex.Message;
                        dtSaida.Rows.Add(linha);
                    }
                
            }
            catch (Exception ex)
            {
                dtSaida.Columns.Add("des_msg", typeof(System.String));
                dtSaida.TableName = "msg_erro";
                DataRow linha = dtSaida.NewRow();
                linha["des_msg"] = retorno.ToString() + ex.Message;
                dtSaida.Rows.Add(linha);
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

            return dtSaida;
        }

        public DataTable consultaItemArma(int idArma)
        {
            DataTable dtSaida = null;

            return dtSaida;
        }
    }
}
