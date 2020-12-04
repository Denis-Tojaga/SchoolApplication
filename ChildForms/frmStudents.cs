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
            btnCancelSearch.Hide();
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
        private void btnCheckDetails_Click(object sender, EventArgs e)
        {
            var odabraniStudent = dgvStudents.SelectedRows[0].DataBoundItem as Student;
            if (odabraniStudent != null)
            {
                frmShowDetails detaljiForma = new frmShowDetails(odabraniStudent);
                detaljiForma.ShowDialog();
            }
        }








        /// <summary>
        /// Allows user to only search by one filer by changing its value everytime something else is checked
        /// </summary>
        private void rbPoIndeksu_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPoIndeksu.Checked)
            {
                rbPoGodiniStudija.Checked = false;
                rbPoImenu.Checked = false;
                btnCancelSearch.Show();
            }
        }
        private void rbPoImenu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoImenu.Checked)
            {
                rbPoGodiniStudija.Checked = false;
                rbPoIndeksu.Checked = false;
                btnCancelSearch.Show();
            }

        }
        private void rbPoGodiniStudija_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoGodiniStudija.Checked)
            {
                rbPoIndeksu.Checked = false;
                rbPoImenu.Checked = false;
                btnCancelSearch.Show();
            }

        }

       







        /// <summary>
        /// Uses one of methods for selected search mode
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Pretraga();
        }
        private void Pretraga()
        {
            if (rbPoIndeksu.Checked)
            {
                PretragaPoIndeksu();
                txtFilter.Text = "";
            }
            else if (rbPoImenu.Checked)
            {
                PretragaPoImenu();
                txtFilter.Text = "";
            }
            else if (rbPoGodiniStudija.Checked)
            {
                PretragaPoGodiniStudija();
                txtFilter.Text = "";
            }
            else
                MessageBox.Show($"Please select search mode!");
        }









        /// <summary>
        /// Search methods for all cases
        /// </summary>
        private void PretragaPoGodiniStudija()
        {
            var rezultat = konekcijaNaBazu.Studenti.Where(student => student.GodinaStudija.Contains(txtFilter.Text));
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = rezultat.ToList();
        }
        private void PretragaPoImenu()
        {
            var rezultat = konekcijaNaBazu.Studenti.Where(student => student.Ime==txtFilter.Text);
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = rezultat.ToList();
        }
        private void PretragaPoIndeksu()
        {
            var rezultat = konekcijaNaBazu.Studenti.Where(student => student.BrojIndeksa.Contains(txtFilter.Text.ToUpper()));
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = rezultat.ToList();
        }





        /// <summary>
        /// Cancels all search and resets data grid to default data
        /// </summary>
        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            rbPoIndeksu.Checked = false;
            rbPoImenu.Checked = false;
            rbPoGodiniStudija.Checked = false;
            UcitajPodatke();
            btnCancelSearch.Hide();
        }



        /// <summary>
        /// Allows user to press enter instead of clicking on search button
        /// </summary>
        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Pretraga();
                e.SuppressKeyPress = true;
            }
        }
    }
}
