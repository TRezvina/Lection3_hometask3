using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Caramel
{
    public class CaramelInChocolate : Caramel
    {
        private const string CandyType = "In Chocolate";
        public CaramelInChocolate(string name, int price, double weight)
            : base(name, price, weight, CandyType)
        {
        }
    }
}
