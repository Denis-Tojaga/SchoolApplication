using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.ChildForms
{
    public partial class frmHome : Form
    {
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


        private void panelUserInfo_Paint(object sender, PaintEventArgs e)
        {
          ControlPaint.DrawBorder(e.Graphics,panelUserInfo.ClientRectangle, Color.FromArgb(30, 115, 172),ButtonBorderStyle.Solid);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelUserInfo.ClientRectangle, Color.FromArgb(30, 115, 172), ButtonBorderStyle.Solid);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void LoadUser()
        {
            try
            {
                UcitajPolja(_currentProfessor);
                OnemoguciPolja();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }

        private void OnemoguciPolja()
        {
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

        private void UcitajPolja(Profesor profesor)
        {
            if(profesor!=null)
            {
                txtIme.Text = profesor.Ime;
                txtPrezime.Text = profesor.Prezime;
                txtKorisnickoIme.Text = profesor.KorisnickoIme;
                txtLozinka.Text = profesor.Lozinka;
                txtDatumRodjenja.Text = profesor.DatumRodjenja;
                if (profesor.Spol == "Muski")
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
                txtEmail.Text = profesor.Email;
                txtJMBG.Text = profesor.JMBG;
                txtBrojTelefona.Text = profesor.BrojTelefona;
                txtUcionica.Text = profesor.Ucionica;
                txtRadnaPozicija.Text = profesor.RadnaPozicija;
                if(ImageConventer.FromByteToImage(profesor.Slika)!=null)
                pbSlikaProfesora.Image = ImageConventer.FromByteToImage(profesor.Slika);
                txtDatumZaposlenja.Text = profesor.DatumZaposlenja;
            }else
                MessageBox.Show($"Nije moguce ucitati podatke!");
        }
    }
}
