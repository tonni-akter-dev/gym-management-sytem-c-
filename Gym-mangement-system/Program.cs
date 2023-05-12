using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_mangement_system;

internal class Program
{
    static void Main(string[] args)
    {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Login());
    }
}
