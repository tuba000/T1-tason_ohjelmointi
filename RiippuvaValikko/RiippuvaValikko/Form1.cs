using System.Data;

namespace RiippuvaValikko
{
    public partial class Pudotusvalikko : Form
    {
        DataTable oppilaitos = new DataTable();
        DataTable vastuuHenkilot = new DataTable();
        DataTable yhteys = new DataTable();
        public Pudotusvalikko()
        {
            InitializeComponent();
        }


        private void KouluCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viite = oppilaitos.Rows[KouluCB.SelectedIndex]["OID"].ToString();
            OsoiteLB.Text = oppilaitos.Rows[KouluCB.SelectedIndex]["OKatuosoite"].ToString();
            PnLB.Text = oppilaitos.Rows[KouluCB.SelectedIndex]["OPostinumero"].ToString();
            KaupunkiLB.Text = oppilaitos.Rows[KouluCB.SelectedIndex]["OKaupunki"].ToString();
            KouPuhLB.Text = oppilaitos.Rows[KouluCB.SelectedIndex]["OPuhelin"].ToString();
            yhteys = vastuuHenkilot.Select("OID =" + viite).CopyToDataTable();
            OpeCB.DataSource = yhteys;
            OpeCB.DisplayMember = "VNimi";
        }
        private void Pudotusvalikko_Load(object sender, EventArgs e)
        {
            taytaOppilaitosTaulukko();
            KouluCB.DataSource = oppilaitos;
            KouluCB.DisplayMember = "ONimi";
            taytaVastuuHenkilotTaulukko();

        }
        private void OpeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            VirkaLB.Text = yhteys.Rows[OpeCB.SelectedIndex]["VTitteli"].ToString();
            OsastoLB.Text = yhteys.Rows[OpeCB.SelectedIndex]["VOsasto"].ToString();
            SpLB.Text = yhteys.Rows[OpeCB.SelectedIndex]["VSahkoposti"].ToString();
            NumeroLB.Text = yhteys.Rows[OpeCB.SelectedIndex]["VPuhelin"].ToString();
        }
        private void taytaOppilaitosTaulukko()
        {
            oppilaitos.Columns.Add("OID", typeof(int));
            oppilaitos.Columns.Add("ONimi");
            oppilaitos.Columns.Add("OKatuosoite");
            oppilaitos.Columns.Add("OPostinumero");
            oppilaitos.Columns.Add("OKaupunki");
            oppilaitos.Columns.Add("OPuhelin");

            oppilaitos.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600");
            oppilaitos.Rows.Add(2, "Omnia", "Armas Launiksen katu 9", "02650", "Espoo", "046 877 1371");
            oppilaitos.Rows.Add(3, "Varia", "Rälssitie 13", "01530", "Vantaa", "040 182 4668");
            oppilaitos.Rows.Add(4, "Keuda", "Sibeliuksenväylä 55A", "04400", "Järvenpää", "09 27 381");
        }
        private void taytaVastuuHenkilotTaulukko()
        {
            vastuuHenkilot.Columns.Add("OID", typeof(int));
            vastuuHenkilot.Columns.Add("VNimi");
            vastuuHenkilot.Columns.Add("VTitteli");
            vastuuHenkilot.Columns.Add("VOsasto");
            vastuuHenkilot.Columns.Add("VSahkoposti");
            vastuuHenkilot.Columns.Add("VPuhelin");

            vastuuHenkilot.Rows.Add(1, "Sirpa Lindroos", "Rehtori", "Kampus 1", "sirpa.lindroos@hel.fi", "658 540 4434");
            vastuuHenkilot.Rows.Add(1, "Hanna Laurila", "Rehtori", "Kaupus 2", "hanna.laurila@hel.fi", "040 676 5583");
            vastuuHenkilot.Rows.Add(1, "Annele Ranta", "Rehtori", "Kampus 3", "annele.ranta@hel.fi", "248 631 5667");
            vastuuHenkilot.Rows.Add(1, "Eeva Sahlman", "Rehtori", "Kampus 4", "eeva.sahlman@hel.fi", "240 336 1017");
            vastuuHenkilot.Rows.Add(1, "Marko Aaltonen", "Rehtori", "Kampus 5", "marko.aaltonen@hel.fi", "e58 511 8115");
            vastuuHenkilot.Rows.Add(2, "Tuula Antola", "Koulutuskuntayhtymän johtaja", "Yleishallinto", "tuula.antola@omnia.fi", "");
            vastuuHenkilot.Rows.Add(2, "Tapio Siukonen", "Hallintojohtaja", "Yleishallinto", "tapio.siukonen@omnia.fi", "044 369 6600");
            vastuuHenkilot.Rows.Add(2, "Tuukko Soini", "kehittämisjohtaja", "Yleishallinto", "tuukka.soini@omnia.fi", "846 877 2952");
            vastuuHenkilot.Rows.Add(2, "Riikka-Maria Yli-Suomu", "Liiketoimintajohtaja", "Elinvoima- ja työllisyyspalvelut", "riikka-maria.yli-suomu@omnia.fi", "e5e 348 6544");
            vastuuHenkilot.Rows.Add(2, "Maija Aaltola", "Rehtori", "Koulutus- ja opiskelijapalvelut", "maija-aaltola@omnia.fi", "e58 384 9354");
            vastuuHenkilot.Rows.Add(2, "kai Iivari", "Talousjohtaja", "Talous ja hankintapalvelut", "kai.livari@omnia.fi", "2400 306 691");
            vastuuHenkilot.Rows.Add(2, "Päivi Korhonen", "viestintäjohtaja", "viestintä- ja markkinointipalvelut", "paivi.korhonen@omnia.fi", "148 126 7599");
            vastuuHenkilot.Rows.Add(3, "Pekka Tauriainen", "Rehtori", "", "pekka.tauriainen@vantaa.fi", "e58 312 4514");
            vastuuHenkilot.Rows.Add(3, "Anne Heinonen", "Työelämäpalvelupäällikko", "", "anne.heinonen@vantaa.fi", "240 524 1242");
            vastuuHenkilot.Rows.Add(3, "Tuula Kiistinen", "Yhteisten palveluiden päällikko", "",  "tuula.kiiskinen@vantaa.fi", "240 193 9848");
            vastuuHenkilot.Rows.Add(4, "Tiina Halmevuo", "kuntayhtymän johtaja", "Hallinto- ja johtamispalvelut", "tiina.halmevuo@keuda.fi", "e5e 336 9789");
            vastuuHenkilot.Rows.Add(4, "Anna Mari Leinonen", "Rehtori", "Hallinto", "annamari.leinonen@keuda.fi", "848 174 4523");
            vastuuHenkilot.Rows.Add(4, "Anne Vuorinen", "Johtaja", "Yritys- ja elinvoimapalvelut", "anne.vuorinen@keuda.fi", "958 415 0974");
            vastuuHenkilot.Rows.Add(4, "Hanna Nyrönen", "viestintä- ja markkinointipäällikkö", "viestintäpalvelut", "hanna.nyronen@keuda.fi", "248 521 8428");
            vastuuHenkilot.Rows.Add(4, "Maarit Flinck", "Asianhallintapäällikko", "Hallinto- ja johtamispalvelut", "maarit.flinck@keuda.fi", "esee 837 357");

        }

        private void OpeCB_TextChanged(object sender, EventArgs e)
        {
            VirkaLB.Text = yhteys.Rows[OpeCB.SelectedIndex]["VTitteli"].ToString();
            OsastoLB.Text = yhteys.Rows[OpeCB.SelectedIndex]["VOsasto"].ToString();
            SpLB.Text = yhteys.Rows[OpeCB.SelectedIndex]["VSahkoposti"].ToString();
            NumeroLB.Text = yhteys.Rows[OpeCB.SelectedIndex]["VPuhelin"].ToString();
        }
    }
}