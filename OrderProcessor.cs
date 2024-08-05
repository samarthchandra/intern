using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class OrderProcessor
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public OrderProcessor(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void ProcessOrder(Order order)
        {
            decimal totalAmount = order.GetTotalAmount();
            _paymentProcessor.ProcessPayment(totalAmount);
            Console.WriteLine("Order processed successfully.");
        }
    }

}
