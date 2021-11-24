using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfernusDAO;
using System.Data;

namespace InfernusService
{
    public class ConsultaService
    {
        private static ConsultaDAO _dao = new ConsultaDAO();
        private static TrataMensagem _mensagem = new TrataMensagem();

        public DataSet ConsultaDropDown(DataTable dtEntrada)
        {
            DataSet dtsSaida = new DataSet();
            try
            {
                if (dtEntrada == null || dtEntrada.Rows.Count == 0)
                {
                    dtEntrada = new DataTable();
                    dtEntrada.Columns.Add("des_msg", typeof(System.String));
                    dtEntrada.TableName = "msg_erro";
                    DataRow linha = dtEntrada.NewRow();
                    linha["des_msg"] = "0" + _mensagem.retornaMensagemFormatada(999);
                    dtEntrada.Rows.Add(linha);
                    dtsSaida.Tables.Add(dtEntrada);
                }
                else
                {
                    foreach (DataRow linha in dtEntrada.Rows)
                    {
                        DataTable dtSaida = _dao.consultaDropDown(Convert.ToInt32(linha["tipo"].ToString()));
                        if (!dtsSaida.Tables.Contains("tb_tipo_armadura") || !dtsSaida.Tables.Contains("tb_durabilidade")
                            || !dtsSaida.Tables.Contains("tb_moeda") || !dtsSaida.Tables.Contains("tb_escola_magia")
                            || !dtsSaida.Tables.Contains("tb_tipo_monstro") || !dtsSaida.Tables.Contains("tb_nd_monstro"))
                        {
                            dtsSaida.Tables.Add(dtSaida);
                        }
                    }
                }

                return dtsSaida;
            }
            catch (Exception ex)
            {
                dtEntrada = new DataTable();
                dtEntrada.Columns.Add("des_msg", typeof(System.String));
                dtEntrada.TableName = "msg_erro";
                DataRow linha = dtEntrada.NewRow();
                linha["des_msg"] = "0" + ex.Message.ToString();
                dtEntrada.Rows.Add(linha);
                dtsSaida.Tables.Add(dtEntrada);
                return dtsSaida;
            }
        }
    }
}
