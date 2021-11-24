using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace InfernusDAO
{
    public class AdicionaDAO
    {
        #region Members
        private static ParametroDAO parametro = new ParametroDAO();
        private static SqlConnection con = new SqlConnection(Convert.ToString(parametro.ConsultarParametro("sqLConString")));
        private static SqlDataReader reader = null;        
        #endregion

        #region AdicionaArma
        public string AdicionaArma(Arma obj)
        {
            DataTable dt = new DataTable();
            int retorno = 0;
            string msg = "";

            try
            {
                con.Open();

                    #region Monta a query
                    String query = parametro.ConsultarParametro("procedureAdicionarArma") + " @nome, @custo, @moeda, @dano, @tipo_de_dano, @peso, @propriedade, @durabilidade, @efeitos, @observacao";
                    SqlCommand cmd = new SqlCommand(query, con);

                    #region Parametro nome
                    SqlParameter nome = new SqlParameter();
                    nome.ParameterName = "nome";
                    nome.Value = obj.nome;
                    #endregion

                    #region Parametro custo
                    SqlParameter custo = new SqlParameter();
                    custo.ParameterName = "custo";
                    custo.Value = obj.custo;
                    custo.SqlDbType = SqlDbType.Int;
                    #endregion

                    #region Parametro moeda
                    SqlParameter moeda = new SqlParameter();
                    moeda.ParameterName = "moeda";
                    moeda.Value = obj.moeda;
                    moeda.SqlDbType = SqlDbType.Int;
                    #endregion

                    #region Parametro dano
                    SqlParameter dano = new SqlParameter();
                    dano.ParameterName = "dano";
                    dano.Value = obj.dano;
                    #endregion

                    #region Parametro tipo_de_dano
                    SqlParameter tipoDano = new SqlParameter();
                    tipoDano.ParameterName = "tipo_de_dano";
                    tipoDano.Value = obj.tipoDeDano;
                    #endregion

                    #region Parametro peso
                    SqlParameter peso = new SqlParameter();
                    peso.ParameterName = "peso";
                    peso.Value = obj.peso;
                    #endregion

                    #region Parametro propriedade
                    SqlParameter propriedade = new SqlParameter();
                    propriedade.ParameterName = "propriedade";
                    propriedade.Value = obj.propriedade;
                    #endregion

                    #region Parametro durabilidade
                    SqlParameter durabilidade = new SqlParameter();
                    durabilidade.ParameterName = "durabilidade";
                    durabilidade.Value = obj.durabilidade;
                    durabilidade.SqlDbType = SqlDbType.Int;
                    #endregion

                    #region Parametro efeitos
                    SqlParameter efeitos = new SqlParameter();
                    efeitos.ParameterName = "efeitos";
                    efeitos.Value = obj.efeitos;
                    #endregion

                    #region Parametro observacao
                    SqlParameter observacao = new SqlParameter();
                    observacao.ParameterName = "observacao";
                    observacao.Value = obj.observacao;
                    #endregion

                    cmd.Parameters.Add(nome);
                    cmd.Parameters.Add(custo);
                    cmd.Parameters.Add(moeda);
                    cmd.Parameters.Add(dano);
                    cmd.Parameters.Add(tipoDano);
                    cmd.Parameters.Add(peso);
                    cmd.Parameters.Add(propriedade);
                    cmd.Parameters.Add(durabilidade);
                    cmd.Parameters.Add(efeitos);
                    cmd.Parameters.Add(observacao);

                    #endregion

                    reader = cmd.ExecuteReader();
                    dt.Load(reader);

                    try
                    {
                        retorno = int.Parse(dt.Rows[0]["Return"].ToString());
                        
                        if (retorno > 0)
                        {
                            msg = retorno.ToString() + " - Incluido Com Sucesso";
                        }
                        else
                        {
                            msg = retorno.ToString() + " - Erro ao incluir, favor validar na base de dados";
                        }
                    }
                    catch (Exception ex)
                    {
                        retorno = 0;
                        msg = retorno.ToString() + " - " + ex.Message;
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

            return msg;

        }
        #endregion

        #region AdicionaArmadura
        public string AdicionaArmadura(Armadura obj)
        {
            DataTable dt = new DataTable();
            int retorno = 0;
            string msg = "";

            try
            {
                con.Open();

                #region Monta a query
                String query = parametro.ConsultarParametro("procedureAdicionarArmadura") + " @nome, @tipo, @custo, @moeda, @ca, @furtv, @forca, @peso, @durabilidade, @observacao";
                SqlCommand cmd = new SqlCommand(query, con);

                #region Parametro nome
                SqlParameter nome = new SqlParameter();
                nome.ParameterName = "nome";
                nome.Value = obj.nome;
                #endregion

                #region Parametro tipo
                SqlParameter tipo = new SqlParameter();
                tipo.ParameterName = "tipo";
                tipo.Value = obj.tipoArmadura;
                tipo.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro custo
                SqlParameter custo = new SqlParameter();
                custo.ParameterName = "custo";
                custo.Value = obj.custo;
                custo.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro moeda
                SqlParameter moeda = new SqlParameter();
                moeda.ParameterName = "moeda";
                moeda.Value = obj.moeda;
                moeda.SqlDbType = SqlDbType.Int;
                #endregion                

                #region Parametro ca
                SqlParameter ca = new SqlParameter();
                ca.ParameterName = "ca";
                ca.Value = obj.ca;
                #endregion

                #region Parametro furtv
                SqlParameter furtv = new SqlParameter();
                furtv.ParameterName = "furtv";
                furtv.Value = obj.furtv;
                #endregion

                #region Parametro forca
                SqlParameter forca = new SqlParameter();
                forca.ParameterName = "forca";
                forca.Value = obj.forca;
                #endregion

                #region Parametro peso
                SqlParameter peso = new SqlParameter();
                peso.ParameterName = "peso";
                peso.Value = obj.peso;
                #endregion                

                #region Parametro durabilidade
                SqlParameter durabilidade = new SqlParameter();
                durabilidade.ParameterName = "durabilidade";
                durabilidade.Value = obj.durabilidade;
                durabilidade.SqlDbType = SqlDbType.Int;
                #endregion             

                #region Parametro observacao
                SqlParameter observacao = new SqlParameter();
                observacao.ParameterName = "observacao";
                observacao.Value = obj.observacao;
                #endregion

                cmd.Parameters.Add(nome);
                cmd.Parameters.Add(tipo);
                cmd.Parameters.Add(custo);
                cmd.Parameters.Add(moeda);                
                cmd.Parameters.Add(ca);
                cmd.Parameters.Add(peso);
                cmd.Parameters.Add(furtv);
                cmd.Parameters.Add(forca);
                cmd.Parameters.Add(durabilidade);                
                cmd.Parameters.Add(observacao);

                #endregion

                reader = cmd.ExecuteReader();
                dt.Load(reader);

                try
                {
                    retorno = int.Parse(dt.Rows[0]["Return"].ToString());

                    if (retorno > 0)
                    {
                        msg = retorno.ToString() + " - Incluido Com Sucesso";
                    }
                    else
                    {
                        msg = retorno.ToString() + " - Erro ao incluir, favor validar na base de dados";
                    }
                }
                catch (Exception ex)
                {
                    retorno = 0;
                    msg = retorno.ToString() + " - " + ex.Message;
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

            return msg;

        }
        #endregion

        #region AdicionaItem
        public string AdicionaItem(Item obj)
        {
            DataTable dt = new DataTable();
            int retorno = 0;
            string msg = "";

            try
            {
                con.Open();

                #region Monta a query
                String query = parametro.ConsultarParametro("procedureAdicionarItem") + " @nome ,@custo ,@moeda ,@peso ,@durabilidade ,@descricao";
                SqlCommand cmd = new SqlCommand(query, con);

                #region Parametro nome
                SqlParameter nome = new SqlParameter();
                nome.ParameterName = "nome";
                nome.Value = obj.nome;
                #endregion

                #region Parametro custo
                SqlParameter custo = new SqlParameter();
                custo.ParameterName = "custo";
                custo.Value = obj.custo;
                custo.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro moeda
                SqlParameter moeda = new SqlParameter();
                moeda.ParameterName = "moeda";
                moeda.Value = obj.moeda;
                moeda.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro peso
                SqlParameter peso = new SqlParameter();
                peso.ParameterName = "peso";
                peso.Value = obj.peso;
                #endregion

                #region Parametro durabilidade
                SqlParameter durabilidade = new SqlParameter();
                durabilidade.ParameterName = "durabilidade";
                durabilidade.Value = obj.durabilidade;
                durabilidade.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro descricao
                SqlParameter descricao = new SqlParameter();
                descricao.ParameterName = "descricao";
                descricao.Value = obj.descricao;
                descricao.SqlDbType = SqlDbType.Text;
                #endregion

                cmd.Parameters.Add(nome);
                cmd.Parameters.Add(custo);
                cmd.Parameters.Add(moeda);
                cmd.Parameters.Add(peso);
                cmd.Parameters.Add(durabilidade);
                cmd.Parameters.Add(descricao);

                #endregion

                reader = cmd.ExecuteReader();
                dt.Load(reader);

                try
                {
                    retorno = int.Parse(dt.Rows[0]["Return"].ToString());

                    if (retorno > 0)
                    {
                        msg = retorno.ToString() + " - Incluido Com Sucesso";
                    }
                    else
                    {
                        msg = retorno.ToString() + " - Erro ao incluir, favor validar na base de dados";
                    }
                }
                catch (Exception ex)
                {
                    retorno = 0;
                    msg = retorno.ToString() + " - " + ex.Message;
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

            return msg;

        }
        #endregion

        #region AdicionaMagia
        public string AdicionaMagia(Magia obj)
        {
            DataTable dt = new DataTable();
            int retorno = 0;
            string msg = "";

            try
            {
                con.Open();

                #region Monta a query
                String query = parametro.ConsultarParametro("procedureAdicionarMagia") + " @nome ,@nivel ,@escola ,@duracao ,@alcance ,@tempodeconjuracao ,@componentes ,@descricao";
                SqlCommand cmd = new SqlCommand(query, con);

                #region Parametro nome
                SqlParameter nome = new SqlParameter();
                nome.ParameterName = "nome";
                nome.Value = obj.nome;
                #endregion

                #region Parametro nivel
                SqlParameter nivel = new SqlParameter();
                nivel.ParameterName = "nivel";
                nivel.Value = obj.nivel;
                nivel.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro escola
                SqlParameter escola = new SqlParameter();
                escola.ParameterName = "escola";
                escola.Value = obj.escola;
                escola.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro duracao
                SqlParameter duracao = new SqlParameter();
                duracao.ParameterName = "duracao";
                duracao.Value = obj.duracao;
                #endregion

                #region Parametro alcance
                SqlParameter alcance = new SqlParameter();
                alcance.ParameterName = "alcance";
                alcance.Value = obj.alcance;
                #endregion

                #region Parametro tempodeconjuracao
                SqlParameter tempodeconjuracao = new SqlParameter();
                tempodeconjuracao.ParameterName = "tempodeconjuracao";
                tempodeconjuracao.Value = obj.tempoDeConjuracao;
                #endregion

                #region Parametro componentes
                SqlParameter componentes = new SqlParameter();
                componentes.ParameterName = "componentes";
                componentes.Value = obj.componentes;
                componentes.SqlDbType = SqlDbType.Text;
                #endregion

                #region Parametro descricao
                SqlParameter descricao = new SqlParameter();
                descricao.ParameterName = "descricao";
                descricao.Value = obj.descricao;
                descricao.SqlDbType = SqlDbType.Text;
                #endregion

                cmd.Parameters.Add(nome);
                cmd.Parameters.Add(nivel);
                cmd.Parameters.Add(escola);
                cmd.Parameters.Add(duracao);
                cmd.Parameters.Add(alcance);
                cmd.Parameters.Add(tempodeconjuracao);
                cmd.Parameters.Add(componentes);
                cmd.Parameters.Add(descricao);

                #endregion

                reader = cmd.ExecuteReader();
                dt.Load(reader);

                try
                {
                    retorno = int.Parse(dt.Rows[0]["Return"].ToString());

                    if (retorno > 0)
                    {
                        msg = retorno.ToString() + " - Incluido Com Sucesso";
                    }
                    else
                    {
                        msg = retorno.ToString() + " - Erro ao incluir, favor validar na base de dados";
                    }
                }
                catch (Exception ex)
                {
                    retorno = 0;
                    msg = retorno.ToString() + " - " + ex.Message;
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

            return msg;

        }
        #endregion

        #region AdicionaMonstro
        public string AdicionaMonstro(Monstro obj)
        {
            DataTable dt = new DataTable();
            int retorno = 0;
            string msg = "";

            try
            {
                con.Open();

                #region Monta a query
                String query = parametro.ConsultarParametro("procedureAdicionarMagia") + " @nome, @tipo, @tamanho, @tendencia, @hp, @ca, @desloc_t, @desloc_e, @desloc_n, @desloc_v, @desloc_s, @bp, @stre, @dex, @con, @inte, @wis, @cha, @nd, @tracos, @pericias, @caracteristicas, @acoes, @acoeslendarias";
                SqlCommand cmd = new SqlCommand(query, con);

                #region Parametro nome
                SqlParameter nome = new SqlParameter();
                nome.ParameterName = "nome";
                nome.Value = obj.nome;
                #endregion

                #region Parametro tipo
                SqlParameter tipo = new SqlParameter();
                tipo.ParameterName = "tipo";
                tipo.Value = obj.tipo;
                #endregion

                #region Parametro tamanho
                SqlParameter tamanho = new SqlParameter();
                tamanho.ParameterName = "tamanho";
                tamanho.Value = obj.tamanho;
                #endregion

                #region Parametro tendencia
                SqlParameter tendencia = new SqlParameter();
                tendencia.ParameterName = "tendencia";
                tendencia.Value = obj.tendencia;
                #endregion

                #region Parametro hp
                SqlParameter hp = new SqlParameter();
                hp.ParameterName = "hp";
                hp.Value = obj.hp;
                #endregion

                #region Parametro ca
                SqlParameter ca = new SqlParameter();
                ca.ParameterName = "ca";
                ca.Value = obj.ca;
                #endregion

                #region Parametro desloc_t
                SqlParameter desloc_t = new SqlParameter();
                desloc_t.ParameterName = "desloc_t";
                desloc_t.Value = obj.desloc_t;
                #endregion

                #region Parametro desloc_e
                SqlParameter desloc_e = new SqlParameter();
                desloc_e.ParameterName = "desloc_e";
                desloc_e.Value = obj.desloc_e;
                #endregion

                #region Parametro desloc_n
                SqlParameter desloc_n = new SqlParameter();
                desloc_n.ParameterName = "desloc_n";
                desloc_n.Value = obj.desloc_n;
                #endregion

                #region Parametro desloc_v
                SqlParameter desloc_v = new SqlParameter();
                desloc_v.ParameterName = "desloc_v";
                desloc_v.Value = obj.desloc_v;
                #endregion

                #region Parametro desloc_s
                SqlParameter desloc_s = new SqlParameter();
                desloc_s.ParameterName = "desloc_s";
                desloc_s.Value = obj.desloc_s;
                #endregion

                #region Parametro bp
                SqlParameter bp = new SqlParameter();
                bp.ParameterName = "bp";
                bp.Value = obj.bp;
                #endregion

                #region Parametro stre
                SqlParameter stre = new SqlParameter();
                stre.ParameterName = "stre";
                stre.Value = obj.str;
                #endregion

                #region Parametro stre
                SqlParameter dex = new SqlParameter();
                dex.ParameterName = "dex";
                dex.Value = obj.dex;
                #endregion

                #region Parametro cons
                SqlParameter cons = new SqlParameter();
                cons.ParameterName = "con";
                cons.Value = obj.con;
                #endregion

                #region Parametro inte
                SqlParameter inte = new SqlParameter();
                inte.ParameterName = "inte";
                inte.Value = obj.inte;
                #endregion

                #region Parametro wis
                SqlParameter wis = new SqlParameter();
                wis.ParameterName = "wis";
                wis.Value = obj.wis;
                #endregion

                #region Parametro cha
                SqlParameter cha = new SqlParameter();
                cha.ParameterName = "cha";
                cha.Value = obj.cha;
                #endregion

                #region Parametro nd
                SqlParameter nd = new SqlParameter();
                nd.ParameterName = "nd";
                nd.Value = obj.nd;
                #endregion

                #region Parametro tracos
                SqlParameter tracos = new SqlParameter();
                tracos.ParameterName = "tracos";
                tracos.Value = obj.tracos;
                tracos.SqlDbType = SqlDbType.Text;
                #endregion

                #region Parametro pericias
                SqlParameter pericias = new SqlParameter();
                pericias.ParameterName = "pericias";
                pericias.Value = obj.pericias;
                pericias.SqlDbType = SqlDbType.Text;
                #endregion

                #region Parametro caracteristicas
                SqlParameter caracteristicas = new SqlParameter();
                caracteristicas.ParameterName = "caracteristicas";
                caracteristicas.Value = obj.caracteristicas;
                caracteristicas.SqlDbType = SqlDbType.Text;
                #endregion

                #region Parametro acoes
                SqlParameter acoes = new SqlParameter();
                acoes.ParameterName = "acoes";
                acoes.Value = obj.acoes;
                acoes.SqlDbType = SqlDbType.Text;
                #endregion

                #region Parametro tracos
                SqlParameter acoeslendarias = new SqlParameter();
                acoeslendarias.ParameterName = "acoeslendarias";
                acoeslendarias.Value = obj.acoesLendarias;
                acoeslendarias.SqlDbType = SqlDbType.Text;
                #endregion

                cmd.Parameters.Add(nome);
                cmd.Parameters.Add(tipo);
                cmd.Parameters.Add(tamanho);
                cmd.Parameters.Add(tendencia);
                cmd.Parameters.Add(hp);
                cmd.Parameters.Add(ca);
                cmd.Parameters.Add(desloc_t);
                cmd.Parameters.Add(desloc_e);
                cmd.Parameters.Add(desloc_n);
                cmd.Parameters.Add(desloc_v);
                cmd.Parameters.Add(desloc_s);
                cmd.Parameters.Add(bp);
                cmd.Parameters.Add(stre);
                cmd.Parameters.Add(dex);
                cmd.Parameters.Add(con);
                cmd.Parameters.Add(inte);
                cmd.Parameters.Add(wis);
                cmd.Parameters.Add(cha);
                cmd.Parameters.Add(nd);
                cmd.Parameters.Add(tracos);
                cmd.Parameters.Add(pericias);
                cmd.Parameters.Add(caracteristicas);
                cmd.Parameters.Add(acoes);
                cmd.Parameters.Add(acoeslendarias);



                #endregion

                reader = cmd.ExecuteReader();
                dt.Load(reader);

                try
                {
                    retorno = int.Parse(dt.Rows[0]["Return"].ToString());

                    if (retorno > 0)
                    {
                        msg = retorno.ToString() + " - Incluido Com Sucesso";
                    }
                    else
                    {
                        msg = retorno.ToString() + " - Erro ao incluir, favor validar na base de dados";
                    }
                }
                catch (Exception ex)
                {
                    retorno = 0;
                    msg = retorno.ToString() + " - " + ex.Message;
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

            return msg;
        }
        #endregion

        #region AdicionaVeiculo
        public string AdicionaVeiculo(Veiculo obj)
        {
            DataTable dt = new DataTable();
            int retorno = 0;
            string msg = "";

            try
            {
                con.Open();

                #region Monta a query
                String query = parametro.ConsultarParametro("procedureAdicionarVeiculos") + "@nome ,@tipo ,@custo ,@moeda ,@velocidade ,@durabilidade";
                SqlCommand cmd = new SqlCommand(query, con);

                #region Parametro nome
                SqlParameter nome = new SqlParameter();
                nome.ParameterName = "nome";
                nome.Value = obj.nome;
                #endregion

                #region Parametro tipo
                SqlParameter tipo = new SqlParameter();
                tipo.ParameterName = "tipo";
                tipo.Value = obj.tipo;
                tipo.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro custo
                SqlParameter custo = new SqlParameter();
                custo.ParameterName = "custo";
                custo.Value = obj.custo;
                custo.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro moeda
                SqlParameter moeda = new SqlParameter();
                moeda.ParameterName = "moeda";
                moeda.Value = obj.moeda;
                moeda.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro velocidade
                SqlParameter velocidade = new SqlParameter();
                velocidade.ParameterName = "velocidade";
                velocidade.Value = obj.velocidade;
                #endregion

                #region Parametro durabilidade
                SqlParameter durabilidade = new SqlParameter();
                durabilidade.ParameterName = "durabilidade";
                durabilidade.Value = obj.durabilidade;
                durabilidade.SqlDbType = SqlDbType.Int;
                #endregion                

                cmd.Parameters.Add(nome);
                cmd.Parameters.Add(tipo);
                cmd.Parameters.Add(custo);
                cmd.Parameters.Add(moeda);
                cmd.Parameters.Add(velocidade);
                cmd.Parameters.Add(durabilidade);
                

                #endregion

                reader = cmd.ExecuteReader();
                dt.Load(reader);

                try
                {
                    retorno = int.Parse(dt.Rows[0]["Return"].ToString());

                    if (retorno > 0)
                    {
                        msg = retorno.ToString() + " - Incluido Com Sucesso";
                    }
                    else
                    {
                        msg = retorno.ToString() + " - Erro ao incluir, favor validar na base de dados";
                    }
                }
                catch (Exception ex)
                {
                    retorno = 0;
                    msg = retorno.ToString() + " - " + ex.Message;
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

            return msg;

        }
        #endregion
    }
}
