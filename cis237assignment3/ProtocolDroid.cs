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
    class ProtocolDroid : Droid
    {
        private int _numberOfLanguages;

        private const int PRICE_PER_LANGUAGE = 200;


        //Constructor for Protocol Droids. Inherits from Droid.
        public ProtocolDroid(string DroidModel, string DroidMaterial, string DroidColor, int NoOfLanguages):base(DroidModel, DroidMaterial, DroidColor)
        {
            this._numberOfLanguages = NoOfLanguages;
            CalculateTotalCost();
        }

        public int NoOfLangauges
        {
            get { return _numberOfLanguages; }
            set { _numberOfLanguages = value; }
        }

        public override void CalculateTotalCost()// Calculates total cost. Inherits from Droid.
        {
            base.CalculateTotalCost();
            _totalCost += (_numberOfLanguages * PRICE_PER_LANGUAGE);
        }

        public override string ToString()// Override for ToString.
        {
            return base.ToString() + " # of Languages: " + this._numberOfLanguages + " Base Cost: " + _baseCost + " Total Cost : " + _totalCost; 
        }

        

    }
}
