using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets
{
    public class ChocolateCandyTruffle : ChocolateCandy
    {
        private const string CandySubType = "Truffle";
        public ChocolateCandyTruffle(string name, double weight, int price)
            : base(name, price, weight, CandySubType)
        {
            
        }

    }
}
