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
    public partial class frmStudents : Form
    {
        Profesor _user;
        DatabaseConnection konekcijaNaBazu = new DatabaseConnection();
        public frmStudents()
        {
            InitializeComponent();
        }

        public frmStudents(object user ) : this()
        {
            _user = user as Profesor;
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.EnableHeadersVisualStyles = false;
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            lbViewOf.Text += " " + _user.KorisnickoIme;
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = konekcijaNaBazu.Studenti;
        }
    }
}
