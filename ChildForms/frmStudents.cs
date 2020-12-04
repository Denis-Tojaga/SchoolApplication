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
            lbViewOf.Text += " " + _user.KorisnickoIme;
            UcitajPodatke();
        }


        /// <summary>
        /// Loads all students to data grid, if there are no any its shows up message
        /// </summary>
        private void UcitajPodatke()
        {
            lblMessage.Hide();
            try
            {
                var studenti = konekcijaNaBazu.Studenti;
                if (studenti.Count() != 0)
                {
                    dgvStudents.DataSource = null;
                    dgvStudents.DataSource = studenti.ToList();
                }else
                {
                    dgvStudents.Hide();
                    lblMessage.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }



        /// <summary>
        /// Opens up new form which let us add new student and all his data
        /// </summary>
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddStudent dodajForma = new frmAddStudent();
                if (dodajForma.ShowDialog() == DialogResult.OK)
                    UcitajPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }
    }
}
