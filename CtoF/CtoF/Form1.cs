namespace CtoF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuuntoBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteLuku.Text);
            if(Celsius.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                Vastaus.Text = asteet + " Fahrenheitia on " + vastaus + " Celsius astetta.";
                Vastaus.Visible = true;
            }
            else if (Fahrenheit.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                Vastaus.Text = asteet + " Celsiusta on " + vastaus + " Fahreinheit astetta.";
                Vastaus.Visible = true;
            }
            else
            {
                Vastaus.Text = "Et valinnut muutettavaa astetta tai antanut oikeaa lukua";
                Vastaus.Visible= true;
            }
        }
    }
}