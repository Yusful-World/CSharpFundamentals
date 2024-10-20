using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshInt_AccessModifiers
{
    public class Program
    {
        public class GoldCustomer : Customer
        {
            public void OfferVoucher()
            {

            }
        }

        static void Main(string[] args)
        {
            var customer = new Customer();

        }
    }
}
