namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Joona" && SalasanaTB.Text == "kekkonen123")
            {
                SalasanaPanel.Visible = false;
                oikein.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "K‰ytt‰j‰ tai salasana v‰‰r‰";
                VirheviestiLB.Visible = true;
            }
        }
    }
}