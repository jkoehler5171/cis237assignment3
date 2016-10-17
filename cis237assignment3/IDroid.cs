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
    interface IDroid
    {
        void CalculateTotalCost(); //I didn't put these here as you know, but I needed to implement them inside of Droid.

        decimal TotalCost { get; set; }
    }
}
