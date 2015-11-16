using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Caramel
{
    public class LollipopWithFilling : CaramelLollipop
    {
        private const string LollipopSubType = "with filling";
        public LollipopWithFilling(string name, string filling, int price, double weight)
            : base(name, price, weight, LollipopSubType)
        {
            Filling = filling;
        }
        public string Filling { get; set; }

        public override string ToString()
        {
            return string.Format("Caramel Candy {0} {1} {2} '{3}', weight - {4}, price - {5}", CandyType, LollipopType, Filling, Name, Weight, Price);
        }
    }
}
