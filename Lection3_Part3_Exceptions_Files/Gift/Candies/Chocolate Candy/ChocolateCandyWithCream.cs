using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Chocolate_Candy
{
    class ChocolateCandyWithCream : ChocolateCandyWithFilling
    {
        private const string CandyFilling = "Cream";
        public ChocolateCandyWithCream(string name, int price, double weight) : base(name, CandyFilling, price, weight)
        {
        }
    }
}
