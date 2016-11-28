using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Momentum_GUI3
{
    public partial class GUI : Form
    {
        
        public string eemail = "";
        public string ffornavn = "";
        public string eefternavn = "";
        public string aadresse = "";
        public string ppostnr = "";
        public string bby = "";
        public string kkorttype = "";
        public string ttlf_nr = "";
        public string dtp = "";
        public string kkommentar = "";
        public GUI()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tilbage_tilføj_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            
        }

        private void tilbage_vis_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

         
  
        private void accepter_Click(object sender, EventArgs e)
        {
            if (fornavn.Text != "" && efternavn.Text != "" && adresse.Text != "" && postnr.Text != "" && by.Text != "" && tlf_nr.Text != "" && dateTimePicker1.Value.ToString("yyyy-MM-dd") != "" && korttype.Text != "")
            {
                string t = Checking.input_Check(fornavn.Text, efternavn.Text, adresse.Text, postnr.Text, by.Text, tlf_nr.Text, email.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), korttype.Text);
                if (t == "")
                {
                    if (MessageBox.Show("Er alle data korrekt?\n \n" + "Fornavn: " + fornavn.Text + "\nEfternavn: " + efternavn.Text + "\nAdresse: " + adresse.Text + "\nPostnummer: " + postnr.Text + "\nBy: " + by.Text + "\nEmail: " + email.Text + "\nUdløbsdato: " + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "\nKorttype: " + korttype.Text + "\nTelefonnummer: " + tlf_nr.Text + "\nKommentar" + kommentar.Text, "Opret", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SQL_Database sql = new SQL_Database();
                        sql.Connect("ealdb1.eal.local", "EJL34_DB", "ejl34_usr", "Baz1nga34");
                        Dictionary<string, string> data = new Dictionary<string, string>();
                        data.Add("Fornavn", fornavn.Text);
                        data.Add("Efternavn", efternavn.Text);
                        data.Add("Mail", email.Text);
                        data.Add("Adresse", adresse.Text);
                        data.Add("Postnr", postnr.Text);
                        data.Add("city", by.Text);
                        data.Add("Tlf", tlf_nr.Text);
                        string today = Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd");
                        data.Add("IndloestDato", today);
                        //data.Add("KoebtDato", koebtdato);
                        //data.Add("IndloestDato", indloestdato);
                        data.Add("UdloebsDato", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        data.Add("AarskortType", korttype.Text);
                        data.Add("Andet", kommentar.Text);
                        if (sql.Insert("AarskortMomentum", data) > 0)
                        {
                            email.Text = "";
                            fornavn.Text = "";
                            efternavn.Text = "";
                            adresse.Text = "";
                            postnr.Text = "";
                            by.Text = "";
                            korttype.Text = "";
                            tlf_nr.Text = "";
                            kommentar.Text = "";
                            MessageBox.Show("Årskort er nu oprettet");
                        }
                        else
                        {
                            MessageBox.Show("Der skete en fejl, prøv igen");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(t);
                }
            }
            else
            {
                string t = "Du har glemt at udfylde følgende felter: \n" + (fornavn.Text != "" ? "" : "fornavn\n") + (efternavn.Text != "" ? "" : "efternavn\n")
                    + (adresse.Text != "" ? "" : "adresse\n") + (postnr.Text != "" ? "" : "post nr. \n") + (by.Text != "" ? "" : "by\n")
                    + (korttype.Text != "" ? "" : "korttype\n") + (tlf_nr.Text != "" ? "" : "Telefon nummer");
                MessageBox.Show(t);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            ffornavn = fornavn.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*string theDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            MessageBox.Show(theDate);*/
            dtp = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            
        }
      

        private void email_TextChanged(object sender, EventArgs e)
        {
            eemail = email.Text;
        }

        private void efternavn_TextChanged(object sender, EventArgs e)
        {
            eefternavn = efternavn.Text;
        }

        private void adresse_TextChanged(object sender, EventArgs e)
        {
            aadresse = adresse.Text;
        }

        private void postnr_TextChanged(object sender, EventArgs e)
        {
            ppostnr = postnr.Text;
        }

        private void by_TextChanged(object sender, EventArgs e)
        {
            bby = by.Text;
        }

        private void korttype_TextChanged(object sender, EventArgs e)
        {
            kkorttype = korttype.Text;
        }

        private void tlf_nr_TextChanged(object sender, EventArgs e)
        {
            ttlf_nr = tlf_nr.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void kommentar_TextChanged_1(object sender, EventArgs e)
        {
            kkommentar = kommentar.Text;
        }
    }
}
