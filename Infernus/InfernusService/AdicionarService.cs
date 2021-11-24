using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfernusDAO;
using System.Data;

namespace InfernusService
{
    public class AdicionarService
    {
        #region Variaveis
        private static AdicionaDAO _dao = new AdicionaDAO();
        private static TrataMensagem _mensagem = new TrataMensagem();
        #endregion

        #region Constantes
        private static string NOME = _mensagem.retornaMensagemFormatada(100);
        private static string CUSTO = _mensagem.retornaMensagemFormatada(101);
        private static string MOEDA = _mensagem.retornaMensagemFormatada(102);
        private static string DANO = _mensagem.retornaMensagemFormatada(103);
        private static string TIPODEDANO = _mensagem.retornaMensagemFormatada(104);
        private static string PESO = _mensagem.retornaMensagemFormatada(105);
        private static string PROPRIEDADE = _mensagem.retornaMensagemFormatada(106);
        private static string DURABILIDADE = _mensagem.retornaMensagemFormatada(107);
        private static string EFEITOS = _mensagem.retornaMensagemFormatada(108);
        private static string OBSERVACAO = _mensagem.retornaMensagemFormatada(109);
        private static string CA = _mensagem.retornaMensagemFormatada(110);
        private static string FURTIVIDADE = _mensagem.retornaMensagemFormatada(111);
        private static string FORCA = _mensagem.retornaMensagemFormatada(112);
        private static string TIPOARMADURA = _mensagem.retornaMensagemFormatada(113);
        private static string DESCRICAO = _mensagem.retornaMensagemFormatada(114);
        private static string NIVEL = _mensagem.retornaMensagemFormatada(115);
        private static string ESCOLA = _mensagem.retornaMensagemFormatada(116);
        private static string DURACAO = _mensagem.retornaMensagemFormatada(117);
        private static string ALCANCE = _mensagem.retornaMensagemFormatada(118);
        private static string TEMPODECONJURACAO = _mensagem.retornaMensagemFormatada(119);
        private static string COMPONENTES = _mensagem.retornaMensagemFormatada(120);
        private static string OBRIGATORIO = _mensagem.retornaMensagemFormatada(121);
        #endregion

        public string AdicionaItem(DataSet dtsEntrada)
        {
            try
            {
                string msg = "";

                if (dtsEntrada.Tables.Count == 0)
                {
                    msg = _mensagem.retornaMensagemFormatada(999);
                }
                else
                {
                    #region Armas
                    if (dtsEntrada.Tables.Contains("arma") && dtsEntrada.Tables["arma"].Rows.Count > 0)
                    {
                        Arma obj = new Arma();

                        msg = ValidaObjArma(dtsEntrada);

                        if (msg.Length == 0)
                        {
                            foreach (DataRow linha in dtsEntrada.Tables["arma"].Rows)
                            {
                                obj = PreencheDadosArma(linha);

                                msg = _dao.AdicionaArma(obj);
                            }
                        }
                    }
                    #endregion

                    #region Armaduras
                    else if (dtsEntrada.Tables.Contains("armadura") && dtsEntrada.Tables["armadura"].Rows.Count > 0)
                    {
                        Armadura obj = new Armadura();

                        msg = ValidaObjArmadura(dtsEntrada);

                        if (msg.Length == 0)
                        {
                            foreach (DataRow linha in dtsEntrada.Tables["armadura"].Rows)
                            {
                                obj = PreencheDadosArmadura(linha);

                                msg = _dao.AdicionaArmadura(obj);
                            }
                        }
                    }
                    #endregion

                    #region Item
                    else if (dtsEntrada.Tables.Contains("item") && dtsEntrada.Tables["item"].Rows.Count > 0)
                    {
                        Item obj = new Item();

                        msg = ValidaObjItem(dtsEntrada);

                        if (msg.Length == 0)
                        {
                            foreach (DataRow linha in dtsEntrada.Tables["item"].Rows)
                            {
                                obj = PreencheDadosItem(linha);

                                msg = _dao.AdicionaItem(obj);
                            }
                        }
                    }
                    #endregion

                    #region Magia
                    else if (dtsEntrada.Tables.Contains("magia") && dtsEntrada.Tables["magia"].Rows.Count > 0)
                    {
                        Magia obj = new Magia();

                        msg = ValidaObjMagia(dtsEntrada);

                        if (msg.Length == 0)
                        {
                            foreach (DataRow linha in dtsEntrada.Tables["magia"].Rows)
                            {
                                obj = PreencheDadosMagia(linha);

                                msg = _dao.AdicionaMagia(obj);
                            }
                        }
                    }
                    #endregion

                    #region Monstro
                    else if (dtsEntrada.Tables.Contains("monstro") && dtsEntrada.Tables["monstro"].Rows.Count > 0)
                    {
                        Monstro obj = new Monstro();

                        msg = ValidaObjMonstro(dtsEntrada);

                        if (msg.Length == 0)
                        {
                            foreach (DataRow linha in dtsEntrada.Tables["monstro"].Rows)
                            {
                                obj = PreencheDadosMonstro(linha);

                                msg = _dao.AdicionaMonstro(obj);
                            }
                        }
                    }
                    #endregion

                    #region Veiculos
                    else if (dtsEntrada.Tables.Contains("veiculo") && dtsEntrada.Tables["veiculo"].Rows.Count > 0)
                    {
                        Veiculo obj = new Veiculo();

                        msg = ValidaObjVeiculo(dtsEntrada);

                        if (msg.Length == 0)
                        {
                            foreach (DataRow linha in dtsEntrada.Tables["veiculo"].Rows)
                            {
                                obj = PreencheDadosVeiculo(linha);

                                msg = _dao.AdicionaVeiculo(obj);
                            }
                        }
                    }
                    #endregion
                }

                return msg;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        #region ValidaObjVeiculo
        private Veiculo PreencheDadosVeiculo(DataRow linha)
        {
            Veiculo obj = new Veiculo();

            #region Preenchimento do objeto Veiculo

            obj.nome = linha["nome"].ToString();
            obj.custo = linha["custo"].ToString();
            obj.moeda = linha["moeda"].ToString();
            obj.tipo = linha["tipo"].ToString();
            obj.durabilidade = linha["durabilidade"].ToString();
            obj.velocidade = linha["velocidade"].ToString();

            #endregion

            return obj;
        }

        private string ValidaObjVeiculo(DataSet dtsEntrada)
        {
            StringBuilder sb = new StringBuilder();
            Veiculo obj = new Veiculo();

            DataTable dtEntrada = dtsEntrada.Tables["item"];

            foreach (DataRow linha in dtEntrada.Rows)
            {

                if (dtEntrada.Columns.Contains("item"))
                {
                    obj.item = linha["item"].ToString();
                }

                if (dtEntrada.Columns.Contains("nome"))
                {
                    obj.nome = linha["nome"].ToString();

                    if (String.IsNullOrEmpty(obj.nome))
                    {
                        sb.Append("Item - " + obj.item + " - " + NOME);
                    }
                }
                if (dtEntrada.Columns.Contains("custo"))
                {
                    obj.custo = linha["custo"].ToString();

                    if (String.IsNullOrEmpty(obj.custo))
                    {
                        sb.Append("Item - " + obj.item + " - " + CUSTO);
                    }
                }
                if (dtEntrada.Columns.Contains("moeda"))
                {
                    obj.moeda = linha["moeda"].ToString();

                    if (String.IsNullOrEmpty(obj.moeda))
                    {
                        sb.Append("Item - " + obj.item + " - " + MOEDA);
                    }
                }
                if (dtEntrada.Columns.Contains("tipo"))
                {
                    obj.tipo = linha["tipo"].ToString();

                    if (String.IsNullOrEmpty(obj.tipo))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}","tipo de veiculo"));
                    }
                }
                if (dtEntrada.Columns.Contains("durabilidade"))
                {
                    obj.durabilidade = linha["durabilidade"].ToString();

                    if (String.IsNullOrEmpty(obj.durabilidade))
                    {
                        sb.Append("Item - " + obj.item + " - " + DURABILIDADE);
                    }
                }
                if (dtEntrada.Columns.Contains("velocidade"))
                {
                    obj.velocidade = linha["velocidade"].ToString();

                    if (String.IsNullOrEmpty(obj.velocidade))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "velocidade"));
                    }
                }
            }

            return sb.ToString();
        }
        #endregion

        #region ValidaObjMonstro
        private Monstro PreencheDadosMonstro(DataRow linha)
        {
            Monstro obj = new Monstro();

            #region Preenchimento do objeto Magia
            obj.nome = linha["nome"].ToString();
            obj.acoes = linha["acoes"].ToString();
            obj.acoesLendarias = linha["acoeslendarias"].ToString();
            obj.bp = linha["bp"].ToString();
            obj.ca = linha["ca"].ToString();
            obj.caracteristicas = linha["caracteristicas"].ToString();
            obj.cha = linha["cha"].ToString();
            obj.con = linha["con"].ToString();
            obj.desloc_e = linha["desloc_e"].ToString();
            obj.desloc_n = linha["desloc_n"].ToString();
            obj.desloc_s = linha["desloc_s"].ToString();
            obj.desloc_t = linha["desloc_t"].ToString();
            obj.desloc_v = linha["desloc_v"].ToString();
            obj.dex = linha["dex"].ToString();
            obj.hp = linha["hp"].ToString();
            obj.inte = linha["inte"].ToString();
            obj.nd = linha["nd"].ToString();
            obj.pericias = linha["pericias"].ToString();
            obj.str = linha["str"].ToString();
            obj.tamanho = linha["tamanho"].ToString();
            obj.tendencia = linha["tendencia"].ToString();
            obj.tipo = linha["tipo"].ToString();
            obj.tracos = linha["tracos"].ToString();
            obj.wis = linha["wis"].ToString();            
            #endregion

            return obj;
        }

        private string ValidaObjMonstro(DataSet dtsEntrada)
        {
            StringBuilder sb = new StringBuilder();
            Monstro obj = new Monstro();

            DataTable dtEntrada = dtsEntrada.Tables["monstro"];

            foreach (DataRow linha in dtEntrada.Rows)
            {
                if (dtEntrada.Columns.Contains("item"))
                {
                    obj.item = linha["item"].ToString();
                }

                if (dtEntrada.Columns.Contains("nome"))
                {
                    obj.nome = linha["nome"].ToString();

                    if (String.IsNullOrEmpty(obj.nome))
                    {
                        sb.Append("Item - " + obj.item + " - " + NOME);
                    }
                }
                if (dtEntrada.Columns.Contains("acoes"))
                {
                    obj.acoes = linha["acoes"].ToString();

                    if (String.IsNullOrEmpty(obj.acoes))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}","ações"));
                    }
                }
                if (dtEntrada.Columns.Contains("acoeslendarias"))
                {
                    obj.acoesLendarias = linha["acoeslendarias"].ToString();

                    if (String.IsNullOrEmpty(obj.acoesLendarias))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}","ações lendárias"));
                    }
                }
                if (dtEntrada.Columns.Contains("bp"))
                {
                    obj.bp = linha["bp"].ToString();

                    if (String.IsNullOrEmpty(obj.bp))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "BP"));
                    }
                }
                if (dtEntrada.Columns.Contains("ca"))
                {
                    obj.ca = linha["ca"].ToString();

                    if (String.IsNullOrEmpty(obj.ca))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "CA"));
                    }
                }
                if (dtEntrada.Columns.Contains("caracteristicas"))
                {
                    obj.caracteristicas = linha["caracteristicas"].ToString();

                    if (String.IsNullOrEmpty(obj.caracteristicas))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Caracterísiticas"));
                    }
                }
                if (dtEntrada.Columns.Contains("cha"))
                {
                    obj.cha = linha["cha"].ToString();

                    if (String.IsNullOrEmpty(obj.cha))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Carisma"));
                    }
                }
                if (dtEntrada.Columns.Contains("con"))
                {
                    obj.con = linha["con"].ToString();

                    if (String.IsNullOrEmpty(obj.con))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Constituição"));
                    }
                }
                if (dtEntrada.Columns.Contains("desloc_e"))
                {
                    obj.desloc_e = linha["desloc_e"].ToString();

                    if (String.IsNullOrEmpty(obj.desloc_e))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Deslocamento(Escalada)"));
                    }
                }
                if (dtEntrada.Columns.Contains("desloc_n"))
                {
                    obj.desloc_n = linha["desloc_n"].ToString();

                    if (String.IsNullOrEmpty(obj.desloc_n))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Deslocamento(Natação)"));
                    }
                }
                if (dtEntrada.Columns.Contains("desloc_s"))
                {
                    obj.desloc_s = linha["desloc_s"].ToString();

                    if (String.IsNullOrEmpty(obj.desloc_s))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Deslocamento(Subterrâneo)"));
                    }
                }
                if (dtEntrada.Columns.Contains("desloc_t"))
                {
                    obj.desloc_t = linha["desloc_t"].ToString();

                    if (String.IsNullOrEmpty(obj.desloc_t))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Deslocamento(Terrestre)"));
                    }
                }
                if (dtEntrada.Columns.Contains("desloc_v"))
                {
                    obj.desloc_v = linha["desloc_v"].ToString();

                    if (String.IsNullOrEmpty(obj.desloc_v))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Deslocamento(Vôo)"));
                    }
                }
                if (dtEntrada.Columns.Contains("dex"))
                {
                    obj.dex = linha["dex"].ToString();

                    if (String.IsNullOrEmpty(obj.dex))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Destreza"));
                    }
                }
                if (dtEntrada.Columns.Contains("hp"))
                {
                    obj.hp = linha["hp"].ToString();

                    if (String.IsNullOrEmpty(obj.hp))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "HP"));
                    }
                }
                if (dtEntrada.Columns.Contains("inte"))
                {
                    obj.inte = linha["inte"].ToString();

                    if (String.IsNullOrEmpty(obj.inte))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Inteligência"));
                    }
                }
                if (dtEntrada.Columns.Contains("nd"))
                {
                    obj.nd = linha["nd"].ToString();

                    if (String.IsNullOrEmpty(obj.nd))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "ND"));
                    }
                }
                if (dtEntrada.Columns.Contains("pericias"))
                {
                    obj.pericias = linha["pericias"].ToString();

                    if (String.IsNullOrEmpty(obj.pericias))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Perícias"));
                    }
                }
                if (dtEntrada.Columns.Contains("str"))
                {
                    obj.str = linha["str"].ToString();

                    if (String.IsNullOrEmpty(obj.str))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Força"));
                    }
                }
                if (dtEntrada.Columns.Contains("tamanho"))
                {
                    obj.tamanho = linha["tamanho"].ToString();

                    if (String.IsNullOrEmpty(obj.tamanho))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Tamanho"));
                    }
                }
                if (dtEntrada.Columns.Contains("tendencia"))
                {
                    obj.tendencia = linha["tendencia"].ToString();

                    if (String.IsNullOrEmpty(obj.tendencia))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Tendência"));
                    }
                }
                if (dtEntrada.Columns.Contains("tipo"))
                {
                    obj.tipo = linha["tipo"].ToString();

                    if (String.IsNullOrEmpty(obj.tipo))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Tipo"));
                    }
                }
                if (dtEntrada.Columns.Contains("tracos"))
                {
                    obj.tracos = linha["tracos"].ToString();

                    if (String.IsNullOrEmpty(obj.tracos))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Traços"));
                    }
                }
                if (dtEntrada.Columns.Contains("wis"))
                {
                    obj.wis = linha["wis"].ToString();

                    if (String.IsNullOrEmpty(obj.wis))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBRIGATORIO.Replace("{0}", "Sabedoria"));
                    }
                }
            }

            return sb.ToString();
        }
        #endregion

        #region ValidaObjMagia
        private string ValidaObjMagia(DataSet dtsEntrada)
        {
            StringBuilder sb = new StringBuilder();
            Magia obj = new Magia();

            DataTable dtEntrada = dtsEntrada.Tables["magia"];

            foreach (DataRow linha in dtEntrada.Rows)
            {
                if (dtEntrada.Columns.Contains("item"))
                {
                    obj.item = linha["item"].ToString();
                }

                if (dtEntrada.Columns.Contains("nome"))
                {
                    obj.nome = linha["nome"].ToString();

                    if (String.IsNullOrEmpty(obj.nome))
                    {
                        sb.Append("Item - " + obj.item + " - " + NOME);
                    }
                }
                if (dtEntrada.Columns.Contains("nivel"))
                {
                    obj.nivel = linha["nivel"].ToString();

                    if (String.IsNullOrEmpty(obj.nivel))
                    {
                        sb.Append("Item - " + obj.item + " - " + NIVEL);
                    }
                }
                if (dtEntrada.Columns.Contains("escola"))
                {
                    obj.escola = linha["escola"].ToString();

                    if (String.IsNullOrEmpty(obj.escola))
                    {
                        sb.Append("Item - " + obj.item + " - " + ESCOLA);
                    }
                }
                if (dtEntrada.Columns.Contains("duracao"))
                {
                    obj.duracao = linha["duracao"].ToString();

                    if (String.IsNullOrEmpty(obj.duracao))
                    {
                        sb.Append("Item - " + obj.item + " - " + DURACAO);
                    }
                }
                if (dtEntrada.Columns.Contains("alcance"))
                {
                    obj.alcance = linha["alcance"].ToString();

                    if (String.IsNullOrEmpty(obj.alcance))
                    {
                        sb.Append("Item - " + obj.item + " - " + ALCANCE);
                    }
                }
                if (dtEntrada.Columns.Contains("tempo_de_conjuracao"))
                {
                    obj.tempoDeConjuracao = linha["tempo_de_conjuracao"].ToString();

                    if (String.IsNullOrEmpty(obj.duracao))
                    {
                        sb.Append("Item - " + obj.item + " - " + TEMPODECONJURACAO);
                    }
                }
                if (dtEntrada.Columns.Contains("componentes"))
                {
                    obj.componentes = linha["componentes"].ToString();

                    if (String.IsNullOrEmpty(obj.duracao))
                    {
                        sb.Append("Item - " + obj.item + " - " + COMPONENTES);
                    }
                }
                if (dtEntrada.Columns.Contains("descricao"))
                {
                    obj.descricao = linha["descricao"].ToString();

                    if (String.IsNullOrEmpty(obj.descricao))
                    {
                        sb.Append("Item - " + obj.item + " - " + DESCRICAO);
                    }
                }
            }
            return sb.ToString();
        }

        private Magia PreencheDadosMagia(DataRow linha)
        {
            Magia obj = new Magia();

            #region Preenchimento do objeto Magia
            obj.nome = linha["nome"].ToString();
            obj.nivel = linha["nivel"].ToString();
            obj.escola = linha["escola"].ToString();
            obj.duracao = linha["duracao"].ToString();
            obj.alcance = linha["alcance"].ToString();
            obj.tempoDeConjuracao = linha["tempo_de_conjuracao"].ToString();
            obj.componentes = linha["componentes"].ToString();
            obj.descricao = linha["descricao"].ToString();
            #endregion

            return obj;
        }
        #endregion

        #region ValidaObjItem
        private Item PreencheDadosItem(DataRow linha)
        {
            Item obj = new Item();

            #region Preenchimento do objeto Item

            obj.nome = linha["nome"].ToString();
            obj.custo = linha["custo"].ToString();
            obj.moeda = linha["moeda"].ToString();
            obj.peso = linha["peso"].ToString();
            obj.durabilidade = linha["durabilidade"].ToString();
            obj.descricao = linha["descricao"].ToString();

            #endregion

            return obj;
        }

        private string ValidaObjItem(DataSet dtsEntrada)
        {
            StringBuilder sb = new StringBuilder();
            Item obj = new Item();

            DataTable dtEntrada = dtsEntrada.Tables["item"];

            foreach (DataRow linha in dtEntrada.Rows)
            {

                if (dtEntrada.Columns.Contains("item"))
                {
                    obj.item = linha["item"].ToString();
                }

                if (dtEntrada.Columns.Contains("nome"))
                {
                    obj.nome = linha["nome"].ToString();

                    if (String.IsNullOrEmpty(obj.nome))
                    {
                        sb.Append("Item - " + obj.item + " - " + NOME);
                    }
                }
                if (dtEntrada.Columns.Contains("custo"))
                {
                    obj.custo = linha["custo"].ToString();

                    if (String.IsNullOrEmpty(obj.custo))
                    {
                        sb.Append("Item - " + obj.item + " - " + CUSTO);
                    }
                }
                if (dtEntrada.Columns.Contains("moeda"))
                {
                    obj.moeda = linha["moeda"].ToString();

                    if (String.IsNullOrEmpty(obj.moeda))
                    {
                        sb.Append("Item - " + obj.item + " - " + MOEDA);
                    }
                }
                if (dtEntrada.Columns.Contains("peso"))
                {
                    obj.peso = linha["peso"].ToString();

                    if (String.IsNullOrEmpty(obj.peso))
                    {
                        sb.Append("Item - " + obj.item + " - " + PESO);
                    }
                }
                if (dtEntrada.Columns.Contains("durabilidade"))
                {
                    obj.durabilidade = linha["durabilidade"].ToString();

                    if (String.IsNullOrEmpty(obj.durabilidade))
                    {
                        sb.Append("Item - " + obj.item + " - " + DURABILIDADE);
                    }
                }
                if (dtEntrada.Columns.Contains("descricao"))
                {
                    obj.descricao = linha["descricao"].ToString();

                    if (String.IsNullOrEmpty(obj.descricao))
                    {
                        sb.Append("Item - " + obj.item + " - " + DESCRICAO);
                    }
                }
            }

            return sb.ToString();
        }
        #endregion

        #region ValidaObjArmadura
        private string ValidaObjArmadura(DataSet dtsEntrada)
        {
            StringBuilder sb = new StringBuilder();
            Armadura obj = new Armadura();

            DataTable dtEntrada = dtsEntrada.Tables["arma"];

            foreach (DataRow linha in dtEntrada.Rows)
            {
                if (dtEntrada.Columns.Contains("item"))
                {
                    obj.item = linha["item"].ToString();
                }

                if (dtEntrada.Columns.Contains("nome"))
                {
                    obj.nome = linha["nome"].ToString();

                    if (String.IsNullOrEmpty(obj.nome))
                    {
                        sb.Append("Item - " + obj.item + " - " + NOME);
                    }
                }
                if (dtEntrada.Columns.Contains("custo"))
                {
                    obj.custo = linha["custo"].ToString();

                    if (String.IsNullOrEmpty(obj.custo))
                    {
                        sb.Append("Item - " + obj.item + " - " + CUSTO);
                    }
                }
                if (dtEntrada.Columns.Contains("moeda"))
                {
                    obj.moeda = linha["moeda"].ToString();

                    if (String.IsNullOrEmpty(obj.moeda))
                    {
                        sb.Append("Item - " + obj.item + " - " + MOEDA);
                    }
                }
                if (dtEntrada.Columns.Contains("tipo_armadura"))
                {
                    obj.tipoArmadura = linha["tipo_armadura"].ToString();

                    if (String.IsNullOrEmpty(obj.tipoArmadura))
                    {
                        sb.Append("Item - " + obj.item + " - " + TIPOARMADURA);
                    }
                }
                if (dtEntrada.Columns.Contains("ca"))
                {
                    obj.ca = linha["ca"].ToString();

                    if (String.IsNullOrEmpty(obj.ca))
                    {
                        sb.Append("Item - " + obj.item + " - " + CA);
                    }
                }
                if (dtEntrada.Columns.Contains("peso"))
                {
                    obj.peso = linha["peso"].ToString();

                    if (String.IsNullOrEmpty(obj.peso))
                    {
                        sb.Append("Item - " + obj.item + " - " + PESO);
                    }
                }
                if (dtEntrada.Columns.Contains("furtv"))
                {
                    obj.furtv = linha["furtv"].ToString();

                    if (String.IsNullOrEmpty(obj.furtv))
                    {
                        sb.Append("Item - " + obj.item + " - " + FURTIVIDADE);
                    }
                }
                if (dtEntrada.Columns.Contains("forca"))
                {
                    obj.forca = linha["forca"].ToString();

                    if (String.IsNullOrEmpty(obj.forca))
                    {
                        sb.Append("Item - " + obj.item + " - " + FORCA);
                    }
                }
                if (dtEntrada.Columns.Contains("durabilidade"))
                {
                    obj.durabilidade = linha["durabilidade"].ToString();

                    if (String.IsNullOrEmpty(obj.durabilidade))
                    {
                        sb.Append("Item - " + obj.item + " - " + DURABILIDADE);
                    }
                }
                if (dtEntrada.Columns.Contains("observacao"))
                {
                    obj.observacao = linha["observacao"].ToString();

                    if (String.IsNullOrEmpty(obj.observacao))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBSERVACAO);
                    }
                }
            }

            return sb.ToString();
        }

        private Armadura PreencheDadosArmadura(DataRow linha)
        {
            Armadura obj = new Armadura();

            #region Preenchimento do objeto Armadura


            obj.nome = linha["nome"].ToString();

            obj.custo = linha["custo"].ToString();

            obj.moeda = linha["moeda"].ToString();

            obj.tipoArmadura = linha["tipo_armadura"].ToString();

            obj.ca = linha["ca"].ToString();

            obj.peso = linha["peso"].ToString();

            obj.furtv = linha["furtv"].ToString();

            obj.forca = linha["forca"].ToString();

            obj.durabilidade = linha["durabilidade"].ToString();

            obj.observacao = linha["observacao"].ToString();


            #endregion

            return obj;
        }
        #endregion

        #region ValidaObjArma
        private string ValidaObjArma(DataSet dtsEntrada)
        {
            StringBuilder sb = new StringBuilder();
            Arma obj = new Arma();

            DataTable dtEntrada = dtsEntrada.Tables["arma"];

            foreach (DataRow linha in dtEntrada.Rows)
            {
                if (dtEntrada.Columns.Contains("item"))
                {
                    obj.item = linha["item"].ToString();
                }

                if (dtEntrada.Columns.Contains("nome"))
                {
                    obj.nome = linha["nome"].ToString();

                    if (String.IsNullOrEmpty(obj.nome))
                    {
                        sb.Append("Item - " + obj.item + " - " + NOME);
                    }
                }
                if (dtEntrada.Columns.Contains("custo"))
                {
                    obj.custo = linha["custo"].ToString();

                    if (String.IsNullOrEmpty(obj.custo))
                    {
                        sb.Append("Item - " + obj.item + " - " + CUSTO);
                    }
                }
                if (dtEntrada.Columns.Contains("moeda"))
                {
                    obj.moeda = linha["moeda"].ToString();

                    if (String.IsNullOrEmpty(obj.moeda))
                    {
                        sb.Append("Item - " + obj.item + " - " + MOEDA);
                    }
                }
                if (dtEntrada.Columns.Contains("dano"))
                {
                    obj.dano = linha["dano"].ToString();

                    if (String.IsNullOrEmpty(obj.dano))
                    {
                        sb.Append("Item - " + obj.item + " - " + DANO);
                    }
                }
                if (dtEntrada.Columns.Contains("tipo_de_dano"))
                {
                    obj.tipoDeDano = linha["tipo_de_dano"].ToString();

                    if (String.IsNullOrEmpty(obj.tipoDeDano))
                    {
                        sb.Append("Item - " + obj.item + " - " + TIPODEDANO);
                    }
                }
                if (dtEntrada.Columns.Contains("peso"))
                {
                    obj.peso = linha["peso"].ToString();

                    if (String.IsNullOrEmpty(obj.peso))
                    {
                        sb.Append("Item - " + obj.item + " - " + PESO);
                    }
                }
                if (dtEntrada.Columns.Contains("propriedade"))
                {
                    obj.propriedade = linha["propriedade"].ToString();

                    if (String.IsNullOrEmpty(obj.propriedade))
                    {
                        sb.Append("Item - " + obj.item + " - " + PROPRIEDADE);
                    }
                }
                if (dtEntrada.Columns.Contains("durabilidade"))
                {
                    obj.durabilidade = linha["durabilidade"].ToString();

                    if (String.IsNullOrEmpty(obj.durabilidade))
                    {
                        sb.Append("Item - " + obj.item + " - " + DURABILIDADE);
                    }
                }
                if (dtEntrada.Columns.Contains("efeitos"))
                {
                    obj.efeitos = linha["efeitos"].ToString();

                    if (String.IsNullOrEmpty(obj.efeitos))
                    {
                        sb.Append("Item - " + obj.item + " - " + EFEITOS);
                    }
                }
                if (dtEntrada.Columns.Contains("observacao"))
                {
                    obj.observacao = linha["observacao"].ToString();

                    if (String.IsNullOrEmpty(obj.observacao))
                    {
                        sb.Append("Item - " + obj.item + " - " + OBSERVACAO);
                    }
                }
            }

            return sb.ToString();
        }

        private Arma PreencheDadosArma(DataRow linha)
        {
            Arma obj = new Arma();

            #region Preenchimento do objeto Arma

            obj.nome = linha["nome"].ToString();
            obj.custo = linha["custo"].ToString();
            obj.moeda = linha["moeda"].ToString();
            obj.dano = linha["dano"].ToString();
            obj.tipoDeDano = linha["tipo_de_dano"].ToString();
            obj.peso = linha["peso"].ToString();
            obj.propriedade = linha["propriedade"].ToString();
            obj.durabilidade = linha["durabilidade"].ToString();
            obj.efeitos = linha["efeitos"].ToString();
            obj.observacao = linha["observacao"].ToString();

            #endregion

            return obj;
        }
        #endregion


    }
}
