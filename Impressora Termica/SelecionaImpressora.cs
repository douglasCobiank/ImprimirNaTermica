using System.Windows.Forms;
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer.Discovery;

namespace Impressora_Termica
{
    class SelecionaImpressora
    {
        public Connection ImprimirEtiqueta()
        {
            Connection c = null;
            try
            {
                //O DiscoverdUsbPrinter só funciona com interface visual, não consegui que funcionasse com o terminal.
                foreach (DiscoveredUsbPrinter usbPrinter in UsbDiscoverer.GetZebraUsbPrinters(new ZebraPrinterFilter()))
                {
                    c = usbPrinter.GetConnection();

                    c.Open();
                }
            }
            catch (ConnectionException ex)
            {
                MessageBox.Show("Não Foi possivel localizar a impressora." + ex.Message);
            }

            return c;
        }
    }
}
