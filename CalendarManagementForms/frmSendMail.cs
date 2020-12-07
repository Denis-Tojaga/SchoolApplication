using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.CalendarManagementForms
{
    public partial class frmSendMail : Form
    {
        DatabaseConnection konekcijaNaBazu = new DatabaseConnection();
        private Profesor _profesor;
        public frmSendMail()
        {
            InitializeComponent();
            _profesor = new Profesor();
        }

        public frmSendMail(Profesor profesor) : this()
        {
            _profesor = profesor;
            UcitajCMBStudente();
        }

        private void UcitajCMBStudente()
        {
            var studenti = konekcijaNaBazu.Studenti;
            cmbStudenti.DataSource = studenti.ToList();
            cmbStudenti.DisplayMember = "BrojIndeksa";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (ValidnaPolja())
            {
                Email newMail = new Email();
                newMail.Sender = _profesor.Email;
                newMail.Reciever = txtToUser.Text;
                newMail.Content = txtContent.Text;
                // newMail.File = 
                DialogResult = DialogResult.OK;
                MessageBox.Show($"Email send successfully");
                Close();
            }
        }

        private bool ValidnaPolja()
        {
            return Validator.ValidirajPolje(txtToUser, err, "This field is required!") && Validator.ValidirajPolje(txtContent, err, "This field is required!")
                 && Validator.ValidirajPolje(txtSubject, err, "This field is required!") && Validator.ValidirajPolje(cmbStudenti, err, "This field is required!");
        }

        private Attachment btnAttachment_Click(object sender, EventArgs e)
        {
            if(ofdFile.ShowDialog() == DialogResult.OK)
            {
                var file = Attachment.CreateAttachmentFromString(ofdFile.FileName, MediaTypeNames.Application.Octet);
                return file;
            }
            return null;
        }

        private void frmSendMail_Load(object sender, EventArgs e)
        {

        }

        private void cmbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtToUser.Text = (cmbStudenti.SelectedItem as Student).GetIndeks() + "@edu.fit.ba";
        }
    }
}
