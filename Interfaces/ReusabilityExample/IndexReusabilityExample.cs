using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.ReusabilityExample
{
    // It makes sense to have these interfaces in seperate files, for educational purpose they are all in one file now
    // Always the same structure, it always does return void and it always take one parameter which is the decimal amount
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    // This class is an example that demonstrates the reusability of different payment processors.
    internal class IndexReusabilityExample
    {
        // Constructor of the class, automatically calls the method to demonstrate the example when an instance is created.
        public IndexReusabilityExample()
        {
            IndexReusabilityExampleMethod();
        }

        // This method demonstrates the reusability of the payment processor interface by using two different implementations:
        // 1. `CreditCardProcessor`
        // 2. `PaypalProcessor`
        private void IndexReusabilityExampleMethod()
        {
            // Creating an instance of `CreditCardProcessor` which implements `IPaymentProcessor`.
            // Polymorphisim
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();

            // Using the `creditCardProcessor` to process a payment through the `PaymentService` class.
            // The `PaymentService` class handles the actual payment logic using the provided processor.
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(100.00m); // Processes a payment of 100.00 using the credit card processor.

            // Switching to a different payment processor: `PaypalProcessor`.
            IPaymentProcessor paypalProcessor = new PaypalProcessor();

            // Reusing the same `PaymentService` instance with the `PaypalProcessor` implementation.
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessOrderPayment(200.00m); // Processes a payment of 200.00 using the PayPal processor.

            // This line was commented out, but it would print a message if enabled.
            // Console.WriteLine("Hello from IndexReusabilityExample class");
        }
    }
}

//Why Polymorphic Interfaces?
// When you need different classes to implement the same set of methods or properties. 
// This ensures the consistency and allows for flexible implementations 

//Why:
// Promotes code reusability and flexibility. Different classes can implement the same interface in various ways,
// allowing for diverse beahviour while maintaining a common contract.

//When:
// Use interfaces when you have multiple classes that should provide the same functionality but might implement it differently. 
// Real-World Example: Payment processing System 

// In C# bezieht sich Polymorphismus darauf, dass eine Methode oder ein Objekt verschiedene Formen annehmen kann,
// d.h. dieselbe Methode kann unterschiedlich implementiert werden, abhängig davon, von welchem Typ das Objekt ist, das sie aufruft.

