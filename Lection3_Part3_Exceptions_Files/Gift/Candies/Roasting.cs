namespace Lection3_Part3_Exceptions_Files.Candies
{
    public class Roasting : Candy
    {
        private const string CandyType = "Grilayzh";
        public Roasting(string subType, string name, int price, double weight, string nuts)
            : base(CandyType, subType, name, price, weight)
        {
            Nuts = nuts;
        }
        string Nuts { get; set; }
        public override string ToString()
        {
            return string.Format("Roasting Candy {0}, '{1}',nuts {4}, weight - {2}, price - {3}", SubType, Name, Weight, Price, Nuts);
        }

    }
}
