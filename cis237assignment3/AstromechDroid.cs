using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AstromechDroid: UtilityDroid
    {
        private bool _hasFireExtinguisher;
        private int _numberOfShips;

        private int COST_PER_SHIP = 50;

        public AstromechDroid(string DroidModel, string DroidMaterial, string DroidColor, bool HasToolbox, bool HasComputer, bool HasArm, bool HasExtinguisher, int NumberShips)
            :base(DroidModel, DroidMaterial, DroidColor,HasToolbox, HasComputer, HasArm)
        {
            this._hasFireExtinguisher = HasExtinguisher;
            this._numberOfShips = NumberShips;
            CalculateTotalCost();
        }
        
        public bool HasExtinguisher
        {
            get { return _hasFireExtinguisher; }
            set { _hasFireExtinguisher = value; }
        }

        public int NumberShips
        {
            get { return _numberOfShips; }
            set { _numberOfShips = value; }
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            if(_hasFireExtinguisher)
            {
                _totalCost += 100;
            }
            _totalCost += (_numberOfShips * COST_PER_SHIP);

        }

        public override string ToString()
        {
            return base.ToString() + " Fire Extinguisher: " + this._hasFireExtinguisher + " # Of Compatible Ships: " + this._numberOfShips +
                " Base Cost: " + _baseCost + " Total Cost: " + _totalCost;
        }

    }
}
