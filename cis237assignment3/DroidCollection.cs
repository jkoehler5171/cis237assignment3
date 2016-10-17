using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        IDroid[] droids = new Droid[100];

        int currentIndex;

        public DroidCollection()
        {
          currentIndex = 0;
        }

        public void addDroid(string DroidModel, string DroidMaterial, string DroidColor, int NoOfLanguages)
        {
            droids[currentIndex++] = new ProtocolDroid(DroidModel, DroidMaterial, DroidColor, NoOfLanguages);
        }

        public void addDroid(string DroidModel, string DroidMaterial, string DroidColor, bool HasToolbox, bool HasComputer, bool HasArm, bool HasTrash, bool HasVacuum)
        {
            droids[currentIndex++] = new JanitorDroid(DroidModel, DroidMaterial, DroidColor, HasToolbox, HasComputer, HasArm, HasTrash, HasVacuum);
        }

        public void addDroid(string DroidModel, string DroidMaterial, string DroidColor, bool HasToolbox, bool HasComputer, bool HasArm, bool HasExtinguisher, int NumberShips)
        {
            droids[currentIndex++] = new AstromechDroid(DroidModel, DroidMaterial, DroidColor, HasToolbox, HasComputer, HasArm, HasExtinguisher, NumberShips);
        }

        public void PrintDroidList()
        {
            bool exitBoolean = false;
            int indexCounter = 0;

            while (exitBoolean != true)
            {
                if(droids[indexCounter].ToString() != null)
                {
                    Console.WriteLine(droids[indexCounter].ToString());
                    indexCounter++;
                }
                else
                {
                    Console.WriteLine("End of List");
                    exitBoolean = true;
                }
            }
        }
    }
}
