using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    public class Payment
    {
        int sum;
        string details;
        bool done = false;

        public Payment(int sum, string details)
        {
            this.sum = sum;
            this.details = details;
        }

        public void doPayment()
        {
            Console.WriteLine($"Done payment of {sum}: {details}");
            done = true;
        }

        public void showInfo()
        {
            Console.WriteLine($"Sum: {sum}, Details: {details}, Done: {done}");
        }
    }

    public class Bank
    {
        public void doPayment(Payment payment)
        {
            payment.doPayment();
        }
    }
}
