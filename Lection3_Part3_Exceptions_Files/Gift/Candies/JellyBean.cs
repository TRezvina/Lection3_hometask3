
namespace Lection3_Part3_Exceptions_Files.Candies
{
    public class JellyBean : Candy
    {
        private const string CandyType = "Jelly Bean";
        public JellyBean(string subType, string name, int price, double weight, string shape, string taste)
            : base(CandyType, subType, name, price, weight)
        {
            Shape = shape;
            Taste = taste;
        }
        string Shape { get; set; }
        string Taste { get; set; }
        public override string ToString()
        {
            return string.Format("Jelly Bean Candy {0}, '{1}', weight - {2}, price - {3}", SubType, Name, Weight, Price);
        }
    }
}
