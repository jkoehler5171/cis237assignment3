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
    class DroidCollection
    {
        IDroid[] droids = new Droid[100];

        int currentIndex;

        public DroidCollection() // Constructor for Droid Collection.
        {
          currentIndex = 0;
        }

        public void addDroid(string DroidModel, string DroidMaterial, string DroidColor, int NoOfLanguages)//Add Method for Protocol Droids
        {
            droids[currentIndex] = new ProtocolDroid(DroidModel, DroidMaterial, DroidColor, NoOfLanguages);
            currentIndex++;
        }

        public void addDroid(string DroidModel, string DroidMaterial, string DroidColor, bool HasToolbox, bool HasComputer, bool HasArm, bool HasTrash, bool HasVacuum)//Add Method for Janitor Droids
        {
            droids[currentIndex] = new JanitorDroid(DroidModel, DroidMaterial, DroidColor, HasToolbox, HasComputer, HasArm, HasTrash, HasVacuum);
            currentIndex++;
        }

        public void addDroid(string DroidModel, string DroidMaterial, string DroidColor, bool HasToolbox, bool HasComputer, bool HasArm, bool HasExtinguisher, int NumberShips)// Add Method for Astromech Droids.
        {
            droids[currentIndex] = new AstromechDroid(DroidModel, DroidMaterial, DroidColor, HasToolbox, HasComputer, HasArm, HasExtinguisher, NumberShips);
            currentIndex++;
        }

        public void PrintDroidList()// Prints the current array of Droids.
        {
            
            int indexCounter = 0;

            while (indexCounter < currentIndex)
            {                
                    Console.WriteLine(droids[indexCounter].ToString());
                    indexCounter++;               
            }
            Console.WriteLine("End of List");
        }

        public string PrintCurrentDroid()//Prints the most recently added droid.
        {
            return droids[currentIndex - 1].ToString();
        }

     
    }
}
