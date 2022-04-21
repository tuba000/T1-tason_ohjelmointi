using System.Diagnostics;

namespace Ajastin
{
    public partial class Laskuri : Form
    {
        private int kokonaisaika;
        public Laskuri()
        {
            InitializeComponent();
        }
        private void Laskuri_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                MinuteV.Items.Add(i.ToString());
                SekuntiV.Items.Add(i.ToString());
            }
            MinuteV.SelectedIndex = 30;
            SekuntiV.SelectedIndex = 0;
        }
        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minuutit = int.Parse(MinuteV.SelectedItem.ToString());
            int sekunnit = int.Parse(SekuntiV.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }
        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                string v = minuutit.ToString() + ":" + sekunnit.ToString();
                AikaLB.Text = v;
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui.");
            }
        }

    }
}