// Import required namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define the namespace
namespace Interfaces.ReusabilityExample
{
    // "PaypalProcessor" class implementing the "IPaymentProcessor" interface
    public class PaypalProcessor : IPaymentProcessor
    {
        // Method to process the payment
        // This method always returns void and takes a single parameter: the payment amount (decimal)
        public void ProcessPayment(decimal amount)
        {
            // Output the payment amount using PayPal
            Console.WriteLine($"Processing PayPal payment of {amount}");

            // Payment logic specific to PayPal would go here
        }
    }
}
