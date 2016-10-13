using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Droid: IDroid
    {
        private string _droidMaterial; //For this I'm going to use Plastoid, Durasteel, and Bronzium (All Metals from the Star Wars MMO)
        private string _droidModel; // I think I'm going to set the model as the base type of droid AKA Protocol Astromech or Janitor
        private string _droidColor;

        private decimal _baseCost; // I guess for this I'm going to determine it based on material and model, Color is just an option I think.
        private decimal _totalCost;

    }
}
