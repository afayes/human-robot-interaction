using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace interaction
{
    /*
     * The is the main class that starts the program
     * 
     */
    class Program
    {
        // the main method 
        [STAThread]
        static void Main()
        {
            Application.Run(new MainMenuGUI());
         
        }
    }
}
