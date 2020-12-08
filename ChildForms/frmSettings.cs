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
    public partial class frmSettings : Form
    {
        Profesor _profesor;
        public frmSettings()
        {
            InitializeComponent();
            _profesor = new Profesor();
        }

        public frmSettings(Profesor profesor) : this()
        {
            _profesor = profesor;
        }


    }
}
