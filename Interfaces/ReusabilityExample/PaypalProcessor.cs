using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.ReusabilityExample
{
    // Always the dame structure, it always does return void and it always take one parameter which is the decimal amount
    public class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing paypal payment of {amount} ");
            // Implement paypal payment logic.
        }
    }
}
