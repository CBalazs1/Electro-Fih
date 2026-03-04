using System;
using System.Windows.Forms;

namespace Electro_Fih
{
    public partial class HomeUserControl : UserControl
    {
        public event Action<string> HazLetrehozva;

        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HazHozzaadasa form = new HazHozzaadasa();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(form.hazNeve))
                {
                    HazLetrehozva?.Invoke(form.hazNeve);
                }
            }
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
        }
    }
}