using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Caramel
{
    public abstract class CaramelLollipop : Caramel
    {
        public const string CandyType = "Lollipop";
        public CaramelLollipop(string name, int price, double weight, string subType)
            : base(name, price, weight, CandyType)
        {
            LollipopType = subType;
        }
        public string LollipopType { get; set; }
        public override string ToString()
        {
            return string.Format("Caramel Candy {0} {1} '{2}', weight - {3}, price - {4}", CandySubType, LollipopType, Name, Weight, Price);
        }
    }
}
