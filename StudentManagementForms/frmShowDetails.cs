using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.StudentManagementForms
{
    public partial class frmShowDetails : Form
    {
        private Student _student;
        public frmShowDetails()
        {
            InitializeComponent();
            _student = new Student();
        }

        public frmShowDetails(Student student) : this()
        {
            _student = student;
        }

        private void frmShowDetails_Load(object sender, EventArgs e)
        {
            UcitajPodatke(_student);
        }
        private void UcitajPodatke(Student student)
        {
            lblStudentHeader.Text = student.Ime +" " + student.Prezime + " details";
            lblBrojIndeksa.Text = student.BrojIndeksa;
            lblIme.Text = student.Ime;
            lblPrezime.Text = student.Prezime;
            lblDatumRodjenja.Text = student.DatumRodjenja;
            lblSpol.Text = student.Spol;
            lblEmail.Text = student.Email;
            lblGodinaStudija.Text = student.GodinaStudija;
            lblGodine.Text = student.Godine.ToString();
            lblImeOca.Text = student.ImeOca;
            if (ImageConventer.FromByteToImage(student.Slika)!=null)
                pbSlikaStudenta.Image = ImageConventer.FromByteToImage(student.Slika);
            else
                pbSlikaStudenta.Image = null;
        }
    }
}
