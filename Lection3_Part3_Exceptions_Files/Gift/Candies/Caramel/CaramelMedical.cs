using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Caramel
{
    public class CaramelMedical : Caramel
    {
        public const string CandyType = "Medical";
         public CaramelMedical(string name, int price, double weight)
            : base(name, price, weight, CandyType)
        {
        }
    }
}
