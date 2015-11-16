using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets
{
    public class Milky : Candy
    {
        private const string CandyType = "Milky";
        public Milky(string name, int price, double weight)
            : base(name, price, weight, CandyType)
        {
        }
    }
}
