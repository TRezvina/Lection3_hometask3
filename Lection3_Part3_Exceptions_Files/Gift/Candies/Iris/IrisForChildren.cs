using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Iris
{
    public class IrisForChildren: Iris
    {
        private const string SubType = "For children";
        public IrisForChildren(string name, int price, double weight)
            : base(name, price, weight, SubType)
        {
        }
    }
}
