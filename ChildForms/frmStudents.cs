using SchoolApp.StudentManagementForms;
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
            DataGridViewColumn prvaKolona = dgvStudents.Columns[0];
            prvaKolona.HeaderCell.Style.BackColor = Color.White;
            prvaKolona.HeaderCell.Style.ForeColor = Color.FromArgb(37, 140, 219);
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            lbViewOf.Text += " " + _user.KorisnickoIme;
            try
            {
                var studenti = konekcijaNaBazu.Studenti;
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = studenti.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent dodajForma = new frmAddStudent();
            dodajForma.ShowDialog();
        }
    }
}
