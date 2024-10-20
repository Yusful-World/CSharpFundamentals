using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshFund_Conditionals
{
    public class Program
    {
        static void Main(string[] args)
        {
            DayTime.DayTimeFormat();
            Customer.IsNotGoldCustomer();
            Customer.GoldCustomer();
            Seasons.IsSeason();


        }
    }
}
