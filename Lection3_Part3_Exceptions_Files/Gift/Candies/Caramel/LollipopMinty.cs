using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Caramel
{
    public class LollipopMinty : CaramelLollipop
    {
        private const string LollipopSubType = "Milky";
        public LollipopMinty(string name, int price, double weight)
            : base(name, price, weight, LollipopSubType)
        {
        }
    }
}
