namespace Noppa
{
    partial class Nopat
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
            this.Otsikko = new System.Windows.Forms.Label();
            this.Heita = new System.Windows.Forms.Button();
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Otsikko
            // 
            this.Otsikko.AutoSize = true;
            this.Otsikko.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Otsikko.Location = new System.Drawing.Point(227, 9);
            this.Otsikko.Name = "Otsikko";
            this.Otsikko.Size = new System.Drawing.Size(311, 65);
            this.Otsikko.TabIndex = 0;
            this.Otsikko.Text = "Heitä noppaa";
            // 
            // Heita
            // 
            this.Heita.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Heita.Location = new System.Drawing.Point(286, 362);
            this.Heita.Name = "Heita";
            this.Heita.Size = new System.Drawing.Size(197, 68);
            this.Heita.TabIndex = 1;
            this.Heita.Text = "Heitä!";
            this.Heita.UseVisualStyleBackColor = true;
            this.Heita.Click += new System.EventHandler(this.Heita_Click);
            // 
            // noppa01PB
            // 
            this.noppa01PB.Image = global::Noppa.Properties.Resources.dice01;
            this.noppa01PB.Location = new System.Drawing.Point(118, 130);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(191, 176);
            this.noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa01PB.TabIndex = 2;
            this.noppa01PB.TabStop = false;
            this.noppa01PB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // noppa02PB
            // 
            this.noppa02PB.Image = global::Noppa.Properties.Resources.dice01;
            this.noppa02PB.Location = new System.Drawing.Point(439, 130);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(191, 176);
            this.noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa02PB.TabIndex = 3;
            this.noppa02PB.TabStop = false;
            // 
            // Nopat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 574);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Controls.Add(this.Heita);
            this.Controls.Add(this.Otsikko);
            this.Name = "Nopat";
            this.Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Otsikko;
        private Button Heita;
        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private HelpProvider helpProvider1;
    }
}