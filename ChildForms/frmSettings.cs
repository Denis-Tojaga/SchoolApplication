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
        public frmSettings()
        {
            InitializeComponent();
            _profesor = new Profesor();
        }

        public frmSettings(Profesor profesor) : this()
        {
            _profesor = profesor;
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            lblClickedButtonValue.Text = "General settings of your account";
        }

        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            lblClickedButtonValue.Text = "Privacy settings of your account";
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            lblClickedButtonValue.Text = "Language settings of your account";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue with this action?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
