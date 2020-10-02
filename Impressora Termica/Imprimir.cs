using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using RawPrint;
using Zebra.Sdk.Comm;

namespace Impressora_Termica
{
    class Imprimir
    {
        /*public void ImprimirZebra(List<DadosJson> dadosImpressao, Connection conexao)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            printerSettings.PrinterName = "";
            Printer impressora = new Printer();

            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                if (printer.StartsWith("ZDesigner"))
                {
                    printerSettings.PrinterName = printer.ToString();
                    break;
                }
            }

            StreamWriter arquivo = new StreamWriter(Environment.CurrentDirectory + @"\Etiqueta.txt");

            foreach (var item in dadosImpressao)
            {
                String dados = "^XA" +
                               "^FO45,100^A0N,45,30^FR^FD" + "userId: " + item.userId + "^FS" +
                               "^FO45,160^A0N,45,30^FR^FD" + "id: " + item.id + "^FS" +
                               "^FO45,220^A0N,45,30^FR^FD" + "title: " + item.title + "^FS" +
                               "^FO45,280^A0N,45,30^FR^FD" + "completed: " + item.completed + "^FS" +
                               "^XZ";

                arquivo.Write(dados.ToUpper());
            }

            arquivo.Close();

            impressora.PrintRawFile(printerSettings.PrinterName, Environment.CurrentDirectory + @"\Etiqueta.txt", false);
            /*StreamWriter arquivo = new StreamWriter(Environment.CurrentDirectory + @"\Etiqueta.txt");

            Connection conexao_impressora = conexao;
            
            foreach (var item in dadosImpressao)
            {
                String dados = "^XA" +
                               "^FO45,100^A0N,45,30^FR^FD" + "userId: " + item.userId + "^FS" +
                               "^FO45,160^A0N,45,30^FR^FD" + "id: " + item.id + "^FS" +
                               "^FO45,220^A0N,45,30^FR^FD" + "title: " + item.title + "^FS" +
                               "^FO45,280^A0N,45,30^FR^FD" + "completed: " + item.completed + "^FS" +
                               "^XZ";

                conexao_impressora.Write(Encoding.GetEncoding("iso-8859-8").GetBytes(dados.ToUpper()));
            }

            conexao_impressora.Close();
        }*/

        public void ImprimirEtiqueta(List<DadosJson> dadosImpressao, string impressoraSelecionada)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            printerSettings.PrinterName = "";
            Printer impressora = new Printer();

            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
               if (printer.StartsWith(impressoraSelecionada))
               {
                   printerSettings.PrinterName = printer.ToString();
                   break;
               }
            }

            StreamWriter arquivo = new StreamWriter(Environment.CurrentDirectory + @"\Etiqueta.txt");

            if (impressoraSelecionada.Equals("Argox"))
            {
                foreach (var item in dadosImpressao)
                {
                    arquivo.Write(Encoding.ASCII.GetString(new byte[] { 2 }));
                    arquivo.Write("L");
                    arquivo.Write(Encoding.ASCII.GetString(new byte[] { 13 }));
                    arquivo.Write("H15");
                    arquivo.Write("D15");
                    arquivo.Write(Encoding.ASCII.GetString(new byte[] { 13 }));
                    arquivo.Write("121100000450015Titulo: " + item.titulo);
                    arquivo.Write(Encoding.ASCII.GetString(new byte[] { 13 }));
                    arquivo.Write("121100000750015Resumo: " + item.resumo);
                    arquivo.Write(Encoding.ASCII.GetString(new byte[] { 13 }));
                    arquivo.Write("E");
                    arquivo.Write(Encoding.ASCII.GetString(new byte[] { 13 }));
                }
            }

            if (impressoraSelecionada.Equals("ZDesigner"))
            {
                foreach (var item in dadosImpressao)
                {
                    String dados = "^XA" +
                                   "^FO45,100^A0N,45,30^FR^FD" + "userId: " + item.userId + "^FS" +
                                   "^FO45,160^A0N,45,30^FR^FD" + "id: " + item.id + "^FS" +
                                   "^FO45,220^A0N,45,30^FR^FD" + "title: " + item.title + "^FS" +
                                   "^FO45,280^A0N,45,30^FR^FD" + "completed: " + item.completed + "^FS" +
                                   "^XZ";

                    arquivo.Write(dados.ToUpper());
                }
            }

            arquivo.Close();

            impressora.PrintRawFile(printerSettings.PrinterName, Environment.CurrentDirectory + @"\Etiqueta.txt", false);
        }
    }
}
