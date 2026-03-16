using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Electro_Fih
{
    public partial class MainPage : Form
    {
        private int CurrentUserId;
        private HttpClient client;

        private Panel contentPanel;

        private Button btnHome;
        private Button btnSettings;
        private Button btnLogOut;

        private Button btnElsoHaz;
        private Button btnMasodikHaz;
        private Button btnHarmadikHaz;
        private Button btnNegyedikHaz;

        public MainPage()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("http://100.122.255.19:5229/")
            };

            InitializeComponent();
            this.FormClosed += MainPage_FormClosed;
            SetupUI();
            this.DoubleBuffered = true;
        }

        public void SetUserId(int userId)
        {
            CurrentUserId = userId;
            _ = LoadHousesFromApi();
            LoadHome();
        }

        private void SetupUI()
        {
            this.Text = "Electro-Fih";
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Color primaryPurple = Color.FromArgb(55, 0, 90);

            Panel topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = primaryPurple
            };

            Label title = new Label
            {
                Text = "Electro-Fih",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 15),
                Cursor = Cursors.Hand
            };

            title.Click += Title_Click;
            topPanel.Controls.Add(title);

            Panel sidePanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 220,
                BackColor = Color.FromArgb(45, 0, 75)
            };

            btnHome = CreateNavButton("Házak");
            btnHome.Click += (s, e) => LoadHome();

            btnSettings = CreateNavButton("Beállítások");
            btnSettings.Click += btnSettings_Click;

            btnLogOut = CreateNavButton("Kijelentkezés");
            btnLogOut.Click += btnLogOut_Click;

            btnElsoHaz = ShowHazButton("");
            btnMasodikHaz = ShowHazButton("");
            btnHarmadikHaz = ShowHazButton("");
            btnNegyedikHaz = ShowHazButton("");

            btnHome.Top = 10;
            btnElsoHaz.Top = 60;
            btnMasodikHaz.Top = 110;
            btnHarmadikHaz.Top = 160;
            btnNegyedikHaz.Top = 210;
            btnSettings.Top = 850;
            btnLogOut.Top = 900;

            sidePanel.Controls.Add(btnHome);
            sidePanel.Controls.Add(btnElsoHaz);
            sidePanel.Controls.Add(btnMasodikHaz);
            sidePanel.Controls.Add(btnHarmadikHaz);
            sidePanel.Controls.Add(btnNegyedikHaz);
            sidePanel.Controls.Add(btnSettings);
            sidePanel.Controls.Add(btnLogOut);

            contentPanel = new Panel
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(contentPanel);
            Controls.Add(sidePanel);
            Controls.Add(topPanel);
        }

        private Button CreateNavButton(string text)
        {
            return new Button
            {
                Text = text,
                Width = 200,
                Height = 45,
                Left = 10,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(90, 0, 160),
                ForeColor = Color.White,
                FlatAppearance = { BorderSize = 0 }
            };
        }

        private Button ShowHazButton(string text)
        {
            return new Button
            {
                Text = text,
                Width = 200,
                Height = 45,
                Left = 10,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(74, 0, 130),
                ForeColor = Color.White,
                FlatAppearance = { BorderSize = 0 },
                Visible = false
            };
        }

        private async void LoadHome()
        {
            contentPanel.Controls.Clear();

            HomeUserControl home = new HomeUserControl(CurrentUserId)
            {
                Dock = DockStyle.Fill
            };

            bool hasHouse = false;

            try
            {
                var response = await client.GetAsync($"api/houses/user/{CurrentUserId}");
                if (response.IsSuccessStatusCode)
                {
                    var houses = await response.Content.ReadFromJsonAsync<List<HouseResponse>>();
                    if (houses != null && houses.Count > 0)
                    {
                        hasHouse = true;
                        Button[] houseButtons = { btnElsoHaz, btnMasodikHaz, btnHarmadikHaz, btnNegyedikHaz };
                        for (int i = 0; i < houseButtons.Length; i++)
                        {
                            houseButtons[i].Visible = false;
                            houseButtons[i].Click -= HouseButton_Click;
                        }
                        for (int i = 0; i < houses.Count && i < houseButtons.Length; i++)
                        {
                            houseButtons[i].Text = houses[i].houseName;
                            houseButtons[i].Tag = houses[i].id;
                            houseButtons[i].Visible = true;
                            houseButtons[i].Click += HouseButton_Click;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to load houses.");
            }

            home.SetHouseState(hasHouse);

            home.HazLetrehozva += async (hazNev) =>
            {
                await SaveHouses(CurrentUserId, hazNev);
                await LoadHousesFromApi();
                LoadHome();
            };

            contentPanel.Controls.Add(home);
        }

        private void HouseButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            int houseId = Convert.ToInt32(btn.Tag);
            string houseName = btn.Text;

            OpenHouseControl(houseId, houseName);
        }

        private void OpenHouseControl(int houseId, string houseName)
        {
            contentPanel.Controls.Clear();


            FirstHouseControl control = new FirstHouseControl()
            {
                Dock = DockStyle.Fill
            };

            control.LoadHouseData(houseId, houseName);
            contentPanel.Controls.Add(control);
        }

        private async Task LoadHousesFromApi()
        {
            if (CurrentUserId == 0) return;

            try
            {
                var response = await client.GetAsync($"api/houses/user/{CurrentUserId}");
                if (!response.IsSuccessStatusCode) return;

                var houses = await response.Content.ReadFromJsonAsync<List<HouseResponse>>();
                if (houses == null) return;
            }
            catch
            {
                MessageBox.Show("Failed to load houses from server.");
            }
        }

        private async Task SaveHouses(int userId, string hazNev)
        {
            try
            {
                var payload = new { userId, houseName = hazNev, posX = 0f, posY = 0f };
                var response = await client.PostAsJsonAsync("api/houses", payload);
                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("House save failed:\n" + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Network or API error:\n" + ex.Message);
            }
        }

        private void LoadSettings()
        {
            contentPanel.Controls.Clear();
            SettingsUserControl settings = new SettingsUserControl { Dock = DockStyle.Fill };
            contentPanel.Controls.Add(settings);
            settings.OnDeleteProfileRequested += async () => { await DeleteProfile(); };
        }

        private void LogOut()
        {
            new LoginPage().Show();
            Hide();
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async Task DeleteProfile()
        {
            try
            {
                var response = await client.DeleteAsync($"api/auth/user/{CurrentUserId}");
                if (response.IsSuccessStatusCode)
                {
                    new LoginPage().Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Title_Click(object sender, EventArgs e) => LoadHome();
        private void btnLogOut_Click(object sender, EventArgs e) => LogOut();
        private void btnSettings_Click(object sender, EventArgs e) => LoadSettings();

        public class HouseResponse
        {
            public int id { get; set; }
            public int userId { get; set; }
            public string houseName { get; set; }
        }
    } 
}   // ez naon hosszu lett