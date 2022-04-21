namespace Nimitesti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\joona\\OneDrive\\Koulutehtävät\\Keuda\\T1 Ohjelmointi\\Filut\\Nimitesti\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\joona\\OneDrive\\Koulutehtävät\\Keuda\\T1 Ohjelmointi\\Filut\\Nimitesti\\tytot.txt");
            string nimi = NimiB.Text;
            int laskurip = 1, laskurit = 1;
            foreach(string p in pojat)
            {
                if (nimi == p)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin pojan nimi vuonna 2022";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string t in tytot)
            {
                if (nimi == t)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tytön nimi vuonna 2022";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei ole suosittu!";
                VastausLB.Visible = true;
            }
        }
    }
}