using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.SettingsManagementForms
{
    public partial class frmPrivacy : Form
    {
        Profesor _professor;
        public frmPrivacy()
        {
            InitializeComponent();
        }

        public frmPrivacy(Profesor profesor)  : this()
        {
            _professor = profesor;
        }
    }
}
