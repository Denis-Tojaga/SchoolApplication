using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.ChildForms
{
    public partial class frmHome : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private const string upozorenje = "The field is not valid!";
        public static Profesor _currentProfessor;
        public frmHome()
        {
            InitializeComponent();
            _currentProfessor = new Profesor();
        }
        public frmHome(object user) : this()
        {
            _currentProfessor = user as Profesor;
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            SakrijZvjezdice();
            LoadUser();
        }






        /// <summary>
        /// Draws the border of the panels
        /// </summary>
        private void panelUserInfo_Paint(object sender, PaintEventArgs e)
        {
          ControlPaint.DrawBorder(e.Graphics,panelUserInfo.ClientRectangle, Color.FromArgb(30, 115, 172),ButtonBorderStyle.Solid);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelUserInfo.ClientRectangle, Color.FromArgb(30, 115, 172), ButtonBorderStyle.Solid);
        }







        /// <summary>
        /// Loads the data about currently logged professor
        /// </summary>
        private void LoadUser()
        {
            try
            {
                UcitajPolja();
                OnemoguciPolja();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }
        private void UcitajPolja()
        {
            if (_currentProfessor != null)
            {
                txtIme.Text = _currentProfessor.Ime;
                txtPrezime.Text = _currentProfessor.Prezime;
                txtKorisnickoIme.Text = _currentProfessor.KorisnickoIme;
                txtLozinka.Text = _currentProfessor.Lozinka;
                txtDatumRodjenja.Text = _currentProfessor.DatumRodjenja;
                if (_currentProfessor.Spol == "Musko")
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
                txtEmail.Text = _currentProfessor.Email;
                txtJMBG.Text = _currentProfessor.JMBG;
                txtBrojTelefona.Text = _currentProfessor.BrojTelefona;
                txtUcionica.Text = _currentProfessor.Ucionica;
                txtRadnaPozicija.Text = _currentProfessor.RadnaPozicija;
                if (_currentProfessor.Slika.Length != 0)
                    pbSlikaProfesora.Image = ImageConventer.FromByteToImage(_currentProfessor.Slika);
                else
                    pbSlikaProfesora.Image = null;
                txtDatumZaposlenja.Text = _currentProfessor.DatumZaposlenja;
            }else
                MessageBox.Show($"Nije moguce ucitati podatke!");
        }




        /// <summary>
        /// Turns the edit mode on
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            OmoguciPolja();
        }







        /// <summary>
        /// Enables and disables all controls on click
        /// </summary>
        private void OnemoguciPolja()
        {
            lblExitEditMode.Hide();
            btnExitEditMode.Hide();
            btnEdit.Show();
            btnSaveChanges.Hide();
            btnChoosePhoto.Hide();
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtDatumZaposlenja.Enabled = false;
            txtDatumRodjenja.Enabled = false;
            txtKorisnickoIme.Enabled = false;
            txtLozinka.Enabled = false;
            txtEmail.Enabled = false;
            txtBrojTelefona.Enabled = false;
            txtUcionica.Enabled = false;
            txtRadnaPozicija.Enabled = false;
            pbSlikaProfesora.Enabled = false;
            txtJMBG.Enabled = false;
            rbFemale.Enabled = false;
            rbMale.Enabled = false;
        }
        private void OmoguciPolja()
        {
            btnEdit.Hide();
            lblExitEditMode.Show();
            btnExitEditMode.Show();
            btnChoosePhoto.Show();
            btnSaveChanges.Show();
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            txtDatumZaposlenja.Enabled = true;
            txtDatumRodjenja.Enabled = true;
            txtKorisnickoIme.Enabled = true;
            txtLozinka.Enabled = true;
            txtEmail.Enabled = true;
            txtBrojTelefona.Enabled = true;
            txtUcionica.Enabled = true;
            txtRadnaPozicija.Enabled = true;
            pbSlikaProfesora.Enabled = true;
            txtJMBG.Enabled = true;
            rbFemale.Enabled = true;
            rbMale.Enabled = true;
        }





        /// <summary>
        /// Exits edit mode and again disables input fields
        /// </summary>
        private void btnExitEditMode_Click(object sender, EventArgs e)
        {
            SakrijZvjezdice();
            ResetujSve();
            OnemoguciPolja();
        }
        private void ResetujSve()
        {
            UcitajPolja();
        }





        /// <summary>
        /// Validates if the changes weren't changed properly
        /// </summary>
        private bool ValidirajPromjene()
        {
            return ValidirajPolje(txtIme, err, upozorenje) && ValidirajPolje(txtPrezime, err, upozorenje) && ValidirajPolje(txtDatumRodjenja, err, upozorenje)
                && ValidirajPolje(txtKorisnickoIme, err, upozorenje) && ValidirajPolje(txtLozinka, err, upozorenje) && ValidirajPolje(txtEmail, err, upozorenje)
                && ValidirajPolje(txtJMBG, err, upozorenje) && ValidirajPolje(txtBrojTelefona, err, upozorenje) && ValidirajPolje(txtUcionica, err, upozorenje)
                && ValidirajPolje(txtRadnaPozicija, err, upozorenje) && ValidirajPolje(rbMale, err, upozorenje) || ValidirajPolje(rbFemale, err, upozorenje)
                && ValidirajPolje(txtDatumZaposlenja,err,upozorenje) && ValidirajPolje(pbSlikaProfesora,err,upozorenje);
        }
        private bool ValidirajPolje(Control controla,ErrorProvider err,string poruka)
        {
            bool validno = true;
            if (controla is TextBox && string.IsNullOrEmpty((controla as TextBox).Text))
                validno = false;
            else if (controla is PictureBox && (controla as PictureBox).Image == null)
                validno = false;
            else if (controla is RadioButton && (controla as RadioButton).Checked == false)
                validno = false;

            if(!validno)
            {
                err.SetError(controla, poruka);
                return false;
            }
            err.Clear();
            return true;
        }




        /// <summary>
        /// Loads the chosen photo to picture box
        /// </summary>
        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            if(ofdOdabirSlike.ShowDialog() == DialogResult.OK)
            {
                string putanja = ofdOdabirSlike.FileName;
                Image slikaUcitana = Image.FromFile(putanja);
                pbSlikaProfesora.Image = slikaUcitana;
            }
        }




        /// <summary>
        /// Saves all changes , resets all input fields and again disables everything until next edit mode on
        /// </summary>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(ValidirajPromjene())
            {
                SakrijZvjezdice();
                OnemoguciPolja();
                UpdateProfessorDetails();
                ResetujSve();
            }
        }



        /// <summary>
        /// Makes an update in database and in form fields with entered data
        /// </summary>
        private void UpdateProfessorDetails()
        {
            try
            {
                _currentProfessor.Ime = txtIme.Text;
                _currentProfessor.Prezime = txtPrezime.Text;
                _currentProfessor.KorisnickoIme = txtKorisnickoIme.Text;
                _currentProfessor.Lozinka = txtLozinka.Text;
                _currentProfessor.DatumRodjenja = txtDatumRodjenja.Text;
                _currentProfessor.DatumZaposlenja = txtDatumZaposlenja.Text;
                _currentProfessor.Email = txtEmail.Text;
                _currentProfessor.JMBG = txtJMBG.Text;
                _currentProfessor.Ucionica = txtUcionica.Text;
                _currentProfessor.RadnaPozicija = txtRadnaPozicija.Text;
                _currentProfessor.BrojTelefona = txtBrojTelefona.Text;
                if (rbMale.Checked)
                    _currentProfessor.Spol = "Musko";
                else
                    _currentProfessor.Spol = "Zensko";
                _currentProfessor.Slika = ImageConventer.FromImageToByte(pbSlikaProfesora.Image);

                databaseConnection.Entry(_currentProfessor).State = EntityState.Modified;
                databaseConnection.SaveChanges();
                MessageBox.Show($"Data successfully changed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska u povezivanju sa bazom -> {ex.Message} {ex.InnerException?.Message}");
            }
        }






        /// <summary>
        /// Displays an edit red star so we can track our changes, cancels them when changes are done
        /// </summary>
        private void PrikaziEditStar(Label label)
        {
            label.Show();
            label.ForeColor = Color.Red;
        }
        private void SakrijZvjezdice()
        {
            lblZ1.Hide();
            lblZ2.Hide();
            lblZ3.Hide();
            lblZ4.Hide();
            lblZ5.Hide();
            lblZ6.Hide();
            lblZ7.Hide();
            lblZ8.Hide();
            lblZ9.Hide();
            lblZ10.Hide();
        }

        private void txtIme_MouseClick(object sender, EventArgs e)
        {
            PrikaziEditStar(lblZ1);
        }
        private void txtPrezime_MouseClick(object sender, MouseEventArgs e)
        {
            PrikaziEditStar(lblZ2);
        }
        private void txtDatumRodjenja_MouseClick(object sender, MouseEventArgs e)
        {
            PrikaziEditStar(lblZ3);
        }
        private void txtKorisnickoIme_MouseClick(object sender, MouseEventArgs e)
        {
            PrikaziEditStar(lblZ4);
        }
        private void txtLozinka_MouseClick(object sender, MouseEventArgs e)
        {
            PrikaziEditStar(lblZ5);
        }
        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            PrikaziEditStar(lblZ6);

        }
        private void txtJMBG_MouseClick(object sender, MouseEventArgs e)
        {
            PrikaziEditStar(lblZ7);
        }
        private void txtBrojTelefona_MouseClick(object sender, MouseEventArgs e)
        {
            PrikaziEditStar(lblZ8);

        }
        private void txtUcionica_MouseClick(object sender, MouseEventArgs e)
        {
            PrikaziEditStar(lblZ9);
        }
        private void txtRadnaPozicija_MouseClick(object sender, MouseEventArgs e)
        {
            PrikaziEditStar(lblZ10);
        }

      
    }
}
