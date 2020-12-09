using SchoolApp.SettingsManagementForms;
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
    public partial class frmSettings : Form
    {
        Profesor _profesor;
        Form _activeForm;
        Button _activeButton;

        public frmSettings()
        {
            InitializeComponent();
            _profesor = new Profesor();
        }

        public frmSettings(Profesor profesor) : this()
        {
            _profesor = profesor;
        }

        /// <summary>
        /// Hides and show settings meni
        /// </summary>

        private void HideMeniButtons()
        {
            btnGeneral.Hide();
            btnLogout.Hide();
            btnLanguage.Hide();
            btnPrivacy.Hide();
            pb1.Hide();
            pb2.Hide();
            pb3.Hide();
            pb4.Hide();
            btnGoBack.Show();
        }
        private void ShowMeni()
        {
            btnGeneral.Show();
            btnLogout.Show();
            btnLanguage.Show();
            btnPrivacy.Show();
            pb1.Show();
            pb2.Show();
            pb3.Show();
            pb4.Show();
            btnGoBack.Hide();
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _activeForm.Close();
            ShowMeni();
        }








        /// <summary>
        /// Opens up child forms for this meni
        /// </summary>
        private void OpenChildForm(Form childForma, object btnKliknuti)
        {
            _activeForm?.Close();
            //AktivirajButton(btnKliknuti);
            _activeForm = childForma;
            childForma.TopLevel = false;
            childForma.FormBorderStyle = FormBorderStyle.None;
            childForma.Dock = DockStyle.Fill;
            panelMeni.Controls.Add(childForma);
            panelMeni.Tag = childForma;
            childForma.BringToFront();
            childForma.Show();
        }




        private void btnGeneral_Click(object sender, EventArgs e)
        {
            lblClickedButtonValue.Text = "General settings of your account";
            HideMeniButtons();
            frmGeneral generalForma = new frmGeneral();
            OpenChildForm(generalForma, sender);
        }


        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            lblClickedButtonValue.Text = "Privacy settings of your account";
            HideMeniButtons();
            frmPrivacy privacyForma = new frmPrivacy();
            OpenChildForm(privacyForma, sender);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            lblClickedButtonValue.Text = "Language settings of your account";
            HideMeniButtons();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue with this action?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
                Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            btnGoBack.Hide();
        }

    }
}
