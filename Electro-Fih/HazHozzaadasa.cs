using System;
using System.Windows.Forms;

namespace Electro_Fih
{
    public partial class HazHozzaadasa : Form
    {
        public string hazNeve { get; private set; }

        public HazHozzaadasa()
        {
            InitializeComponent();
        }

        private void HarHozzaadasa_Load(object sender, EventArgs e)
        {

        }

        private void hazNevMegadasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            hazNeve = hazNevMegadasa.Text.Trim();

            if (string.IsNullOrWhiteSpace(hazNeve))
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}