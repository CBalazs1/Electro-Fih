namespace Electro_Fih
{
    partial class SettingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            profileDeletionButton = new Electro_Fih.RJControls.RJButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(661, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 53);
            label1.TabIndex = 1;
            label1.Text = "Beállitások";
            // 
            // profileDeletionButton
            // 
            profileDeletionButton.BackColor = Color.FromArgb(42, 14, 77);
            profileDeletionButton.BackgroundColor = Color.FromArgb(42, 14, 77);
            profileDeletionButton.BorderColor = Color.Red;
            profileDeletionButton.BorderRadius = 12;
            profileDeletionButton.BorderSize = 2;
            profileDeletionButton.FlatAppearance.BorderSize = 0;
            profileDeletionButton.FlatStyle = FlatStyle.Flat;
            profileDeletionButton.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileDeletionButton.ForeColor = Color.Red;
            profileDeletionButton.Location = new Point(890, 790);
            profileDeletionButton.Name = "profileDeletionButton";
            profileDeletionButton.Size = new Size(188, 50);
            profileDeletionButton.TabIndex = 2;
            profileDeletionButton.Text = "Fiók törlése";
            profileDeletionButton.TextColor = Color.Red;
            profileDeletionButton.UseVisualStyleBackColor = false;
            profileDeletionButton.Click += this.profileDeletionButton_Click;
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 14, 77);
            Controls.Add(profileDeletionButton);
            Controls.Add(label1);
            Name = "SettingsUserControl";
            Size = new Size(1081, 843);
            Load += SettingsUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RJControls.RJButton profileDeletionButton;
    }
}
