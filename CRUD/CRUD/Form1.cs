using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class OpiskeluRek : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public OpiskeluRek()
        {
            InitializeComponent();
        }

        private void OpiskeluRek_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tyhjaaBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            enimiTB.Text = "";
            snimiTB.Text = "";
            puhTB.Text = "";
            emailTB.Text = "";
            onroTB.Text = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String puhelin = puhTB.Text;
            String email = emailTB.Text;
            int oNro = Int32.Parse(onroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisaamaan", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();


            }
        }

        private void paivitaTB_Click(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String puhelin = puhTB.Text;
            String email = emailTB.Text;
            int oNro = Int32.Parse(onroTB.Text);
            int oid = Int32.Parse(idTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisaamaan", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
            }
        }
        private void TietotauluDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            enimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            snimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            onroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }
        private void poistaTB_Click(object sender, EventArgs e)
        {
            String ktunnus = idTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            tyhjaaBT.PerformClick();
        }

        private void puhTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}