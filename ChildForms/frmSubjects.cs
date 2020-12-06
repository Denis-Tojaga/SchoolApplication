using SchoolApp.SubjectManagementForms;
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
        List<int> brojPolja = new List<int>();
        List<string> godineStudija = new List<string>();
        bool ValidniBoxovi = false;


        //Loads all data to combo boxes
        public frmSubjects()
        {
            InitializeComponent();
            _profesor = new Profesor();
            UcitajComboBoxove();
        }
        public frmSubjects(Profesor profesor) : this()
        {
            btnAddSubject.Text = "Add exam";
            dgvPredmeti.AutoGenerateColumns = false;
            _profesor = profesor;
        }




        /// <summary>
        /// Loads combo boxes and their values
        /// </summary>
        private void UcitajComboBoxove()
        {
            DodajGodineIBrojPolja();
            cmbBrojPolja.DataSource = brojPolja;
            cmbGodinaStudija.DataSource = godineStudija;
        }
        private void DodajGodineIBrojPolja()
        {
            brojPolja.Add(2);
            brojPolja.Add(5);
            brojPolja.Add(10);
            godineStudija.Add("Default");
            godineStudija.Add("Prva godina");
            godineStudija.Add("Druga godina");
            godineStudija.Add("Treca godina");
            godineStudija.Add("Cetvrta godina");
            godineStudija.Add("Master");
        }





        //Gets the data from database and selected values in combo boxes, so it does search by default
        private void frmSubjects_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                lblDataCount.Hide();
                dgvPredmeti.DataSource = null;
                int brojPolja = int.Parse(cmbBrojPolja.SelectedItem.ToString());
                string godinaStudija = cmbGodinaStudija.SelectedItem.ToString();
                if (godinaStudija == "Default")
                {
                    UcitajSve();
                    return;
                }
                var predmeti = PrikaziPoGodStudijaPolja(godinaStudija);
                //prvo ucitamo predmete
                dgvPredmeti.DataSource = predmeti;
                //zatim sakrijemo redove koji nam ne trebaju
                for (int i = brojPolja; i <dgvPredmeti.Rows.Count; i++)
                    dgvPredmeti.Rows[i].Visible = false;
                lblShowingEntries.Text = "Showing " + predmeti.Count().ToString() + " entries";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }






        /// <summary>
        /// Loads all subject by default
        /// </summary>
        private void UcitajSve()
        {
            try
            {
                var predmeti = konekcijaNaBazu.Predmeti;
                dgvPredmeti.DataSource = null;
                dgvPredmeti.DataSource = predmeti.ToList();
                lblShowingEntries.Text = "Showing " + predmeti.Count().ToString() + " entries";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }






        /// <summary>
        /// Searches subjects in database by their year of study and entry fields
        /// </summary>
        private List<Predmet> PrikaziPoGodStudijaPolja(string godinaStudija)
        {
            return konekcijaNaBazu.Predmeti.Where(predmet =>predmet.GodinaStudija.Contains(godinaStudija)).ToList();
        }




        //Checks if selected value in combo boxes is valid, if not mbox appears
        private bool ProvjeriValidnostBoxova()
        {
            if (Validator.ValidirajPolje(cmbBrojPolja, err, "Vrijednost nije validna!") && Validator.ValidirajPolje(cmbGodinaStudija, err, "Vrijednost nije validna"))
            {
                ValidniBoxovi = true;
                return true;
            }
            return false;
        }





        //uses selected search parameters and search valid students within database
        private void btnTrazi_Click(object sender, EventArgs e)
        {
            if(ProvjeriValidnostBoxova())
            {
                LoadData();
                return;
            }
            MessageBox.Show($"Please choose the correct search parameters!");
        }






        /// <summary>
        /// Moves to next and previous row in data grid view
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dgvPredmeti.SelectedRows[0].Index;
                int zadnjiIndeks = PrebrojVidljive() -1;

                //Ako je red isto kao zadnji indeks i broj redova koji je baza vratila je 1 onda se prekida jer nema gdje ici 
                if (rowIndex == zadnjiIndeks && dgvPredmeti.Rows.Count == 1)
                    return;


                dgvPredmeti.Rows[rowIndex].Selected = false;
                if (rowIndex <= zadnjiIndeks)
                {
                    if(++rowIndex>zadnjiIndeks)
                    {
                        rowIndex = 0;
                        dgvPredmeti.Rows[rowIndex].Selected = true;
                        return;
                    }else
                        dgvPredmeti.Rows[rowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dgvPredmeti.SelectedRows[0].Index;
                int zadnjiIndeks = dgvPredmeti.RowCount - 1;



                if (rowIndex >= 0)
                {
                    dgvPredmeti.Rows[rowIndex].Selected = false;
                    if (rowIndex-- == 0)
                    {
                        rowIndex = zadnjiIndeks;
                        dgvPredmeti.Rows[rowIndex].Selected = true;
                        return;
                    }
                    else
                        dgvPredmeti.Rows[rowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }







        //Counts all visible rows
        private int PrebrojVidljive()
        {
            int brojac = 0;
            for (int i = 0; i < dgvPredmeti.Rows.Count; i++)
                if(dgvPredmeti.Rows[i].Visible)
                    brojac++;
            return brojac;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            frmAddSubject frmPredmetAdd = new frmAddSubject();
            if(frmPredmetAdd.ShowDialog() == DialogResult.OK)
                LoadData();
        }
    }
}
