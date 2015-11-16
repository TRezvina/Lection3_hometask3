namespace Lection3_Part3_Exceptions_Files.Candies
{
    public class ChocolateCandy : Candy
    {
        const string CandyType = "Chocolate Candy";

        public ChocolateCandy(string subType, string name, int price, double weight, string chocolate, string filling)
            : base(CandyType, subType, name, price, weight)
        {
            Filling = filling;
            Chocolate = chocolate;
        }

        public string Filling { get; set; }
        public string Chocolate { get; set; }

        public override string ToString()
        {
            return string.Format("Chocolate Candy {0} '{1}', weight - {2}, price - {3}", SubType, Name, Weight, Price);
        }
    }
}
