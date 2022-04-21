namespace Kilometrikustannukset
{
    public partial class Laskuri : Form
    {
        public Laskuri()
        {
            InitializeComponent();
        }

        private void KmB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, lisat, vakuutus, muut, lopo, pesu, huolto, rengas, kilsa, tulos;
            laina = Convert.ToDouble(LainaB.Text);
            lisat = Convert.ToDouble(LisatB.Text);
            vakuutus = Convert.ToDouble(VakuutusB.Text);
            muut = Convert.ToDouble(MuutB.Text);
            lopo = Convert.ToDouble(LopoB.Text);
            pesu = Convert.ToDouble(PesuB.Text);
            huolto = Convert.ToDouble(HuoltoB.Text);
            rengas = Convert.ToDouble(RengasB.Text);
            kilsa = Convert.ToDouble(KmB.Text);
            tulos = (laina + lisat + vakuutus + muut + lopo + pesu + huolto + rengas) / (kilsa / 12);
            TulosV.Text = "Kustannukset kilometriä kohti ovat: " + tulos;
        }
    }
}