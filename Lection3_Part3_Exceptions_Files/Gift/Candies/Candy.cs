using System;

namespace Lection3_Part3_Exceptions_Files.Candies
{
    [Serializable]
    public class Candy : ISweets
    {
        protected Candy(string type, string subType, string name, int price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Type = type;
            SubType = subType;
        }

        public string SubType { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return string.Format("Candy {0} {4}, name '{1}', weight - {2}, price - {3}", Type, Name, Weight, Price, SubType);
        }
        
    }
}
