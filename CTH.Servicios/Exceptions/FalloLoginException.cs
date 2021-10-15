using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTH.Servicios
{
    public class FalloLoginException : Exception
    {

        public FalloLoginException(string message) 
        {
            MessageBox.Show(message);
        }
    }
}
