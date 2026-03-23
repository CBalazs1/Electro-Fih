namespace Electro_Fih
{
    partial class HomeUserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            label1 = new Label();
            elsoHaz = new Panel();
            elsoHazLabel = new Label();
            elsoHazButton = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            elsoHaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)elsoHazButton).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 25.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(617, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 51);
            label1.TabIndex = 4;
            label1.Text = "Home";
            // 
            // elsoHaz
            // 
            elsoHaz.Controls.Add(elsoHazLabel);
            elsoHaz.Controls.Add(elsoHazButton);
            elsoHaz.Location = new Point(18, 108);
            elsoHaz.Name = "elsoHaz";
            elsoHaz.Size = new Size(450, 298);
            elsoHaz.TabIndex = 3;
            // 
            // elsoHazLabel
            // 
            elsoHazLabel.AutoSize = true;
            elsoHazLabel.Font = new Font("SF Mono", 16.2F, FontStyle.Bold);
            elsoHazLabel.ForeColor = Color.White;
            elsoHazLabel.Location = new Point(97, 39);
            elsoHazLabel.Name = "elsoHazLabel";
            elsoHazLabel.Size = new Size(236, 33);
            elsoHazLabel.TabIndex = 0;
            elsoHazLabel.Text = "Ház Hozzáadás";
            // 
            // elsoHazButton
            // 
            elsoHazButton.Cursor = Cursors.Hand;
            elsoHazButton.Image = (Image)resources.GetObject("elsoHazButton.Image");
            elsoHazButton.Location = new Point(186, 102);
            elsoHazButton.Name = "elsoHazButton";
            elsoHazButton.Size = new Size(65, 64);
            elsoHazButton.SizeMode = PictureBoxSizeMode.StretchImage;
            elsoHazButton.TabIndex = 1;
            elsoHazButton.TabStop = false;
            elsoHazButton.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(18, 500);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 298);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(97, 39);
            label3.Name = "label3";
            label3.Size = new Size(236, 33);
            label3.TabIndex = 0;
            label3.Text = "Ház Hozzáadás";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(186, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(897, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 298);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Mono", 16.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(97, 39);
            label5.Name = "label5";
            label5.Size = new Size(236, 33);
            label5.TabIndex = 0;
            label5.Text = "Ház Hozzáadás";
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(186, 102);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(897, 500);
            panel5.Name = "panel5";
            panel5.Size = new Size(450, 298);
            panel5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SF Mono", 16.2F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(97, 39);
            label6.Name = "label6";
            label6.Size = new Size(236, 33);
            label6.TabIndex = 0;
            label6.Text = "Ház Hozzáadás";
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(186, 102);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(65, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox1_Click;
            // 
            // HomeUserControl
            // 
            BackColor = Color.FromArgb(42, 14, 77);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(elsoHaz);
            Controls.Add(label1);
            Name = "HomeUserControl";
            Size = new Size(1638, 843);
            elsoHaz.ResumeLayout(false);
            elsoHaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)elsoHazButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Panel elsoHaz;
        private PictureBox elsoHazButton;
        private Label elsoHazLabel;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label label5;
        private PictureBox pictureBox4;
        private Panel panel5;
        private Label label6;
        private PictureBox pictureBox5;
    }
}