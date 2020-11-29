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

        private void lblCloseLoginForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidirajPolja())
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    Profesor profesor = PretragaProfesora(username,password);
                    if (profesor != null)
                    {
                        MessageBox.Show($"Pronadjen u bazi {profesor.DatumRodjenja}");
                        frmAppMenu meniForma = new frmAppMenu(profesor);
                        meniForma.ShowDialog();
                    }
                    else
                        MessageBox.Show($"Uneseni podaci nisu validni, registrirajte se!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}  {ex.InnerException?.Message}");
            }
        }

        private Profesor PretragaProfesora( string username, string password)
        {
            foreach (var profesor in konekcijaNaBazu.Profesori)
                if (profesor.KorisnickoIme == username && profesor.Lozinka == password)
                    return profesor;
            return null;
        }

        private bool ValidirajPolja()
        {
            return Validator.ValidirajPolje(txtUsername, err, "This field is required!") && Validator.ValidirajPolje(txtPassword, err, "This field is required!");
        }
    }
}
