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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void panelUserInfo_Paint(object sender, PaintEventArgs e)
        {
          ControlPaint.DrawBorder(e.Graphics,panelUserInfo.ClientRectangle, Color.FromArgb(30, 115, 172),ButtonBorderStyle.Solid);
        }
    }
}
