namespace RiippuvaValikko
{
    partial class Pudotusvalikko
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
            this.KouluLB = new System.Windows.Forms.Label();
            this.OpeLB = new System.Windows.Forms.Label();
            this.KouluCB = new System.Windows.Forms.ComboBox();
            this.OpeCB = new System.Windows.Forms.ComboBox();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PnLB = new System.Windows.Forms.Label();
            this.KaupunkiLB = new System.Windows.Forms.Label();
            this.KouPuhLB = new System.Windows.Forms.Label();
            this.VirkaLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.SpLB = new System.Windows.Forms.Label();
            this.NumeroLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Otsikko
            // 
            this.Otsikko.AutoSize = true;
            this.Otsikko.Location = new System.Drawing.Point(13, 9);
            this.Otsikko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Otsikko.Name = "Otsikko";
            this.Otsikko.Size = new System.Drawing.Size(816, 86);
            this.Otsikko.TabIndex = 0;
            this.Otsikko.Text = "Oppilaitosten avainhenkilöt";
            // 
            // KouluLB
            // 
            this.KouluLB.AutoSize = true;
            this.KouluLB.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KouluLB.Location = new System.Drawing.Point(13, 95);
            this.KouluLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KouluLB.Name = "KouluLB";
            this.KouluLB.Size = new System.Drawing.Size(308, 50);
            this.KouluLB.TabIndex = 1;
            this.KouluLB.Text = "Valitse oppilaitos:";
            // 
            // OpeLB
            // 
            this.OpeLB.AutoSize = true;
            this.OpeLB.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpeLB.Location = new System.Drawing.Point(438, 95);
            this.OpeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpeLB.Name = "OpeLB";
            this.OpeLB.Size = new System.Drawing.Size(372, 50);
            this.OpeLB.TabIndex = 2;
            this.OpeLB.Text = "Valitse vastuuhenkilö:";
            // 
            // KouluCB
            // 
            this.KouluCB.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KouluCB.FormattingEnabled = true;
            this.KouluCB.Location = new System.Drawing.Point(13, 148);
            this.KouluCB.Margin = new System.Windows.Forms.Padding(4);
            this.KouluCB.Name = "KouluCB";
            this.KouluCB.Size = new System.Drawing.Size(308, 55);
            this.KouluCB.TabIndex = 3;
            this.KouluCB.SelectedIndexChanged += new System.EventHandler(this.KouluCB_SelectedIndexChanged);
            // 
            // OpeCB
            // 
            this.OpeCB.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpeCB.FormattingEnabled = true;
            this.OpeCB.Location = new System.Drawing.Point(438, 148);
            this.OpeCB.Margin = new System.Windows.Forms.Padding(4);
            this.OpeCB.Name = "OpeCB";
            this.OpeCB.Size = new System.Drawing.Size(372, 55);
            this.OpeCB.TabIndex = 4;
            this.OpeCB.SelectedIndexChanged += new System.EventHandler(this.OpeCB_SelectedIndexChanged);
            this.OpeCB.TextChanged += new System.EventHandler(this.OpeCB_TextChanged);
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OsoiteLB.Location = new System.Drawing.Point(12, 231);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(113, 45);
            this.OsoiteLB.TabIndex = 5;
            this.OsoiteLB.Text = "Osoite";
            // 
            // PnLB
            // 
            this.PnLB.AutoSize = true;
            this.PnLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PnLB.Location = new System.Drawing.Point(13, 276);
            this.PnLB.Name = "PnLB";
            this.PnLB.Size = new System.Drawing.Size(200, 45);
            this.PnLB.TabIndex = 6;
            this.PnLB.Text = "Postinumero";
            // 
            // KaupunkiLB
            // 
            this.KaupunkiLB.AutoSize = true;
            this.KaupunkiLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KaupunkiLB.Location = new System.Drawing.Point(13, 321);
            this.KaupunkiLB.Name = "KaupunkiLB";
            this.KaupunkiLB.Size = new System.Drawing.Size(152, 45);
            this.KaupunkiLB.TabIndex = 7;
            this.KaupunkiLB.Text = "Kaupunki";
            // 
            // KouPuhLB
            // 
            this.KouPuhLB.AutoSize = true;
            this.KouPuhLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KouPuhLB.Location = new System.Drawing.Point(13, 366);
            this.KouPuhLB.Name = "KouPuhLB";
            this.KouPuhLB.Size = new System.Drawing.Size(236, 45);
            this.KouPuhLB.TabIndex = 8;
            this.KouPuhLB.Text = "Puhelinnumero";
            // 
            // VirkaLB
            // 
            this.VirkaLB.AutoSize = true;
            this.VirkaLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VirkaLB.Location = new System.Drawing.Point(438, 231);
            this.VirkaLB.Name = "VirkaLB";
            this.VirkaLB.Size = new System.Drawing.Size(100, 45);
            this.VirkaLB.TabIndex = 9;
            this.VirkaLB.Text = "Titteli";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OsastoLB.Location = new System.Drawing.Point(438, 276);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(118, 45);
            this.OsastoLB.TabIndex = 10;
            this.OsastoLB.Text = "Osasto";
            // 
            // SpLB
            // 
            this.SpLB.AutoSize = true;
            this.SpLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpLB.Location = new System.Drawing.Point(438, 321);
            this.SpLB.Name = "SpLB";
            this.SpLB.Size = new System.Drawing.Size(177, 45);
            this.SpLB.TabIndex = 11;
            this.SpLB.Text = "Sähköposti";
            // 
            // NumeroLB
            // 
            this.NumeroLB.AutoSize = true;
            this.NumeroLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumeroLB.Location = new System.Drawing.Point(438, 366);
            this.NumeroLB.Name = "NumeroLB";
            this.NumeroLB.Size = new System.Drawing.Size(236, 45);
            this.NumeroLB.TabIndex = 12;
            this.NumeroLB.Text = "Puhelinnumero";
            // 
            // Pudotusvalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(35F, 86F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 545);
            this.Controls.Add(this.NumeroLB);
            this.Controls.Add(this.SpLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.VirkaLB);
            this.Controls.Add(this.KouPuhLB);
            this.Controls.Add(this.KaupunkiLB);
            this.Controls.Add(this.PnLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.OpeCB);
            this.Controls.Add(this.KouluCB);
            this.Controls.Add(this.OpeLB);
            this.Controls.Add(this.KouluLB);
            this.Controls.Add(this.Otsikko);
            this.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Name = "Pudotusvalikko";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.Pudotusvalikko_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Otsikko;
        private Label KouluLB;
        private Label OpeLB;
        private ComboBox KouluCB;
        private ComboBox OpeCB;
        private Label OsoiteLB;
        private Label PnLB;
        private Label KaupunkiLB;
        private Label KouPuhLB;
        private Label VirkaLB;
        private Label OsastoLB;
        private Label SpLB;
        private Label NumeroLB;
    }
}