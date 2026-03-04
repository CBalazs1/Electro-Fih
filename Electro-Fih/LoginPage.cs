using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electro_Fih
{
    public partial class LoginPage : Form
    {
        private readonly HttpClient client;

        public LoginPage()
        {
            InitializeComponent();

            client = new HttpClient
            {
                BaseAddress = new Uri("http://100.122.255.19:5229/")
            };
        }

        // ================= LOGIN RESPONSE MODEL =================
        public class LoginResponse
        {
            public int id { get; set; }
            public string email { get; set; }
        }

        // ================= LOGIN =================
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            string email = txtboxEmail.Text.Trim();
            string password = txtboxPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter email and password");
                return;
            }

            try
            {
                var loginData = new
                {
                    email = email,
                    password = password
                };

                string json = JsonConvert.SerializeObject(loginData);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response =
                    await client.PostAsync("api/auth/login", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var loginResult =
                        JsonConvert.DeserializeObject<LoginResponse>(responseBody);

                    MessageBox.Show("Sikeres bejelentkezés!");

                    MainPage mainForm = new MainPage();

                    mainForm.SetUserId(loginResult.id);

                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nem megegyező email vagy jelszó!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error:\n" + ex.Message);
            }
        }

        // ================= REGISTER =================
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtboxEmail.Text.Trim();
            string password = txtboxPassword.Text;

            var payload = new
            {
                email = email,
                password = password
            };

            string json = JsonConvert.SerializeObject(payload);

            using HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://100.122.255.19:5229/");

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response =
                await client.PostAsync("api/auth/register", content);
                

            string responseText = await response.Content.ReadAsStringAsync();

            MessageBox.Show(
                "Status: " + (int)response.StatusCode + "\n" +
                responseText
            );
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblEmail_Click(object sender, EventArgs e) { }

        private void loginPageLogo_Click(object sender, EventArgs e) { }
    }
}