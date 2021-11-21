using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUDNET
{
    public partial class Form1 : Form
    {
        OPISKELIJA opis = new OPISKELIJA();
        public Form1()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string enimi = FNAMETB.Text;
            string snimi = LNAMETB.Text;
            string puhelin = PuhelinTB.Text;
            string email = SahkopostiTB.Text;
            int onro = Int32.Parse(OpiskelijanroTB.Text);

            if(enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool lisaaAsiakas = opis.lisaaOpiskelija(enimi, snimi, puhelin, email, onro);
                if(lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietoTauluDG.DataSource = opis.haeOpiskelijat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietoTauluDG.DataSource = opis.haeOpiskelijat();
        }

        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            string enimi = FNAMETB.Text;
            string snimi = LNAMETB.Text;
            string puhelin = PuhelinTB.Text;
            string email = SahkopostiTB.Text;
            int onro = Int32.Parse(OpiskelijanroTB.Text);
            int oid = Int32.Parse(IDTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - ID, Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool lisaaAsiakas = opis.muokkaaOpiskelija(oid, enimi, snimi, puhelin, email, onro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietoTauluDG.DataSource = opis.haeOpiskelijat();
        }

        private void TietoTauluDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTB.Text = TietoTauluDG.CurrentRow.Cells[0].Value.ToString();
            FNAMETB.Text = TietoTauluDG.CurrentRow.Cells[1].Value.ToString();
            LNAMETB.Text = TietoTauluDG.CurrentRow.Cells[2].Value.ToString();
            PuhelinTB.Text = TietoTauluDG.CurrentRow.Cells[3].Value.ToString();
            SahkopostiTB.Text = TietoTauluDG.CurrentRow.Cells[4].Value.ToString();
            OpiskelijanroTB.Text = TietoTauluDG.CurrentRow.Cells[5].Value.ToString();

        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            string ktunnus = IDTB.Text;
            if (opis.poistaOpiskelija(ktunnus))
            {
                TietoTauluDG.DataSource = opis.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }
    }
}
