using System;
using System.Windows.Forms;

namespace Electro_Fih
{
    public partial class HomeUserControl : UserControl
    {
        public event Action<string> HazLetrehozva;
        public event Action<string> HazKivalasztva;

        private bool houseExists = false;
        private int currentUserId; // Tracks the logged-in user

        public HomeUserControl(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        public void SetHouseState(bool exists)
        {
            houseExists = exists;


            if (this.Controls.ContainsKey("panelAddHouse"))
            {
                var panel = this.Controls["panelAddHouse"];
                panel.Visible = !houseExists;
            }


            if (this.Controls.ContainsKey("label1"))
            {
                var lbl = this.Controls["label1"] as Label;

                if (lbl != null)
                {
                    lbl.Text = houseExists
                        ? "Válassz házat a bal oldalon"
                        : "Nincs ház létrehozva";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (houseExists)
                return;

            HazHozzaadasa form = new HazHozzaadasa();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(form.hazNeve))
                {
                    HazLetrehozva?.Invoke(form.hazNeve);
                }
            }
        }

        public void OpenHouse(string houseName, int houseId)
        {
            HazKivalasztva?.Invoke(houseName);


            FirstHouseControl control = new FirstHouseControl()
            {
                Dock = DockStyle.Fill
            };


            control.LoadHouseData(houseId, houseName);

            this.Controls.Clear();
            this.Controls.Add(control);
        }
    }
} 