using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class JanitorDroid: UtilityDroid
    {
        private bool _hasTrashCompactor;
        private bool _hasVacuum;

        public JanitorDroid(string DroidModel, string DroidMaterial, string DroidColor, bool HasToolbox, bool HasComputer, bool HasArm, bool HasTrash, bool HasVacuum)
            :base (DroidModel, DroidMaterial, DroidColor,HasToolbox, HasComputer,HasArm)
        {
            this._hasTrashCompactor = HasTrash;
            this._hasVacuum = HasVacuum;
        }

        public bool HasTrash
        {
            get { return _hasTrashCompactor; }
            set { _hasTrashCompactor = value; }
        }

        public bool HasVacuum
        {
            get { return _hasVacuum; }
            set { _hasVacuum = value; }
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            if(_hasTrashCompactor)
            {
                _totalCost += 150;
            }
            if(_hasVacuum)
            {
                _totalCost += 50;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Trash Compactor: " + this._hasTrashCompactor + " Vacuum: " + this._hasTrashCompactor +
                " Base Cost: " + _baseCost + " Total Cost: " + _totalCost;
        }

    }
}
