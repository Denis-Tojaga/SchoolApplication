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
    public partial class frmSubjects : Form
    {
        DatabaseConnection konekcijaNaBazu = new DatabaseConnection();
        Profesor _profesor;
        public frmSubjects()
        {
            InitializeComponent();
            _profesor = new Profesor();
        }

        public frmSubjects(Profesor profesor) : this()
        {
            dgvPredmeti.AutoGenerateColumns = false;
            _profesor = profesor;
        }

        private void frmSubjects_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvPredmeti.DataSource = null;
                dgvPredmeti.DataSource = konekcijaNaBazu.Predmeti;
                lblShowingEntries.Text = "Showing " + konekcijaNaBazu.Predmeti.Count().ToString() + " entries";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }
    }
}
