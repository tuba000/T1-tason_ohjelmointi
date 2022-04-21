namespace Kysymyksiä
{
    partial class Vastaus
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.Boxi = new System.Windows.Forms.GroupBox();
            this.RadioN = new System.Windows.Forms.RadioButton();
            this.KolmasV = new System.Windows.Forms.RadioButton();
            this.TokaV = new System.Windows.Forms.RadioButton();
            this.NelkkuV = new System.Windows.Forms.RadioButton();
            this.EkaV = new System.Windows.Forms.RadioButton();
            this.Boxi.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(43, 61);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(67, 15);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Kysymys 1: ";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(52, 220);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(46, 15);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Boxi
            // 
            this.Boxi.Controls.Add(this.EkaV);
            this.Boxi.Controls.Add(this.RadioN);
            this.Boxi.Controls.Add(this.KolmasV);
            this.Boxi.Controls.Add(this.TokaV);
            this.Boxi.Controls.Add(this.NelkkuV);
            this.Boxi.Location = new System.Drawing.Point(217, 61);
            this.Boxi.Name = "Boxi";
            this.Boxi.Size = new System.Drawing.Size(97, 126);
            this.Boxi.TabIndex = 2;
            this.Boxi.TabStop = false;
            this.Boxi.Text = "Vastaus";
            // 
            // RadioN
            // 
            this.RadioN.AutoCheck = false;
            this.RadioN.AutoSize = true;
            this.RadioN.Location = new System.Drawing.Point(58, 24);
            this.RadioN.Name = "RadioN";
            this.RadioN.Size = new System.Drawing.Size(32, 19);
            this.RadioN.TabIndex = 4;
            this.RadioN.TabStop = true;
            this.RadioN.Text = "Y";
            this.RadioN.UseVisualStyleBackColor = true;
            this.RadioN.Visible = false;
            // 
            // KolmasV
            // 
            this.KolmasV.AutoSize = true;
            this.KolmasV.Location = new System.Drawing.Point(5, 74);
            this.KolmasV.Name = "KolmasV";
            this.KolmasV.Size = new System.Drawing.Size(33, 19);
            this.KolmasV.TabIndex = 2;
            this.KolmasV.TabStop = true;
            this.KolmasV.Text = "C";
            this.KolmasV.UseVisualStyleBackColor = true;
            // 
            // TokaV
            // 
            this.TokaV.AutoSize = true;
            this.TokaV.Location = new System.Drawing.Point(5, 49);
            this.TokaV.Name = "TokaV";
            this.TokaV.Size = new System.Drawing.Size(32, 19);
            this.TokaV.TabIndex = 1;
            this.TokaV.TabStop = true;
            this.TokaV.Text = "B";
            this.TokaV.UseVisualStyleBackColor = true;
            // 
            // NelkkuV
            // 
            this.NelkkuV.AutoSize = true;
            this.NelkkuV.Location = new System.Drawing.Point(5, 99);
            this.NelkkuV.Name = "NelkkuV";
            this.NelkkuV.Size = new System.Drawing.Size(33, 19);
            this.NelkkuV.TabIndex = 3;
            this.NelkkuV.TabStop = true;
            this.NelkkuV.Text = "D";
            this.NelkkuV.UseVisualStyleBackColor = true;
            // 
            // EkaV
            // 
            this.EkaV.AutoSize = true;
            this.EkaV.Location = new System.Drawing.Point(6, 24);
            this.EkaV.Name = "EkaV";
            this.EkaV.Size = new System.Drawing.Size(33, 19);
            this.EkaV.TabIndex = 5;
            this.EkaV.TabStop = true;
            this.EkaV.Text = "A";
            this.EkaV.UseVisualStyleBackColor = true;
            // 
            // Vastaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 308);
            this.Controls.Add(this.Boxi);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Name = "Vastaus";
            this.Text = "Vastaus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Boxi.ResumeLayout(false);
            this.Boxi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KysymysLB;
        private Label VastausLB;
        private GroupBox Boxi;
        private RadioButton NelkkuV;
        private RadioButton KolmasV;
        private RadioButton TokaV;
        private RadioButton RadioN;
        private RadioButton EkaV;
    }
}