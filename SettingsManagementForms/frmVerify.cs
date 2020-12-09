using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.SettingsManagementForms
{
    public partial class frmVerify : Form
    {
        DatabaseConnection konekcijaNaBazu = new DatabaseConnection();
        Profesor _profesor;
        public frmVerify()
        {
            InitializeComponent();
        }

        public frmVerify(Profesor profesor) : this()
        {
            _profesor = profesor;
        }

        private void frmVerify_Load(object sender, EventArgs e)
        {
            lblVerify.Text += _profesor.Email;
        }

        private void cbVerify_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(cbVerify.Checked)
            {
                _profesor.Verifikacija = 1;
                konekcijaNaBazu.Entry(_profesor).State = System.Data.Entity.EntityState.Modified;
                konekcijaNaBazu.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
