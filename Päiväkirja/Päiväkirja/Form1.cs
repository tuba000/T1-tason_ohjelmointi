namespace Päiväkirja
{
    public partial class PaivaKirja : Form
    {
        public PaivaKirja()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"C:\\Users\\joona\\OneDrive\\Koulutehtävät\\Keuda\\T1 Ohjelmointi\\Filut\\Päiväkirja\\log.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\joona\\OneDrive\\Koulutehtävät\\Keuda\\T1 Ohjelmointi\\Filut\\Päiväkirja\\log.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}