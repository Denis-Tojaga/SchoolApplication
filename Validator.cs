using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp
{
    public class Validator
    {
        public static bool ValidirajPolje(Control control,ErrorProvider err,string message)
        {
            bool validno = true;
            if(control is TextBox && string.IsNullOrEmpty((control as TextBox).Text))
                validno = false;
            else if(control is PictureBox && (control as PictureBox).Image==null)
                validno = false;

            if(!validno)
            {
                err.SetError(control, message);
                return false;
            }else
            {
                err.Clear();
                return true;
            }
        }
    }
}
