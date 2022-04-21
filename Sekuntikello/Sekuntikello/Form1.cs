using System.Diagnostics;

namespace Sekuntikello
{
    public partial class Sekuntikello : Form
    {
        private Stopwatch sekkari;
        public Sekuntikello()
        {
            InitializeComponent();
        }


        private void KaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void Sekuntikello_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch();
        }

        private void AjanottoTM_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}