using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Iris
{
    public class IrisCream : Iris
    {
        private const string SubType = "Cream iris";
        public IrisCream(string name, int price, double weight)
            : base(name, price, weight, SubType)
        {
        }
    }
}
