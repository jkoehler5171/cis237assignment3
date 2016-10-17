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

        public ProtocolDroid(string DroidModel, string DroidMaterial, string DroidColor, int NoOfLanguages):base(DroidModel, DroidMaterial, DroidColor)
        {
            this._numberOfLanguages = NoOfLanguages;
        }

        public int NoOfLangauges
        {
            get { return _numberOfLanguages; }
            set { _numberOfLanguages = value; }
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            _totalCost += (_numberOfLanguages * PRICE_PER_LANGUAGE);
        }

        public override string ToString()
        {
            return base.ToString() + " # of Languages: " + this._numberOfLanguages + " Base Cost: " + _baseCost + " Total Cost: " + _totalCost;
        }

        

    }
}
