// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define the namespace for the class
namespace Interfaces.ReusabilityExample
{
    // PaymentService class handles payment operations
    public class PaymentService
    {
        // Read-only field for the payment processor
        private readonly IPaymentProcessor _processor;

        // Constructor that initializes the payment processor
        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        // Method to process a payment with the specified amount
        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }
}
