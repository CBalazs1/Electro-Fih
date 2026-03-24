using Electro_Fih.RJControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electro_Fih
{
    public partial class FirstHouseControl : UserControl
    {
        private HttpClient client;

        private ComboBox searchCombo;
        private Button searchButton;
        private Button addButton;
        private DataGridView selectedGrid;
        private Label totalLabel;
        private Label kwhLabel;
        private Label costLabel;

        private DataTable selectedTable;
        private double totalWattage = 0;

        private List<ApplianceResponse> currentResults = new();
        private int localIdCounter = 1;

        private int currentHouseId;

        // TODO: Replace this with actual logged-in user ID
        private int currentUserId = 1;

        public FirstHouseControl()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("http://100.122.255.19:5229/")
            };

            SetupUI();
        }

        public void LoadHouseData(int houseId, string houseName)
        {
            currentHouseId = houseId;
            LoadHouseAppliancesFromServer();
        }

        private void SetupUI()
        {
            searchCombo = new ComboBox
            {
                Width = 350,
                Left = 20,
                Top = 20,
                DropDownStyle = ComboBoxStyle.DropDown
            };

            searchButton = new RJButton
            {
                Text = "Keresés",
                Left = 380,
                Top = 20,
                Width = 100,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                BackgroundColor = Color.FromArgb(108, 38, 217),
                BorderRadius = 15,
                BorderSize = 2,
                BorderColor = Color.White
            };
            searchButton.Click += async (s, e) =>
            {
                await SearchAppliance(searchCombo.Text);
            };

            addButton = new RJButton
            {
                Text = "Hozzáadás",
                Left = 500,
                Top = 20,
                Width = 150,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                BackgroundColor = Color.FromArgb(108, 38, 217),
                BorderRadius = 15,
                BorderSize = 2,
                BorderColor = Color.White
            };
            addButton.Click += AddButton_Click;

            selectedGrid = new DataGridView
            {
                Top = 70,
                Left = 20,
                Width = 630,
                Height = 400,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToDeleteRows = true,
                BackgroundColor = Color.FromArgb(42, 14, 77),
                BorderStyle = BorderStyle.None,
                ForeColor = Color.White,
                GridColor = Color.White
            };

            selectedGrid.DefaultCellStyle.BackColor = Color.FromArgb(42, 14, 77);

            totalLabel = new Label
            {
                Text = "Total Wattage: 0 W",
                Top = 490,
                Left = 20,
                Width = 300,
                ForeColor = Color.White,
                Font = new Font("SF Mono", 11)
            };

            kwhLabel = new Label
            {
                Text = "Estimated kWh: 0",
                Top = 520,
                Left = 20,
                Width = 300,
                ForeColor = Color.White,
                Font = new Font("SF Mono", 10)
            };

            costLabel = new Label
            {
                Text = "Estimated cost: 0 HUF",
                Top = 550,
                Left = 20,
                Width = 300,
                ForeColor = Color.White,
                Font = new Font("SF Mono", 10)
            };

            selectedTable = new DataTable();
            selectedTable.Columns.Add("ID");
            selectedTable.Columns.Add("Appliance");
            selectedTable.Columns.Add("Wattage");
            selectedGrid.DataSource = selectedTable;

            selectedGrid.UserDeletingRow += SelectedGrid_UserDeletingRow;

            Controls.Add(searchCombo);
            Controls.Add(searchButton);
            Controls.Add(addButton);
            Controls.Add(selectedGrid);
            Controls.Add(totalLabel);
            Controls.Add(kwhLabel);
            Controls.Add(costLabel);
        }

        private async Task SearchAppliance(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return;

            try
            {
                var response = await client.GetAsync(
                    $"api/appliances/search?keyword={Uri.EscapeDataString(keyword)}");

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Search failed.");
                    return;
                }

                var list = await response.Content.ReadFromJsonAsync<List<ApplianceResponse>>();

                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("No results.");
                    return;
                }

                currentResults = list;

                searchCombo.DataSource = null;
                searchCombo.DataSource = currentResults;
                searchCombo.DisplayMember = "appliance_name";
                searchCombo.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SEARCH ERROR: " + ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ApplianceResponse appliance = searchCombo.SelectedItem as ApplianceResponse;

            if (appliance == null)
            {
                string typed = searchCombo.Text.Trim();

                foreach (var item in currentResults)
                {
                    if (item.appliance_name.Equals(
                        typed,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        appliance = item;
                        break;
                    }
                }
            }

            if (appliance == null)
            {
                MessageBox.Show("Select a valid appliance.");
                return;
            }

            selectedTable.Rows.Add(localIdCounter++, appliance.appliance_name, appliance.wattage);
            totalWattage += appliance.wattage;

            UpdateTotal();

            _ = SaveSingleApplianceToServer(appliance);
        }

        private void SelectedGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            double watt = Convert.ToDouble(e.Row.Cells["Wattage"].Value);
            totalWattage -= watt;

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            totalLabel.Text = $"Energia használat: {totalWattage} W";

            double kwh = totalWattage / 1000.0;
            kwhLabel.Text = $"Estimated kWh: {kwh:F2}";

            double cost = kwh * 70;
            costLabel.Text = $"Estimated cost: {cost:F0} HUF";
        }

        private async void LoadHouseAppliancesFromServer()
        {
            if (currentHouseId == 0) return;

            try
            {
                var response = await client.GetAsync($"api/house/{currentHouseId}/appliances");

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Load failed.");
                    return;
                }

                var list = await response.Content.ReadFromJsonAsync<List<ApplianceResponse>>();

                if (list == null) return;

                selectedTable.Rows.Clear();
                totalWattage = 0;
                localIdCounter = 1;

                foreach (var a in list)
                {
                    selectedTable.Rows.Add(localIdCounter++, a.appliance_name, a.wattage);
                    totalWattage += a.wattage;
                }

                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOAD ERROR: " + ex.Message);
            }
        }

        private async Task SaveSingleApplianceToServer(ApplianceResponse appliance)
        {
            if (currentHouseId == 0) return;

            var request = new ApplianceRequest
            {
                ApplianceName = appliance.appliance_name,
                Wattage = appliance.wattage,
                UserId = currentUserId,   
                HouseId = currentHouseId   
            };

            try
            {
                var response = await client.PostAsJsonAsync(
                    $"api/house/{currentHouseId}/appliances",
                    request);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Save failed: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SAVE ERROR: " + ex.Message);
            }
        }

        public class ApplianceResponse
        {
            public string id { get; set; }
            public string appliance_name { get; set; }
            public double wattage { get; set; }
        }

        public class ApplianceRequest
        {
            public string ApplianceName { get; set; }
            public double Wattage { get; set; }
            public int UserId { get; set; }
            public int HouseId { get; set; }
        }
    }
}