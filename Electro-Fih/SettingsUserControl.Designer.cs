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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUserControl));
            label1 = new Label();
            profileDeletionButton = new Electro_Fih.RJControls.RJButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(617, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 52);
            label1.TabIndex = 1;
            label1.Text = "Beállitások";
            // 
            // profileDeletionButton
            // 
            profileDeletionButton.BackColor = Color.FromArgb(192, 0, 0);
            profileDeletionButton.BackgroundColor = Color.FromArgb(192, 0, 0);
            profileDeletionButton.BorderColor = Color.White;
            profileDeletionButton.BorderRadius = 12;
            profileDeletionButton.BorderSize = 2;
            profileDeletionButton.Cursor = Cursors.Hand;
            profileDeletionButton.FlatAppearance.BorderSize = 0;
            profileDeletionButton.FlatStyle = FlatStyle.Flat;
            profileDeletionButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileDeletionButton.ForeColor = Color.White;
            profileDeletionButton.Location = new Point(617, 744);
            profileDeletionButton.Name = "profileDeletionButton";
            profileDeletionButton.Size = new Size(244, 50);
            profileDeletionButton.TabIndex = 2;
            profileDeletionButton.Text = "Fiók törlése";
            profileDeletionButton.TextColor = Color.White;
            profileDeletionButton.UseVisualStyleBackColor = false;
            profileDeletionButton.Click += profileDeletionButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(472, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(526, 752);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 14, 77);
            Controls.Add(profileDeletionButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SettingsUserControl";
            Size = new Size(1638, 843);
            Load += SettingsUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RJControls.RJButton profileDeletionButton;
        private PictureBox pictureBox1;
    }
}
