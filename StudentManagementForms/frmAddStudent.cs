using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.StudentManagementForms
{
    public partial class frmAddStudent : Form
    {
        private const string Upozorenje = "Ovo polje je obavezno!";
        DatabaseConnection konekcijaNaBazu = new DatabaseConnection();
        private List<int> MoguceGodine = new List<int>();
        private List<string> GodineStudija = new List<string>();
        public frmAddStudent()
        {
            InitializeComponent();
            DodajGodineStudija();
            DodajGodine();
            GenerisiIndeksStudentu();
        }

      
        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            UcitajComboBoxove();
        }



        /// <summary>
        /// Loads all possible years and years of study to combo boxes
        /// </summary>
        private void UcitajComboBoxove()
        {
            UcitajCMBGodine();
            UcitajCMBGGodineStudija();

        }
        private void UcitajCMBGGodineStudija()
        {
            cmbGodinaStudija.DataSource = null;
            cmbGodinaStudija.DataSource = GodineStudija;
        }
        private void UcitajCMBGodine()
        {
            cmbGodine.DataSource = null;
            cmbGodine.DataSource = MoguceGodine;
        }

        /// <summary>
        /// Adds all years of study to a list
        /// </summary>
        private void DodajGodineStudija()
        {
            GodineStudija.Add("Prva godina");
            GodineStudija.Add("Druga godina");
            GodineStudija.Add("Treca godina");
            GodineStudija.Add("Cetvrta godina");
            GodineStudija.Add("-- Master --");
        }
        private void DodajGodine()
        {
            for (int i = 18; i < 50; i++)
                MoguceGodine.Add(i);
        }





        /// <summary>
        /// Generates an email and index code for new student when text is changed
        /// </summary>
        private void GenerisiIndeksStudentu()
        {
           txtBrojIndeksa.Text= $"IB{(DateTime.Now.Year - 2000) * 10000 + konekcijaNaBazu.Studenti.Count() + 1}";
        }
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            string email = txtIme.Text.ToLower() + txtPrezime.Text.ToLower();
            txtEmail.Text = email + "@edu.fit.ba";
        }
        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            string email = txtIme.Text.ToLower() + "." + txtPrezime.Text.ToLower();
            txtEmail.Text = email + "@edu.fit.ba";
        }



        /// <summary>
        /// Loads the picture that we have choosen with button
        /// </summary>
        private void btnOdaberiSliku_Click(object sender, EventArgs e)
        {
            if(ofdOdabirSlike.ShowDialog() == DialogResult.OK)
                pbSlikaStudenta.Image = Image.FromFile(ofdOdabirSlike.FileName);
        }



        /// <summary>
        /// Validates and saves all data from input fields to a new student and adds him to DB
        /// </summary>
        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if(ValidinaPolja())
            {
                string godina = cmbGodine.SelectedItem.ToString();
                konekcijaNaBazu.Studenti.Add(new Student()
                {
                    BrojIndeksa = txtBrojIndeksa.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    ImeOca = txtImeOca.Text,
                    DatumRodjenja = dtmDatumRodjenja.Value.ToShortDateString(),
                    Email = txtEmail.Text,
                    Spol = ProvjeraChecked(),
                    GodinaStudija = cmbGodinaStudija.SelectedItem.ToString(),
                    Godine = int.Parse(godina),
                    Slika = ImageConventer.FromImageToByte(pbSlikaStudenta.Image)
                });
                konekcijaNaBazu.SaveChanges();
                MessageBox.Show($"Student successfully added!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }



        /// <summary>
        /// Validates all input fields and checks their values
        /// </summary>
        private string ProvjeraChecked()
        {
            if (rbMale.Checked)
                return "Musko";
            return "Zensko";
        }
        private bool ValidinaPolja()
        {
            return Validator.ValidirajPolje(txtIme, err, Upozorenje) && Validator.ValidirajPolje(txtPrezime, err, Upozorenje) && Validator.ValidirajPolje(txtImeOca, err, Upozorenje) &&
                 Validator.ValidirajPolje(cmbGodine, err, Upozorenje) && Validator.ValidirajPolje(cmbGodinaStudija, err, Upozorenje) && Validator.ValidirajPolje(pbSlikaStudenta, err, Upozorenje)
                 && (Validator.ValidirajPolje(rbFemale, err, Upozorenje) || Validator.ValidirajPolje(rbMale,err,Upozorenje));
        }
    }
}
