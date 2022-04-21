namespace BMI
{
    partial class Laskuri
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
            this.PainoLB = new System.Windows.Forms.Label();
            this.PituusLB = new System.Windows.Forms.Label();
            this.Paino = new System.Windows.Forms.TextBox();
            this.Pituus = new System.Windows.Forms.TextBox();
            this.Laske = new System.Windows.Forms.Button();
            this.Vastaus = new System.Windows.Forms.Label();
            this.Lisaa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PainoLB
            // 
            this.PainoLB.AutoSize = true;
            this.PainoLB.Location = new System.Drawing.Point(37, 75);
            this.PainoLB.Name = "PainoLB";
            this.PainoLB.Size = new System.Drawing.Size(71, 15);
            this.PainoLB.TabIndex = 0;
            this.PainoLB.Text = "Anna paino:";
            // 
            // PituusLB
            // 
            this.PituusLB.AutoSize = true;
            this.PituusLB.Location = new System.Drawing.Point(34, 123);
            this.PituusLB.Name = "PituusLB";
            this.PituusLB.Size = new System.Drawing.Size(74, 15);
            this.PituusLB.TabIndex = 1;
            this.PituusLB.Text = "Anna pituus:";
            // 
            // Paino
            // 
            this.Paino.Location = new System.Drawing.Point(134, 72);
            this.Paino.Name = "Paino";
            this.Paino.Size = new System.Drawing.Size(100, 23);
            this.Paino.TabIndex = 2;
            // 
            // Pituus
            // 
            this.Pituus.Location = new System.Drawing.Point(134, 115);
            this.Pituus.Name = "Pituus";
            this.Pituus.Size = new System.Drawing.Size(100, 23);
            this.Pituus.TabIndex = 3;
            // 
            // Laske
            // 
            this.Laske.Location = new System.Drawing.Point(37, 167);
            this.Laske.Name = "Laske";
            this.Laske.Size = new System.Drawing.Size(197, 34);
            this.Laske.TabIndex = 4;
            this.Laske.Text = "Laske painoindeksi";
            this.Laske.UseVisualStyleBackColor = true;
            this.Laske.Click += new System.EventHandler(this.Laske_Click);
            // 
            // Vastaus
            // 
            this.Vastaus.AutoSize = true;
            this.Vastaus.Location = new System.Drawing.Point(37, 223);
            this.Vastaus.Name = "Vastaus";
            this.Vastaus.Size = new System.Drawing.Size(38, 15);
            this.Vastaus.TabIndex = 5;
            this.Vastaus.Text = "label1";
            this.Vastaus.Visible = false;
            // 
            // Lisaa
            // 
            this.Lisaa.AutoSize = true;
            this.Lisaa.Location = new System.Drawing.Point(37, 248);
            this.Lisaa.Name = "Lisaa";
            this.Lisaa.Size = new System.Drawing.Size(38, 15);
            this.Lisaa.TabIndex = 6;
            this.Lisaa.Text = "label1";
            this.Lisaa.Visible = false;
            // 
            // Laskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 283);
            this.Controls.Add(this.Lisaa);
            this.Controls.Add(this.Vastaus);
            this.Controls.Add(this.Laske);
            this.Controls.Add(this.Pituus);
            this.Controls.Add(this.Paino);
            this.Controls.Add(this.PituusLB);
            this.Controls.Add(this.PainoLB);
            this.Name = "Laskuri";
            this.Text = "BMI-Laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PainoLB;
        private Label PituusLB;
        private TextBox Paino;
        private TextBox Pituus;
        private Button Laske;
        private Label Vastaus;
        private Label Lisaa;
    }
}