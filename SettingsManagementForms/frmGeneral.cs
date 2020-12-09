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

        private void frmGeneral_Load(object sender, EventArgs e)
        {
            LoadData();
            LockControls();
        }

        private void LoadData()
        {
            txtImePrezime.Text = _profesor.Ime + " " + _profesor.Prezime;
            txtEmail.Text = _profesor.Email;
            txtSafeWord.Text = _profesor.SigurnosnaRijec;
        }

        private void LockControls()
        {
            txtEmail.Enabled = false;
            txtImePrezime.Enabled = false;
            txtSafeWord.Enabled = false;
            txtIdentity.Enabled = false;
        }





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
    }
}
