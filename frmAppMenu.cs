﻿using SchoolApp.ChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
           lblCurrentUser.Text += _profesor.KorisnickoIme;
        }


        ///Method which opens up a child forms on button click
        private void OpenChildForm(Form childForma, object btnKliknuti)
        {
            aktivnaForma?.Close();
            AktivirajButton(btnKliknuti);
            (btnKliknuti as Button).BackColor = Color.FromArgb(30, 115, 172);
            aktivnaForma = childForma;
            childForma.TopLevel = false;
            childForma.FormBorderStyle = FormBorderStyle.None;
            childForma.Dock = DockStyle.Fill;
            panelDesktopPanel.Controls.Add(childForma);
            panelDesktopPanel.Tag = childForma;
            childForma.BringToFront();
            childForma.Show();
            lblTitle.Text = childForma.Text;
            lblTitle.BackColor = Color.FromArgb(30, 115, 172);
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
                if (kliknutiTrenutno != (Button)btnKliknuti)
                {
                    DisableButton();
                    kliknutiTrenutno = (Button)btnKliknuti;
                }
        }




        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome(_profesor);
            OpenChildForm(homeForm, sender);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            frmNotifications notificationForm = new frmNotifications(_profesor);
            OpenChildForm(notificationForm, sender);
            
        }

        private void lblLinkStranice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://fit.ba/");
            Process.Start(sInfo);
        }
    }
}
