using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientConsoleApp
{
    class Program
    {
       // [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            //Application.Run(new CredentialWindowsForm()); // or whatever
           Application.Run(new HomeWindowsForm());
          
            // Application.Run(new GridViewButton());
        }
    }
}
