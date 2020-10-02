using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Impressora_Termica
{
    class RecuperarJson
    {
        HttpClient client;
        Imprimir imprimir;
        SelecionaImpressora seleciona;
        public RecuperarJson()
        {
            client = new HttpClient();
            imprimir = new Imprimir();
            seleciona = new SelecionaImpressora();
        }
        
        public async Task RecuperarDados()
        {
            string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
            List <DadosJson> dadosImpressao = JsonConvert.DeserializeObject<List<DadosJson>>(response);

            imprimir.ImprimirEtiqueta(dadosImpressao, "ZDesigner");
            imprimir.ImprimirEtiqueta(dadosImpressao, "Argox");

        }

    }
}
