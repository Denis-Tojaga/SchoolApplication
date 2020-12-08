using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

        private void frmSendMail_Load(object sender, EventArgs e)
        {

        }

        private void cmbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtToUser.Text = (cmbStudenti.SelectedItem as Student).GetIndeks() + "@edu.fit.ba";
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                string file = ofdFile.FileName;

                // Create  the file attachment for this email message.
                Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);

                // Add time stamp information for the file.
                ContentDisposition disposition = data.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(file);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
                // Add the file attachment to this email message.


                txtAttachment.Text = data.Name.ToString();
                data.Dispose();
            }else
                MessageBox.Show($"Something went wrong...:/");
        }
    }
}
