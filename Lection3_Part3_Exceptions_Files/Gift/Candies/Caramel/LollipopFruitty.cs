using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Caramel
{
    public class LollipopFruitty : CaramelLollipop
    {
        private const string LollipopSubType = "Friutty";
        public LollipopFruitty(string name, int price, double weight)
            : base(name, price, weight, LollipopSubType)
        {
        }
    }
}
