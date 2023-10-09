namespace WinFormPractics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            baku_button = new Button();
            london_button = new Button();
            pictureBox1 = new PictureBox();
            time_clock = new Label();
            city = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // baku_button
            // 
            baku_button.BackColor = SystemColors.MenuHighlight;
            baku_button.ForeColor = Color.Red;
            baku_button.Location = new Point(276, 383);
            baku_button.Name = "baku_button";
            baku_button.Size = new Size(103, 55);
            baku_button.TabIndex = 0;
            baku_button.Text = "Baku";
            baku_button.UseVisualStyleBackColor = false;
            baku_button.Click += button_baku_Click;
            // 
            // london_button
            // 
            london_button.BackColor = SystemColors.MenuHighlight;
            london_button.ForeColor = Color.Red;
            london_button.Location = new Point(423, 383);
            london_button.Name = "london_button";
            london_button.Size = new Size(103, 55);
            london_button.TabIndex = 1;
            london_button.Text = "London";
            london_button.UseVisualStyleBackColor = false;
            london_button.Click += london_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = time.Properties.Resources.bakuu;
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // time_clock
            // 
            time_clock.AutoSize = true;
            time_clock.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            time_clock.Location = new Point(526, 145);
            time_clock.Name = "time_clock";
            time_clock.Size = new Size(0, 32);
            time_clock.TabIndex = 3;
            // 
            // city
            // 
            city.AutoSize = true;
            city.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            city.ForeColor = Color.OrangeRed;
            city.Location = new Point(464, 60);
            city.Name = "city";
            city.Size = new Size(0, 28);
            city.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 450);
            Controls.Add(city);
            Controls.Add(time_clock);
            Controls.Add(pictureBox1);
            Controls.Add(london_button);
            Controls.Add(baku_button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button baku_button;
        private Button london_button;
        private PictureBox pictureBox1;
        private Label time_clock;
        private Label city;
    }
}