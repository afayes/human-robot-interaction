using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace neuralNetwork
{
    public class Program
    {
        private static NeuralNetworkGUI neuralMainForm = new NeuralNetworkGUI();
        
        [STAThread]
        static void Main()
        {
            Application.Run(neuralMainForm);
        }

        public static NeuralNetworkGUI getMainForm()
        {
            return neuralMainForm;
        }
    
    }
}
