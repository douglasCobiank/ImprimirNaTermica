using System;
using System.Windows.Forms;

namespace Impressora_Termica
{
    public partial class F_Imprimir : Form
    {
        RecuperarJson recuperar = new RecuperarJson();
        public F_Imprimir()
        {
            InitializeComponent();
        }

        private async void bt_Imprimir_Click(object sender, EventArgs e)
        {
            await recuperar.RecuperarDados();
        }
    }
}
