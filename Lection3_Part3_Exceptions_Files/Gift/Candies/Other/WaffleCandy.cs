using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Other
{
    public class WaffleCandy : Candy
    {
        private const string CandyType = "Waffle candy";
        public WaffleCandy(string name, int price, double weight)
            : base(name, price, weight, CandyType)
        {
        }
    }
}
