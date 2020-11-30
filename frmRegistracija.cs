using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class frmRegistracija : Form
    {
        DatabaseConnection konekcijaNaBazu = new DatabaseConnection();
        private const string WarningMessage = "This field is required!";
        public frmRegistracija()
        {
            InitializeComponent();
            txtDatumRegistracije.Text = DateTime.Now.ToShortDateString();
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Unlocks the password on click, so the user can see it
        /// </summary>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OtkljucajZakljucajLozinku();
        }
        private void OtkljucajZakljucajLozinku()
        {
            char passcode = new char();
            if (txtLozinka.PasswordChar == '*')
                txtLozinka.PasswordChar = passcode;
            else
                txtLozinka.PasswordChar = '*';
        }


        /// <summary>
        /// Opens up the file dialog so user can pick a picture from gallery
        /// </summary>
        private void btnOdaberiSliku_Click(object sender, EventArgs e)
        {
            if(ofdOdabirSlike.ShowDialog() == DialogResult.OK)
            {
                //loads the image that user has choosen
                pbSlikaProfesora.Image = Image.FromFile(ofdOdabirSlike.FileName);
            }
        }


        //Closes the current form
        private void label22_Click(object sender, EventArgs e)
        {
            Close();
        }




        /// <summary>
        /// Adds a new professor to a database, so he can login next time with data he entered
        /// </summary>
        private void btnRegistracijaKorisnika_Click(object sender, EventArgs e)
        {
            RegistrujKorisnika();
        }
        private void RegistrujKorisnika()
        {
            try
            {
                if (ValidacijaPolja())
                {
                    Profesor novi = new Profesor();
                    novi.Ime = txtIme.Text;
                    novi.Prezime = txtPrezime.Text;
                    novi.KorisnickoIme = txtKorisnickoIme.Text;
                    novi.Lozinka = txtLozinka.Text;
                    novi.Email = txtEmail.Text;
                    novi.Slika = ImageConventer.FromImageToByte(pbSlikaProfesora.Image);
                    novi.JMBG = txtJMBG.Text;
                    novi.BrojTelefona = txtBrojTelefona.Text;
                    novi.Ucionica = txtUcionica.Text;
                   // novi.DatumRodjenja = dtmDatumRodjenja.Value.ToShortDateString();
                   // novi.DatumRegistracije = txtDatumRegistracije.Text;


                    konekcijaNaBazu.Profesori.Add(novi);
                    konekcijaNaBazu.SaveChanges();
                    DialogResult = DialogResult.OK;
                    MessageBox.Show($"Registracija uspjesno obavljena!");
                    Close();
                }
                else
                    MessageBox.Show($"Niste unijeli sva polja predvidjena za registraciju,pokusajte ponovo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }


        /// <summary>
        /// Validates all fields in order for registration to be successfull
        /// </summary>
        private bool ValidacijaPolja()
        {
            return Validator.ValidirajPolje(txtPrezime, err, WarningMessage)
                 && Validator.ValidirajPolje(txtKorisnickoIme, err, WarningMessage) && Validator.ValidirajPolje(txtLozinka, err, WarningMessage) &&
                 Validator.ValidirajPolje(txtBrojTelefona, err, WarningMessage) && Validator.ValidirajPolje(txtUcionica, err, WarningMessage) &&
                 Validator.ValidirajPolje(dtmDatumRodjenja, err, WarningMessage) && Validator.ValidirajPolje(txtIme, err, WarningMessage);
        }


        /// <summary>
        /// Generates mail for user, format is name.surname@edu.fit.ba
        /// </summary>
        private void GenerisiMail()
        {
           string mail = txtIme.Text + "." + txtPrezime.Text;
            txtEmail.Text= mail.ToLower()+ "@edu.fit.ba";
        }
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiMail();
        }
        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiMail();
        }
    }
}
