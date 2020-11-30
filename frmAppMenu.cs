using SchoolApp.ChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class frmAppMenu : Form
    {
        private Button kliknutiTrenutno;
        private Form aktivnaForma;
        private Profesor _profesor;
        public frmAppMenu()
        {
            InitializeComponent();
            _profesor = new Profesor();
        }

        public frmAppMenu(Profesor profesor):this()
        {
            _profesor = profesor;
        }

        private void frmAppMenu_Load(object sender, EventArgs e)
        {
            lblUser.Text = _profesor.KorisnickoIme;
        }


        ///Method which opens up a child forms on button click
        private void OpenChildForm(Form childForma, object btnKliknuti)
        {
            if(aktivnaForma!=null)
                aktivnaForma.Close();
            AktivirajButton(btnKliknuti);
            aktivnaForma = childForma;
            childForma.TopLevel = false;
            childForma.FormBorderStyle = FormBorderStyle.None;
            childForma.Dock = DockStyle.Fill;
            panelDesktopPanel.Controls.Add(childForma);
            panelDesktopPanel.Tag = childForma;
            childForma.BringToFront();
            childForma.Show();
            lblTitle.Text = childForma.Text;
        }



        /// <summary>
        /// Disables and enables button on click for the current form
        /// </summary>
        private void DisableButton()
        {
            foreach (Control prosliButton in panelMenu.Controls)
                if(prosliButton.GetType() == typeof(Button))
                    prosliButton.BackColor = Color.FromArgb(51, 51, 76);
        }
        private void AktivirajButton(object btnKliknuti)
        {
            if (btnKliknuti != null)
            {
                if (kliknutiTrenutno != (Button)btnKliknuti)
                {
                    DisableButton();
                    kliknutiTrenutno = (Button)btnKliknuti;
                }
            }
        }




        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHome(), sender);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNotifications(), sender);
        }
    }
}
