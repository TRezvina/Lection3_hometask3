namespace Lection3_Part3_Exceptions_Files.Candies
{
    public class Caramel : Candy
    {
        private const string CandyType = "Caramel";

        public Caramel(string subType, string name, int price, double weight, string taste, string filling, string cover)
            : base(CandyType, subType, name, price, weight)
        {
            Taste = taste;
            Cover = cover;
            Filling = filling;
        }

        public string Cover { get; set; }
        public string Taste { get; set; }
        public string Filling { get; set; }

        public override string ToString()
        {
            return string.Format("Caramel Candy {0} '{1}', weight - {2}, price - {3}", SubType, Name, Weight, Price);
        }
    }
}
