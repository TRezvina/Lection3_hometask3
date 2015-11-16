using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lection3_Part3_Exceptions_Files.Candies;

namespace Lection3_Part3_Exceptions_Files.Candies
{
[Serializable]
    public class Sweets : Candy
    {
    public Sweets(string type, string subType, string name, int price, double weight, string additionalParam1, string additionalParam2, string additionalParam3)
        : base(type, subType, name, price, weight)
    {
        Param1 = additionalParam1;
        Param2 = additionalParam2;
        Param3 = additionalParam3;
    }
    public string Param1 { get; set; }
    public string Param2 { get; set; }
    public string Param3 { get; set; }
    }
}
