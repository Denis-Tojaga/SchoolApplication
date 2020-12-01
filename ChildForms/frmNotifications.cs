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
    public partial class frmNotifications : Form
    {
        Profesor _user;
        public frmNotifications()
        {
            InitializeComponent();
        }

        public frmNotifications(object user ) : this()
        {
            _user = user as Profesor;
        }
    }
}
