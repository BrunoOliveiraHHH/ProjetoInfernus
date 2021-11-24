using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfernusService;

namespace Infernus
{
    public class Mensagens
    {
        private TrataMensagem _service = new TrataMensagem();


        public string ConsultaMensagem(int codMensagem)
        {
            string mensagem = "";
            if (codMensagem > 99)
            {
                mensagem = _service.retornaMensagemFormatada(codMensagem) ;
            }

            return mensagem;
        }
    }
}
