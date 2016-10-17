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
    abstract class Droid: IDroid
    {
        protected string _droidMaterial; 
        protected string _droidModel; 
        protected string _droidColor;

        protected decimal _baseCost; 
        protected decimal _totalCost;

        public Droid (string DroidModel, string DroidMaterial, string DroidColor) //Basic Constructor for all Droid types.
        {
            this._droidModel = DroidModel;
            this._droidMaterial = DroidMaterial;
            this._droidColor = DroidColor;
            CalculateTotalCost();
        }
        
        public Droid()
        {

        }

        public string DroidModel
        {
            get { return _droidModel; }
            set { _droidModel = value; }
        }

        public string DroidMaterial
        {
            get { return _droidMaterial; }
            set { _droidMaterial = value; }            
        }

        public string DroidColor
        {
            get { return _droidColor; }
            set { _droidColor = value; }
        }

        public decimal TotalCost
        {
           get { return _totalCost; }
           set { _totalCost = value; }
        }

        public virtual void CalculateTotalCost()//Begins calculating Total Cost by setting the base cost. Base Cost is determined by Model and Material
        {
            switch(_droidModel)
            {
                case "Protocol":
                    _baseCost = 5000;
                    break;
                case "Janitor":
                    _baseCost = 1000;
                    break;
                case "Astromech":
                    _baseCost = 4000;
                    break;
                default:
                    break;
            }
            switch(_droidMaterial)
            {
                case "Plastoid":
                    _baseCost += 500;
                    break;
                case "Durasteel":
                    _baseCost += 1500;
                    break;
                case "Bronzium":
                    _baseCost += 5000;
                    break;
                default:
                    break;
            }

            _totalCost = _baseCost;
        }

       

        public override string ToString()//Basic ToString Override that all other droids start with.
        {
            return  "Model: " + this._droidModel + " Material:  " + this._droidMaterial + " Color: " + this._droidColor;
        }

    }
}
