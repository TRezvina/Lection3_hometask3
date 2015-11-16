namespace Lection3_Part3_Exceptions_Files.Candies
{
     public class Iris : Candy
    {
        private const string CandyType = "Iris";

         public Iris(string subType, string name, int price, double weight, string taste, string filling)
            : base(CandyType, subType, name, price, weight)
        {
            Taste = taste;
            Filling = filling;
        }
        public string Taste { get; set; }
        public string Filling { get; set; }

        public override string ToString()
        {
            return string.Format("Iris Candy {0}, '{1}', weight - {2}, price - {3}", SubType, Name, Weight, Price);
        }
    }
}
