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
    public partial class frmLanguage : Form
    {
        Profesor _professor;
        public frmLanguage()
        {
            InitializeComponent();
        }
        public frmLanguage(Profesor profesor) : this()
        {
            _professor = profesor;
        }
    }
}
