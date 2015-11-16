namespace ConsoleApplication_NewYearGift.Sweets.Iris
{
    public class IrisWithFilling : Iris
    {
        private const string SubType = "with filling";
        public IrisWithFilling(string name, string filling, int price, double weight)
            : base(name, price, weight, SubType)
        {
            Filling = filling;
        }
        public string Filling { get; set; }

        public override string ToString()
        {
            return string.Format("Iris Candy {0} {4} '{1}', weight - {2}, price - {3}", CandySubType, Name, Weight, Price, Filling);
        }
    }
}
