//Jordan Koehler
//TR 3:30 to 5:45
//Oct 17th 2016

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
            DroidCollection droids = new DroidCollection(); //Starts the Collection.

            UserInterface ui = new UserInterface(droids);//Starts the Interface.

            ui.MainMenu(droids);

            Environment.Exit(0);

        }
    }
}
