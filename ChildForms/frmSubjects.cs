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
            godineStudija.Add("Prva godina");
            godineStudija.Add("Druga godina");
            godineStudija.Add("Treca godina");
            godineStudija.Add("Cetvrta godina");
            godineStudija.Add("Master");
        }






        private void frmSubjects_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        //Gets the data from database and selected values in combo boxes, so it does search by default
        private void LoadData()
        {
            try
            {
                lblDataCount.Hide();
                dgvPredmeti.DataSource = null;
                int brojPolja = int.Parse(cmbBrojPolja.SelectedItem.ToString());
                string godinaStudija = cmbGodinaStudija.SelectedItem.ToString();
                var predmeti = PrikaziPoBrojPolja(brojPolja, godinaStudija);
                dgvPredmeti.DataSource = predmeti;
                lblShowingEntries.Text = "Showing " + predmeti.Count().ToString() + " entries";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }

        private List<Predmet> PrikaziPoBrojPolja(int brojPolja,string godinaStudija)
        {
            return konekcijaNaBazu.Predmeti.Where(predmet => predmet.PredmetID <= brojPolja && predmet.GodinaStudija.Contains(godinaStudija)).ToList();
        }






        private bool ProvjeriValidnostBoxova()
        {
            if (Validator.ValidirajPolje(cmbBrojPolja, err, "Vrijednost nije validna!") && Validator.ValidirajPolje(cmbGodinaStudija, err, "Vrijednost nije validna"))
            {
                ValidniBoxovi = true;
                return true;
            }
            return false;
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            if(ProvjeriValidnostBoxova())
            {
                LoadData();
                return;
            }
            MessageBox.Show($"Please choose the correct search parameters!");
        }
    }
}
