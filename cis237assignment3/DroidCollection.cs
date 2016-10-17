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
            droids[currentIndex] = new ProtocolDroid(DroidModel, DroidMaterial, DroidColor, NoOfLanguages);
            currentIndex++;
        }

        public void addDroid(string DroidModel, string DroidMaterial, string DroidColor, bool HasToolbox, bool HasComputer, bool HasArm, bool HasTrash, bool HasVacuum)
        {
            droids[currentIndex] = new JanitorDroid(DroidModel, DroidMaterial, DroidColor, HasToolbox, HasComputer, HasArm, HasTrash, HasVacuum);
            currentIndex++;
        }

        public void addDroid(string DroidModel, string DroidMaterial, string DroidColor, bool HasToolbox, bool HasComputer, bool HasArm, bool HasExtinguisher, int NumberShips)
        {
            droids[currentIndex] = new AstromechDroid(DroidModel, DroidMaterial, DroidColor, HasToolbox, HasComputer, HasArm, HasExtinguisher, NumberShips);
            currentIndex++;
        }

        public void PrintDroidList()
        {
            
            int indexCounter = 0;

            while (indexCounter < currentIndex)
            {                
                    Console.WriteLine(droids[indexCounter].ToString());
                    indexCounter++;               
            }
            Console.WriteLine("End of List");
        }

        public string PrintCurrentDroid()
        {
            return droids[currentIndex - 1].ToString();
        }

     
    }
}
