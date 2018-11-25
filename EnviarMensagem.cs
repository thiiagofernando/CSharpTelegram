using System;
using System.IO;
using System.Net;
using System.Text;

namespace Telegram {
    class EnviarMensagem {
        public EnviarMensagem () {

        }
        public void Enviar (string mensagem) {

            string urlString = "https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}";
            string apiToken = "747937067:AAFHzbSiWiooKhdnfwrYRBdgWuUj9tgu7CE";
            string chatId = "@cmsflex";
            string text = mensagem;

            urlString = String.Format (urlString, apiToken, chatId, text);

            WebRequest request = WebRequest.Create (urlString);
            Stream rs = request.GetResponse ().GetResponseStream ();
            StreamReader reader = new StreamReader (rs);

            string line = "";
            StringBuilder sb = new StringBuilder ();

            while (line != null) {
                line = reader.ReadLine ();

                if (line != null)
                    sb.Append (line);
            }
            string response = sb.ToString ();
        }
    }
}