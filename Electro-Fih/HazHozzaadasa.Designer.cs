namespace Electro_Fih
{
    partial class HazHozzaadasa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HazHozzaadasa));
            hazNevMegadasa = new CustomControls.RJControls.RJTextBox();
            hazHozzaadasButton = new Electro_Fih.RJControls.RJButton();
            SuspendLayout();
            // 
            // hazNevMegadasa
            // 
            hazNevMegadasa.BackColor = Color.White;
            hazNevMegadasa.BorderColor = Color.FromArgb(42, 14, 77);
            hazNevMegadasa.BorderFocusColor = Color.FromArgb(42, 14, 77);
            hazNevMegadasa.BorderRadius = 12;
            hazNevMegadasa.BorderSize = 2;
            hazNevMegadasa.ForeColor = Color.FromArgb(42, 14, 77);
            hazNevMegadasa.Location = new Point(237, 223);
            hazNevMegadasa.Margin = new Padding(3, 4, 3, 4);
            hazNevMegadasa.Multiline = false;
            hazNevMegadasa.Name = "hazNevMegadasa";
            hazNevMegadasa.Padding = new Padding(10, 9, 10, 9);
            hazNevMegadasa.PasswordChar = false;
            hazNevMegadasa.PlaceholderColor = Color.DarkGray;
            hazNevMegadasa.PlaceholderText = "";
            hazNevMegadasa.Size = new Size(312, 39);
            hazNevMegadasa.TabIndex = 0;
            hazNevMegadasa.Texts = "";
            hazNevMegadasa.UnderlinedStyle = false;
            hazNevMegadasa._TextChanged += this.hazNevMegadasa_TextChanged;
            // 
            // hazHozzaadasButton
            // 
            hazHozzaadasButton.BackColor = Color.FromArgb(190, 68, 255);
            hazHozzaadasButton.BackgroundColor = Color.FromArgb(190, 68, 255);
            hazHozzaadasButton.BorderColor = Color.White;
            hazHozzaadasButton.BorderRadius = 12;
            hazHozzaadasButton.BorderSize = 2;
            hazHozzaadasButton.FlatAppearance.BorderSize = 0;
            hazHozzaadasButton.FlatStyle = FlatStyle.Flat;
            hazHozzaadasButton.ForeColor = Color.White;
            hazHozzaadasButton.Location = new Point(302, 307);
            hazHozzaadasButton.Name = "hazHozzaadasButton";
            hazHozzaadasButton.Size = new Size(188, 50);
            hazHozzaadasButton.TabIndex = 1;
            hazHozzaadasButton.Text = "Ház Hozzáadása";
            hazHozzaadasButton.TextColor = Color.White;
            hazHozzaadasButton.UseVisualStyleBackColor = false;
            hazHozzaadasButton.Click += this.rjButton1_Click;
            // 
            // HazHozzaadasa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 14, 77);
            ClientSize = new Size(808, 571);
            Controls.Add(hazHozzaadasButton);
            Controls.Add(hazNevMegadasa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HazHozzaadasa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Electro-Fih";
            Load += HarHozzaadasa_Load;
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RJControls.RJTextBox hazNevMegadasa;
        private RJControls.RJButton hazHozzaadasButton;
    }
}