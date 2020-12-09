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

namespace SchoolApp.SettingsManagementForms
{
    public partial class frmGeneral : Form
    {
        Profesor _profesor;
        DatabaseConnection konekcijaNaBazu = new DatabaseConnection();

        public frmGeneral()
        {
            InitializeComponent();
        }
        public frmGeneral(Profesor profesor) :this()
        {
            _profesor = profesor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }




        /// <summary>
        /// Loads data from the current professor
        /// </summary>
        private void LoadData()
        {
            txtImePrezime.Text = _profesor.Ime + " " + _profesor.Prezime;
            txtEmail.Text = _profesor.Email;
            txtSafeWord.Text = _profesor.SigurnosnaRijec;
            if(_profesor.Verifikacija==1)
            {
                txtVerified.Text = "Email verified!";
                linkLabel4.Enabled = false;
            }
            else
                txtVerified.Text = "Verify your identity so you can see the school ads and upcoming events.";
        }
        private void frmGeneral_Load(object sender, EventArgs e)
        {
            LoadData();
            LockControls();
        }



        /// <summary>
        /// Locks all controls
        /// </summary>
        private void LockControls()
        {
            txtEmail.Enabled = false;
            txtImePrezime.Enabled = false;
            txtSafeWord.Enabled = false;
            txtVerified.Enabled = false;
        }




        /// <summary>
        /// Functionalities for every clicked link label
        /// </summary>
        private void lblEditMode1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblEditMode1.Text == "Edit")
            {
                txtImePrezime.Enabled = true;
                lblEditMode1.Text = "Finish";
            }
            else
            {
                txtImePrezime.Enabled = false;
                lblEditMode1.Text = "Edit";
            }
        }
        private void lblEditMode2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblEditMode2.Text == "Edit")
            {
                txtEmail.Enabled = true;
                lblEditMode2.Text = "Finish";
            }
            else
            {
                if (Validator.ValidirajPolje(txtEmail, err, "This field is required!"))
                {
                    _profesor.Email = txtEmail.Text;
                    konekcijaNaBazu.Entry(_profesor).State = EntityState.Modified;
                    konekcijaNaBazu.SaveChanges();
                    txtEmail.Enabled = false;
                    lblEditMode2.Text = "Edit";
                }
            }
        }
        private void lblEditMode3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblEditMode3.Text == "Edit")
            {
                txtSafeWord.Enabled = true;
                lblEditMode3.Text = "Finish";
            }
            else
            {
                if (Validator.ValidirajPolje(txtSafeWord, err, "This field is required!"))
                {
                    _profesor.SigurnosnaRijec = txtSafeWord.Text;
                    konekcijaNaBazu.Entry(_profesor).State = EntityState.Modified;
                    konekcijaNaBazu.SaveChanges();
                    txtSafeWord.Enabled = false;
                    lblEditMode3.Text = "Edit";
                }
            }
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmVerify verifikacija = new frmVerify(_profesor);
            if(verifikacija.ShowDialog() == DialogResult.OK)
            {
                txtVerified.Text = "Email verified!";
                linkLabel4.Enabled = false;
                MessageBox.Show($"Email successfully verified!");
            }
        }
    }
}
