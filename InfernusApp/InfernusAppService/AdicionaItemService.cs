using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfernusDAO;
using System.Data;

namespace InfernusAppService
{
    public class AdicionaItemService
    {
        #region Arma
        public DataSet montaDtsArma(Arma obj)
        {
            DataSet dtsSaida = new DataSet();

            dtsSaida.Tables.Add(montaDtArma(obj));

            return dtsSaida;
        }

        private DataTable montaDtArma(Arma obj)
        {
            DataTable dt = new DataTable();
            dt.TableName = "arma";

            #region Colunas
            dt.Columns.Add("item", typeof(System.String));
            dt.Columns.Add("nome", typeof(System.String));
            dt.Columns.Add("custo", typeof(System.String));
            dt.Columns.Add("moeda", typeof(System.String));
            dt.Columns.Add("dano", typeof(System.String));
            dt.Columns.Add("tipo_de_dano", typeof(System.String));
            dt.Columns.Add("peso", typeof(System.String));
            dt.Columns.Add("propriedade", typeof(System.String));
            dt.Columns.Add("durabilidade", typeof(System.String));
            dt.Columns.Add("efeitos", typeof(System.String));
            dt.Columns.Add("observacao", typeof(System.String));
            #endregion

            #region Linha
            if (obj != null)
            {
                DataRow linha = dt.NewRow();
                if (!String.IsNullOrEmpty(obj.item))
                {
                    linha["item"] = obj.item;
                }
                else
                {
                    linha["item"] = "1";
                }
                linha["nome"] = obj.nome;
                linha["custo"] = obj.custo;
                linha["moeda"] = obj.moeda;
                linha["dano"] = obj.dano;
                linha["tipo_de_dano"] = obj.tipoDeDano;
                linha["peso"] = obj.peso;
                linha["propriedade"] = obj.propriedade;
                linha["durabilidade"] = obj.durabilidade;
                linha["efeitos"] = obj.efeitos;
                linha["observacao"] = obj.observacao;

                dt.Rows.Add(linha);
            }
            #endregion

            return dt;
        }
        #endregion

        #region Armadura
        public DataSet montaDtsArmadura(Armadura obj)
        {
            DataSet dtsSaida = new DataSet();

            dtsSaida.Tables.Add(montaDtArmadura(obj));

            return dtsSaida;
        }

        private DataTable montaDtArmadura(Armadura obj)
        {
            DataTable dt = new DataTable();
            dt.TableName = "armadura";

            #region Colunas
            dt.Columns.Add("item", typeof(System.String));
            dt.Columns.Add("nome", typeof(System.String));
            dt.Columns.Add("tipo_armadura", typeof(System.String));
            dt.Columns.Add("custo", typeof(System.String));
            dt.Columns.Add("moeda", typeof(System.String));
            dt.Columns.Add("ca", typeof(System.String));
            dt.Columns.Add("furtv", typeof(System.String));
            dt.Columns.Add("forca", typeof(System.String));
            dt.Columns.Add("peso", typeof(System.String));
            dt.Columns.Add("durabilidade", typeof(System.String));
            dt.Columns.Add("observacao", typeof(System.String));
            #endregion

            #region Linha
            if (obj != null)
            {
                DataRow linha = dt.NewRow();
                if (!String.IsNullOrEmpty(obj.item))
                {
                    linha["item"] = obj.item;
                }
                else
                {
                    linha["item"] = "1";
                }
                linha["nome"] = obj.nome;
                linha["tipo_armadura"] = obj.tipoArmadura;
                linha["custo"] = obj.custo;
                linha["moeda"] = obj.moeda;
                linha["ca"] = obj.ca;
                linha["furtv"] = obj.furtv;
                linha["forca"] = obj.forca;
                linha["peso"] = obj.peso;                
                linha["durabilidade"] = obj.durabilidade;                
                linha["observacao"] = obj.observacao;

                dt.Rows.Add(linha);
            }
            #endregion

            return dt;
        }
        #endregion

        #region Item
        public DataSet montaDtsItem(Item obj)
        {
            DataSet dtsSaida = new DataSet();

            dtsSaida.Tables.Add(montaDtItem(obj));

            return dtsSaida;
        }

        private DataTable montaDtItem(Item obj)
        {
            DataTable dt = new DataTable();
            dt.TableName = "item";

            #region Colunas
            dt.Columns.Add("item", typeof(System.String));
            dt.Columns.Add("nome", typeof(System.String));
            dt.Columns.Add("custo", typeof(System.String));
            dt.Columns.Add("moeda", typeof(System.String));
            dt.Columns.Add("peso", typeof(System.String));
            dt.Columns.Add("durabilidade", typeof(System.String));
            dt.Columns.Add("descricao", typeof(System.String));
            #endregion

            #region Linha
            if (obj != null)
            {
                DataRow linha = dt.NewRow();
                if (!String.IsNullOrEmpty(obj.item))
                {
                    linha["item"] = obj.item;
                }
                else
                {
                    linha["item"] = "1";
                }
                linha["nome"] = obj.nome;
                linha["custo"] = obj.custo;
                linha["moeda"] = obj.moeda;
                linha["peso"] = obj.peso;
                linha["durabilidade"] = obj.durabilidade;
                linha["descricao"] = obj.descricao;

                dt.Rows.Add(linha);
            }
            #endregion

            return dt;
        }
        #endregion

        #region Magia
        public DataSet montaDtsMagia(Magia obj)
        {
            DataSet dtsSaida = new DataSet();

            dtsSaida.Tables.Add(montaDtMagia(obj));

            return dtsSaida;
        }

        private DataTable montaDtMagia(Magia obj)
        {
            DataTable dt = new DataTable();
            dt.TableName = "magia";

            #region Colunas
            dt.Columns.Add("item", typeof(System.String));
            dt.Columns.Add("nome", typeof(System.String));
            dt.Columns.Add("nivel", typeof(System.String));
            dt.Columns.Add("escola", typeof(System.String));
            dt.Columns.Add("alcance", typeof(System.String));
            dt.Columns.Add("duracao", typeof(System.String));
            dt.Columns.Add("tempo_de_conjuracao", typeof(System.String));
            dt.Columns.Add("componentes", typeof(System.String));
            dt.Columns.Add("descricao", typeof(System.String));
            #endregion
                     
            #region Linha
            if (obj != null)
            {
                DataRow linha = dt.NewRow();
                if (!String.IsNullOrEmpty(obj.item))
                {
                    linha["item"] = obj.item;
                }
                else
                {
                    linha["item"] = "1";
                }
                linha["nome"] = obj.nome;
                linha["nivel"] = obj.nivel;
                linha["escola"] = obj.escola;
                linha["duracao"] =obj.duracao;
                linha["alcance"] = obj.alcance;
                linha["tempo_de_conjuracao"] = obj.tempoDeConjuracao;
                linha["componentes"] = obj.componentes;
                linha["descricao"] = obj.descricao;

                dt.Rows.Add(linha);
            }
            #endregion

            return dt;
        }
        #endregion

        #region Monstro
        public DataSet montaDtsMonstro(Monstro obj)
        {
            DataSet dtsSaida = new DataSet();

            dtsSaida.Tables.Add(montaDtMonstro(obj));

            return dtsSaida;
        }

        private DataTable montaDtMonstro(Monstro obj)
        {
            DataTable dt = new DataTable();
            dt.TableName = "monstro";

            #region Colunas
            dt.Columns.Add("item", typeof(System.String));
            dt.Columns.Add("nome", typeof(System.String));
            dt.Columns.Add("tipo", typeof(System.String));
            dt.Columns.Add("tamanho", typeof(System.String));
            dt.Columns.Add("tendencia", typeof(System.String));
            dt.Columns.Add("hp", typeof(System.String));
            dt.Columns.Add("ca", typeof(System.String));
            dt.Columns.Add("desloc_t", typeof(System.String));
            dt.Columns.Add("desloc_e", typeof(System.String));
            dt.Columns.Add("desloc_n", typeof(System.String));
            dt.Columns.Add("desloc_v", typeof(System.String));
            dt.Columns.Add("desloc_s", typeof(System.String));
            dt.Columns.Add("bp", typeof(System.String));
            dt.Columns.Add("str", typeof(System.String));
            dt.Columns.Add("dex", typeof(System.String));
            dt.Columns.Add("con", typeof(System.String));
            dt.Columns.Add("inte", typeof(System.String));
            dt.Columns.Add("wis", typeof(System.String));
            dt.Columns.Add("cha", typeof(System.String));
            dt.Columns.Add("nd", typeof(System.String));
            dt.Columns.Add("tracos", typeof(System.String));
            dt.Columns.Add("pericias", typeof(System.String));
            dt.Columns.Add("caracteristicas", typeof(System.String));
            dt.Columns.Add("acoes", typeof(System.String));
            dt.Columns.Add("acoeslendarias", typeof(System.String));
            #endregion

            #region Linha
            if (obj != null)
            {
                DataRow linha = dt.NewRow();
                if (!String.IsNullOrEmpty(obj.item))
                {
                    linha["item"] = obj.item;
                }
                else
                {
                    linha["item"] = "1";
                }
                linha["nome"] = obj.nome;
                linha["tipo"] = obj.tipo;
                linha["tamanho"] = obj.tamanho;
                linha["tendencia"] = obj.tendencia;
                linha["hp"] = obj.hp;
                linha["ca"] = obj.ca;
                linha["desloc_t"] = obj.desloc_t;
                linha["desloc_e"] = obj.desloc_e;
                linha["desloc_n"] = obj.desloc_n;
                linha["desloc_v"] = obj.desloc_v;
                linha["desloc_s"] = obj.desloc_s;
                linha["bp"] = obj.bp;
                linha["str"] = obj.str;
                linha["dex"] = obj.dex;
                linha["con"] = obj.con;
                linha["inte"] = obj.inte;
                linha["wis"] = obj.wis;
                linha["cha"] = obj.cha;
                linha["nd"] = obj.nd;
                linha["tracos"] = obj.tracos;
                linha["pericias"] = obj.pericias;
                linha["caracteristicas"] = obj.caracteristicas;
                linha["acoes="] = obj.acoes;
                linha["acoeslendarias"] = obj.acoesLendarias;

                dt.Rows.Add(linha);
            }
            #endregion

            return dt;
        }
        #endregion
    }
}
