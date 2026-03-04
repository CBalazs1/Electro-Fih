using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electro_Fih
{
    public partial class HazHozzaadasa : Form
    {
        public HazHozzaadasa()
        {
            InitializeComponent();
        }

        public string hazNeve {  get; private set; }

        private void HarHozzaadasa_Load(object sender, EventArgs e)
        {

        }

        private void hazHozzaadasaButton_Click(object sender, EventArgs e)
        {
            
        }

        private void hazNevMegadasa_TextChanged(object sender, EventArgs e) { }

        private void rjButton1_Click(object sender, EventArgs e) 
        {
            hazNeve = hazNevMegadasa.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
