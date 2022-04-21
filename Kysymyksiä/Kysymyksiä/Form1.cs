namespace Kysymyksiä
{
    public partial class Vastaus : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new string[] { "A", "A", "C", "A", "D", "A", "B", "D", "B", "A" };
        string[] vastaukset = new string[10];
        public Vastaus()
        {
            InitializeComponent();
            EkaV.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            TokaV.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            KolmasV.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            NelkkuV.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri < 10)
            {
                RadioButton radiobutton = (RadioButton)sender;
                vastaukset[laskuri] = radiobutton.Text;
                laskuri++;
                KysymysLB.Text = "Vastaus " + laskuri + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                EkaV.Enabled = false;
                TokaV.Enabled =false;
                KolmasV.Enabled = false;
                NelkkuV.Enabled = false;
                for(int j = 0; j < 10; j++)
                {
                    if(vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if (EkaV.Checked == true)
            {
                EkaV.Checked = false;
                laskuri--;
            }
            if (TokaV.Checked == true)
            {
                TokaV.Checked = false;
                laskuri--;
            }
            if (KolmasV.Checked == true)
            {
                KolmasV.Checked = false;
                laskuri--;
            }
            if (NelkkuV.Checked == true)
            {
                NelkkuV.Checked = false;
                laskuri--;
            }
        }
    }
}