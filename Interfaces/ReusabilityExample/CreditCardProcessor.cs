// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define the namespace for the class
namespace Interfaces.ReusabilityExample
{
    // "CreditCardProcessor" class implementing the "IPaymentProcessor" interface
    // This class processes payments using credit cards
    public class CreditCardProcessor : IPaymentProcessor
    {
        // Method to process the payment
        // This method always returns void and takes a single decimal parameter (the payment amount)
        public void ProcessPayment(decimal amount)
        {
            // Display the payment amount being processed with a credit card
            Console.WriteLine($"Processing credit card payment of {amount}");

            // Placeholder for the actual credit card payment logic
        }
    }
}