namespace IkaLaskuri
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
            this.SyntymaAikaDT = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.IkaVuosi = new System.Windows.Forms.Label();
            this.IkaKuukausi = new System.Windows.Forms.Label();
            this.IkaPaiva = new System.Windows.Forms.Label();
            this.IkaTunti = new System.Windows.Forms.Label();
            this.IkaMinut = new System.Windows.Forms.Label();
            this.IkaSekunt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            this.SyntymaAikaDT.Location = new System.Drawing.Point(59, 42);
            this.SyntymaAikaDT.Name = "SyntymaAikaDT";
            this.SyntymaAikaDT.Size = new System.Drawing.Size(200, 23);
            this.SyntymaAikaDT.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Laske";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IkaVuosi
            // 
            this.IkaVuosi.AutoSize = true;
            this.IkaVuosi.Location = new System.Drawing.Point(81, 99);
            this.IkaVuosi.Name = "IkaVuosi";
            this.IkaVuosi.Size = new System.Drawing.Size(38, 15);
            this.IkaVuosi.TabIndex = 2;
            this.IkaVuosi.Text = "label1";
            this.IkaVuosi.Visible = false;
            // 
            // IkaKuukausi
            // 
            this.IkaKuukausi.AutoSize = true;
            this.IkaKuukausi.Location = new System.Drawing.Point(81, 129);
            this.IkaKuukausi.Name = "IkaKuukausi";
            this.IkaKuukausi.Size = new System.Drawing.Size(38, 15);
            this.IkaKuukausi.TabIndex = 3;
            this.IkaKuukausi.Text = "label1";
            this.IkaKuukausi.Visible = false;
            // 
            // IkaPaiva
            // 
            this.IkaPaiva.AutoSize = true;
            this.IkaPaiva.Location = new System.Drawing.Point(81, 162);
            this.IkaPaiva.Name = "IkaPaiva";
            this.IkaPaiva.Size = new System.Drawing.Size(38, 15);
            this.IkaPaiva.TabIndex = 4;
            this.IkaPaiva.Text = "label1";
            this.IkaPaiva.Visible = false;
            this.IkaPaiva.Click += new System.EventHandler(this.label2_Click);
            // 
            // IkaTunti
            // 
            this.IkaTunti.AutoSize = true;
            this.IkaTunti.Location = new System.Drawing.Point(221, 99);
            this.IkaTunti.Name = "IkaTunti";
            this.IkaTunti.Size = new System.Drawing.Size(38, 15);
            this.IkaTunti.TabIndex = 5;
            this.IkaTunti.Text = "label1";
            this.IkaTunti.Visible = false;
            // 
            // IkaMinut
            // 
            this.IkaMinut.AutoSize = true;
            this.IkaMinut.Location = new System.Drawing.Point(221, 129);
            this.IkaMinut.Name = "IkaMinut";
            this.IkaMinut.Size = new System.Drawing.Size(38, 15);
            this.IkaMinut.TabIndex = 6;
            this.IkaMinut.Text = "label1";
            this.IkaMinut.Visible = false;
            // 
            // IkaSekunt
            // 
            this.IkaSekunt.AutoSize = true;
            this.IkaSekunt.Location = new System.Drawing.Point(221, 162);
            this.IkaSekunt.Name = "IkaSekunt";
            this.IkaSekunt.Size = new System.Drawing.Size(38, 15);
            this.IkaSekunt.TabIndex = 7;
            this.IkaSekunt.Text = "label1";
            this.IkaSekunt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IkaSekunt);
            this.Controls.Add(this.IkaMinut);
            this.Controls.Add(this.IkaTunti);
            this.Controls.Add(this.IkaPaiva);
            this.Controls.Add(this.IkaKuukausi);
            this.Controls.Add(this.IkaVuosi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SyntymaAikaDT);
            this.Name = "Form1";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Button button1;
        private Label IkaVuosi;
        private Label IkaKuukausi;
        private Label IkaPaiva;
        private Label IkaTunti;
        private Label IkaMinut;
        private Label IkaSekunt;
    }
}