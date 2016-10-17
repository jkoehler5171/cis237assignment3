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
            base(DroidModel, DroidMaterial, DroidColor)
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

        public override void CalculateTotalCost()
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

        public override string ToString()
        {
            return base.ToString() + " ToolBox: " + this._hasToolbox + " Computer Interface: " + this._hasToolbox + " Utility Arm: " + this._hasToolbox;
        }
    }
}
