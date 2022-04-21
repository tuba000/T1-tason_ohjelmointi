namespace BMI
{
    public partial class Laskuri : Form
    {
        public Laskuri()
        {
            InitializeComponent();
        }

        private void Laske_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(Paino.Text);
            pituus = Convert.ToDouble(Pituus.Text);
            double lasku = Math.Round(paino / (pituus * pituus), 2);
            if (lasku < 18.5)
            {
                Vastaus.Text = "Indeksisi on: " + lasku;
                Vastaus.ForeColor = Color.Blue;
                Lisaa.Text = "Alipaino";
                Lisaa.ForeColor = Color.Blue;
                Lisaa.Visible = true;
                Vastaus.Visible = true;
            }
            else if (lasku < 25)
            {
                Vastaus.Text = "Indeksisi on: " + lasku;
                Vastaus.ForeColor = Color.Green;
                Lisaa.Text = "Normaalipaino";
                Lisaa.ForeColor = Color.Green;
                Lisaa.Visible = true;
                Vastaus.Visible = true;
            }
            else if (lasku < 40)
            {
                Vastaus.Text = "Indeksisi on: " + lasku;
                Vastaus.ForeColor = Color.Gold;
                Lisaa.Text = "Ylipaino";
                Lisaa.ForeColor = Color.Gold;
                Lisaa.Visible = true;
                Vastaus.Visible = true;
            }
            else
            {
                Vastaus.Text = "Indeksisi on: " + lasku;
                Vastaus.ForeColor = Color.Red;
                Lisaa.Text = "Huomattava ylipaino";
                Lisaa.ForeColor = Color.Red;
                Lisaa.Visible = true;
                Vastaus.Visible = true;
            }
        }
    }
}