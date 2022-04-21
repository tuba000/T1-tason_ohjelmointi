namespace Ajastin
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
            this.components = new System.ComponentModel.Container();
            this.MinLB = new System.Windows.Forms.Label();
            this.SekLB = new System.Windows.Forms.Label();
            this.MinuteV = new System.Windows.Forms.ComboBox();
            this.SekuntiV = new System.Windows.Forms.ComboBox();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.AikaLB = new System.Windows.Forms.Label();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MinLB
            // 
            this.MinLB.AutoSize = true;
            this.MinLB.Location = new System.Drawing.Point(12, 9);
            this.MinLB.Name = "MinLB";
            this.MinLB.Size = new System.Drawing.Size(292, 86);
            this.MinLB.TabIndex = 0;
            this.MinLB.Text = "Minuutit:";
            // 
            // SekLB
            // 
            this.SekLB.AutoSize = true;
            this.SekLB.Location = new System.Drawing.Point(319, 9);
            this.SekLB.Name = "SekLB";
            this.SekLB.Size = new System.Drawing.Size(296, 86);
            this.SekLB.TabIndex = 1;
            this.SekLB.Text = "Sekunnit:";
            // 
            // MinuteV
            // 
            this.MinuteV.FormattingEnabled = true;
            this.MinuteV.Location = new System.Drawing.Point(12, 98);
            this.MinuteV.Name = "MinuteV";
            this.MinuteV.Size = new System.Drawing.Size(292, 94);
            this.MinuteV.TabIndex = 2;
            // 
            // SekuntiV
            // 
            this.SekuntiV.FormattingEnabled = true;
            this.SekuntiV.Location = new System.Drawing.Point(319, 98);
            this.SekuntiV.Name = "SekuntiV";
            this.SekuntiV.Size = new System.Drawing.Size(279, 94);
            this.SekuntiV.TabIndex = 3;
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(12, 198);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(292, 98);
            this.StartBT.TabIndex = 4;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(319, 198);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(279, 98);
            this.StopBT.TabIndex = 5;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Location = new System.Drawing.Point(216, 321);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(191, 86);
            this.AikaLB.TabIndex = 6;
            this.AikaLB.Text = "00:00";
            // 
            // AjastinTM
            // 
            this.AjastinTM.Enabled = true;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // Laskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(35F, 86F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 535);
            this.Controls.Add(this.AikaLB);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.SekuntiV);
            this.Controls.Add(this.MinuteV);
            this.Controls.Add(this.SekLB);
            this.Controls.Add(this.MinLB);
            this.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.Name = "Laskuri";
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.Laskuri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MinLB;
        private Label SekLB;
        private ComboBox MinuteV;
        private ComboBox SekuntiV;
        private Button StartBT;
        private Button StopBT;
        private Label AikaLB;
        private System.Windows.Forms.Timer AjastinTM;
    }
}