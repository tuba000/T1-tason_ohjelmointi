namespace IkaLaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt-synttari).TotalDays);
            IkaVuosi.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            IkaKuukausi.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            IkaPaiva.Text = erotus + " p‰iv‰‰";
            IkaTunti.Text = (erotus * 24 + " tuntia");
            IkaMinut.Text = (erotus * 24 * 60 + " minuuttia");
            IkaSekunt.Text = (erotus * 24 * 60 * 60 + " sekuntia");
            IkaVuosi.Visible = true;
            IkaKuukausi.Visible = true;
            IkaPaiva.Visible = true;
            IkaTunti.Visible = true;
            IkaMinut.Visible = true;
            IkaSekunt.Visible = true;
        }
    }
}