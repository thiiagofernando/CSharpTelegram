using System;
using System.Net.NetworkInformation;

namespace Telegram {
    class Program {
        static void Main (string[] args) {

            EnviarMensagem envia = new EnviarMensagem ();

            var ping = new Ping ();

            try {
                var result = ping.Send ("www.meusite.com");
                if (result.Status == IPStatus.Success) {
                    envia.Enviar ("Site esta Online");
                } else {
                    envia.Enviar ("Site esta fora");
                }

            } catch (Exception) {
                envia.Enviar ("Falha na hora de executar tarefa");
            }
        }
    }
}