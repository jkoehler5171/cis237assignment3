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
    class UtilityDroid: Droid
    {
        protected bool _hasToolbox;
        protected bool _hasComputerConnector;
        protected bool _hasUtilityArm; 

        public UtilityDroid(string DroidModel, string DroidMaterial, string DroidColor, bool HasToolbox, bool HasComputer, bool hasArm): 
            base(DroidModel, DroidMaterial, DroidColor) //Constructor for Utility droids. Inherits from Droid.
        {
            this._hasToolbox = HasToolbox;
            this._hasComputerConnector = HasComputer;
            this._hasUtilityArm = hasArm;
            CalculateTotalCost();
        }

        public bool HasToolbox
        {
            get { return _hasToolbox; }
            set { _hasToolbox = value; }

        }

        public bool HasComputer
        {
            get { return _hasComputerConnector; }
            set { _hasComputerConnector = value; }
        }

        public bool HasArm
        {
            get { return _hasUtilityArm; }
            set { _hasUtilityArm = value; }
        }

        public override void CalculateTotalCost() //Method to calculate the total cost. Inherits from Droid.
        {
            base.CalculateTotalCost();
            if(_hasToolbox)
            {
                _totalCost += 300;
            }
            if(_hasComputerConnector)
            {
                _totalCost += 300;
            }
            if(_hasUtilityArm)
            {
                _totalCost += 350;
            }
        }

        public override string ToString() // Override for ToString.
        {
            if (_droidModel == "Utility")
            {
                return base.ToString() + " ToolBox: " + this._hasToolbox + " Computer Interface: " + this._hasToolbox + " Utility Arm: " + this._hasToolbox + 
                    " Base Cost: " + _baseCost + " Total Cost : " + _totalCost;
            }
            else
            {
                return base.ToString() + " ToolBox: " + this._hasToolbox + " Computer Interface: " + this._hasToolbox + " Utility Arm: " + this._hasToolbox;
            }
        }
    }
}
