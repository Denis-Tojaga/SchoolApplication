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
    public partial class frmLogin : Form
    {
        DatabaseConnection konekcijaNaBazu = new DatabaseConnection();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Closing the current form
        /// </summary>
        private void lblCloseLoginForm_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Searching for that user in data base and logging in
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidirajPolja())
                {
                    Profesor profesor = PretragaProfesora(txtUsername.Text, txtPassword.Text);
                      PokretanjeGlavneForme(profesor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}  {ex.InnerException?.Message}");
            }
        }

        /// <summary>
        /// Finds the right profesor with that data
        /// </summary>
        private Profesor PretragaProfesora( string username, string password)
        {
            foreach (var profesor in konekcijaNaBazu.Profesori)
                if (profesor.KorisnickoIme == username && profesor.Lozinka == password)
                    return profesor;
            return null;
        }


        /// <summary>
        /// Validates the field and puts errorProvider if they are now valid
        /// </summary>
        private bool ValidirajPolja()
        {
            return Validator.ValidirajPolje(txtUsername, err, "This field is required!") && Validator.ValidirajPolje(txtPassword, err, "This field is required!");
        }


        /// <summary>
        /// Placeholder logic at both textboxes and enter acception
        /// </summary>
        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
        }
        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
             txtPassword.Text = "";
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                PokretanjeGlavneForme(PretragaProfesora(txtUsername.Text, txtPassword.Text));
                //ne proizvodi beep sound nakon sto se otvori forma nova
                e.SuppressKeyPress = true;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            char passcode = new char();
            if (txtPassword.PasswordChar == passcode)
                txtPassword.PasswordChar = '*';
        }


        /// <summary>
        /// Opens up a new form for that specific profesor
        /// </summary>
        private void PokretanjeGlavneForme(Profesor profesor)
        {
            if(profesor!=null)
            {
                frmAppMenu forma = new frmAppMenu(profesor);
                forma.ShowDialog();
            }
            else
                MessageBox.Show($"Uneseni podaci nisu validni!");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistracija registracija = new frmRegistracija();
            registracija.ShowDialog();
        }
    }
}
