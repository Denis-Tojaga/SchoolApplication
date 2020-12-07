using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.SubjectManagementForms
{
    public partial class frmAddSubject : Form
    {
        DatabaseConnection konekcijaNaBazu = new DatabaseConnection();
        private const string Upozorenje = "This field is required!";
        public frmAddSubject()
        {
            InitializeComponent();
            UcitajProfesoreUCMB();

        }
        private void frmAddSubject_Load(object sender, EventArgs e)
        {
            GenerateSubjectCode();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        /// <summary>
        /// Loads all DB professors to combo box Professors
        /// </summary>
        private void UcitajProfesoreUCMB()
        {
            try
            {
                var profesori = konekcijaNaBazu.Profesori;
                cmbProfesori.DataSource = profesori.ToList();
                cmbProfesori.DisplayMember = "Ime";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }

        private void btnImportSyllabus_Click(object sender, EventArgs e)
        {
            if(ofdOdabirSlike.ShowDialog() == DialogResult.OK)
                pbSyllabusPic.Image = Image.FromFile(ofdOdabirSlike.FileName);
        }






        /// <summary>
        /// Adds new subject with all his data in DB
        /// </summary>
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if(ValidirajPolja())
            {
                konekcijaNaBazu.Predmeti.Add(new Predmet()
                {
                    PredmetCode = txtSubjectCode.Text,
                    NazivPredmeta = txtSubjectName.Text,
                    GodinaStudija = cmbYearOfStudy.SelectedItem.ToString(),
                    ECTS = int.Parse(txtECTS.Text),
                    BrojSatiPredavanja = int.Parse((cmbLessonHours.SelectedItem).ToString()),
                    BrojSatiVjezbi = int.Parse((cmbPracticeHours.SelectedItem).ToString()),
                    Profesor = (cmbProfesori.SelectedItem as Profesor).ToString(),
                    Dogadjaj=txtAction.Text,
                    Syllabus = ImageConventer.FromImageToByte(pbSyllabusPic.Image)
                });
                konekcijaNaBazu.SaveChanges();
                MessageBox.Show($"Subject {txtSubjectName.Text} successfully added!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }








        /// <summary>
        /// Validates all controls in the form
        /// </summary>
        private bool ValidirajPolja()
        {
            return Validator.ValidirajPolje(txtSubjectName, err, Upozorenje) && Validator.ValidirajPolje(cmbYearOfStudy, err, Upozorenje) &&
                 Validator.ValidirajPolje(txtECTS, err, Upozorenje) && Validator.ValidirajPolje(cmbPracticeHours, err, Upozorenje) &&
                 Validator.ValidirajPolje(cmbLessonHours, err, Upozorenje) && Validator.ValidirajPolje(cmbProfesori, err, Upozorenje)
                 && Validator.ValidirajPolje(txtAction, err, Upozorenje) && Validator.ValidirajPolje(pbSyllabusPic, err, Upozorenje);
        }







        /// <summary>
        /// Generates subject code
        /// </summary>
        private void GenerateSubjectCode()
        {
            Random random = new Random();
            for (int i = 0; i < 4; i++)
                txtSubjectCode.Text += random.Next(10, 100);
        }

        
    }
}
