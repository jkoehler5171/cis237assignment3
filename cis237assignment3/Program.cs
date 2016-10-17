using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            DroidCollection droids = new DroidCollection();

            UserInterface ui = new UserInterface(droids);

            ui.MainMenu(droids);

            Environment.Exit(0);

        }
    }
}
