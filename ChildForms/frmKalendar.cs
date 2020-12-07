using SchoolApp.CalendarManagementForms;
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
    public partial class frmKalendar : Form
    {
        private Profesor _profesor;
        private DatabaseConnection konekcijaNaBazu = new DatabaseConnection();
        public frmKalendar()
        {
            InitializeComponent();
            _profesor = new Profesor();
        }

        public frmKalendar(Profesor profesor) : this()
        {
            _profesor = profesor;
        }

        private void frmKalendar_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = _profesor.KorisnickoIme;
            lblCountProfessors.Text = konekcijaNaBazu.Profesori.Count().ToString();
            lblCountStudents.Text = konekcijaNaBazu.Studenti.Count().ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            frmSendMail emailSend = new frmSendMail(_profesor);
            emailSend.ShowDialog();
        }
    }
}
