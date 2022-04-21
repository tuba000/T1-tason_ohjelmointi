namespace CtoF
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
            this.AsteLabel = new System.Windows.Forms.Label();
            this.AsteLuku = new System.Windows.Forms.TextBox();
            this.MuuntoBox = new System.Windows.Forms.GroupBox();
            this.Celsius = new System.Windows.Forms.RadioButton();
            this.Fahrenheit = new System.Windows.Forms.RadioButton();
            this.MuuntoBT = new System.Windows.Forms.Button();
            this.Vastaus = new System.Windows.Forms.Label();
            this.MuuntoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AsteLabel
            // 
            this.AsteLabel.AutoSize = true;
            this.AsteLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AsteLabel.Location = new System.Drawing.Point(116, 161);
            this.AsteLabel.Name = "AsteLabel";
            this.AsteLabel.Size = new System.Drawing.Size(145, 32);
            this.AsteLabel.TabIndex = 0;
            this.AsteLabel.Text = "Anna asteet:";
            // 
            // AsteLuku
            // 
            this.AsteLuku.Location = new System.Drawing.Point(293, 170);
            this.AsteLuku.Name = "AsteLuku";
            this.AsteLuku.Size = new System.Drawing.Size(100, 23);
            this.AsteLuku.TabIndex = 1;
            // 
            // MuuntoBox
            // 
            this.MuuntoBox.Controls.Add(this.Fahrenheit);
            this.MuuntoBox.Controls.Add(this.Celsius);
            this.MuuntoBox.Location = new System.Drawing.Point(477, 99);
            this.MuuntoBox.Name = "MuuntoBox";
            this.MuuntoBox.Size = new System.Drawing.Size(289, 184);
            this.MuuntoBox.TabIndex = 2;
            this.MuuntoBox.TabStop = false;
            this.MuuntoBox.Text = "Miten muunnat?";
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(25, 49);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(62, 19);
            this.Celsius.TabIndex = 0;
            this.Celsius.TabStop = true;
            this.Celsius.Text = "Celsius";
            this.Celsius.UseVisualStyleBackColor = true;
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.Location = new System.Drawing.Point(25, 113);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(81, 19);
            this.Fahrenheit.TabIndex = 1;
            this.Fahrenheit.TabStop = true;
            this.Fahrenheit.Text = "Fahrenheit";
            this.Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // MuuntoBT
            // 
            this.MuuntoBT.Location = new System.Drawing.Point(814, 134);
            this.MuuntoBT.Name = "MuuntoBT";
            this.MuuntoBT.Size = new System.Drawing.Size(185, 97);
            this.MuuntoBT.TabIndex = 3;
            this.MuuntoBT.Text = "Muunna";
            this.MuuntoBT.UseVisualStyleBackColor = true;
            this.MuuntoBT.Click += new System.EventHandler(this.MuuntoBT_Click);
            // 
            // Vastaus
            // 
            this.Vastaus.AutoSize = true;
            this.Vastaus.Location = new System.Drawing.Point(165, 318);
            this.Vastaus.Name = "Vastaus";
            this.Vastaus.Size = new System.Drawing.Size(46, 15);
            this.Vastaus.TabIndex = 4;
            this.Vastaus.Text = "Vastaus";
            this.Vastaus.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 592);
            this.Controls.Add(this.Vastaus);
            this.Controls.Add(this.MuuntoBT);
            this.Controls.Add(this.MuuntoBox);
            this.Controls.Add(this.AsteLuku);
            this.Controls.Add(this.AsteLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MuuntoBox.ResumeLayout(false);
            this.MuuntoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AsteLabel;
        private TextBox AsteLuku;
        private GroupBox MuuntoBox;
        private RadioButton Fahrenheit;
        private RadioButton Celsius;
        private Button MuuntoBT;
        private Label Vastaus;
    }
}