using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Chocolate_Candy
{
    public abstract class ChocolateCandyWithFilling : ChocolateCandy
    {
        private const string CandySubType = "with filling";

        protected ChocolateCandyWithFilling(string name, string filling, int price, double weight) : base(name, price, weight, CandySubType)
        {
            Filling = filling;
        }
        public string Filling { get; set; }
    

    public override string ToString()
        {
            return string.Format("Chocolate Candy '{1}', {0} {2}, weight: {3}, price: {4}", CandySubType, Name, Filling, Weight, Price);
        }
    }
}
