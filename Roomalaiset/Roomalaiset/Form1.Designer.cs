namespace Roomalaiset
{
    partial class Roomalaiset
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
            this.AnnaNumero = new System.Windows.Forms.Label();
            this.Muutettava = new System.Windows.Forms.TextBox();
            this.Muuta = new System.Windows.Forms.Button();
            this.Muutettu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Otsikko
            // 
            this.Otsikko.AutoSize = true;
            this.Otsikko.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Otsikko.Location = new System.Drawing.Point(161, 9);
            this.Otsikko.Name = "Otsikko";
            this.Otsikko.Size = new System.Drawing.Size(644, 86);
            this.Otsikko.TabIndex = 0;
            this.Otsikko.Text = "Roomalaiset numerot";
            // 
            // AnnaNumero
            // 
            this.AnnaNumero.AutoSize = true;
            this.AnnaNumero.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnnaNumero.Location = new System.Drawing.Point(12, 175);
            this.AnnaNumero.Name = "AnnaNumero";
            this.AnnaNumero.Size = new System.Drawing.Size(758, 30);
            this.AnnaNumero.TabIndex = 1;
            this.AnnaNumero.Text = "Anna numero välillä 1-3999, niin muutan sen roomalaiseksi:";
            // 
            // Muutettava
            // 
            this.Muutettava.Location = new System.Drawing.Point(776, 182);
            this.Muutettava.Name = "Muutettava";
            this.Muutettava.Size = new System.Drawing.Size(144, 23);
            this.Muutettava.TabIndex = 2;
            // 
            // Muuta
            // 
            this.Muuta.Location = new System.Drawing.Point(805, 246);
            this.Muuta.Name = "Muuta";
            this.Muuta.Size = new System.Drawing.Size(75, 23);
            this.Muuta.TabIndex = 3;
            this.Muuta.Text = "Muuta";
            this.Muuta.UseVisualStyleBackColor = true;
            this.Muuta.Click += new System.EventHandler(this.Muuta_Click);
            // 
            // Muutettu
            // 
            this.Muutettu.AutoSize = true;
            this.Muutettu.Font = new System.Drawing.Font("Sitka Text", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Muutettu.Location = new System.Drawing.Point(24, 274);
            this.Muutettu.Name = "Muutettu";
            this.Muutettu.Size = new System.Drawing.Size(681, 92);
            this.Muutettu.TabIndex = 4;
            this.Muutettu.Text = "Roomalainen numero";
            // 
            // Roomalaiset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 634);
            this.Controls.Add(this.Muutettu);
            this.Controls.Add(this.Muuta);
            this.Controls.Add(this.Muutettava);
            this.Controls.Add(this.AnnaNumero);
            this.Controls.Add(this.Otsikko);
            this.Name = "Roomalaiset";
            this.Text = "Numeroiden muutos latinalaisista roomalaisiksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Otsikko;
        private Label AnnaNumero;
        private TextBox Muutettava;
        private Button Muuta;
        private Label Muutettu;
    }
}