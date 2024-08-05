namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sweet = new Product("Ghewar", 680);
            var Sweet1 = new Product("Dry fruit chocolate", 440);

            var order = new Order();
            order.AddProduct(Sweet);
            order.AddProduct(Sweet1);

            IPaymentProcessor paymentProcessor = new CreditCardPaymentProcessor();
            var orderProcessor = new OrderProcessor(paymentProcessor);
            orderProcessor.ProcessOrder(order);

            paymentProcessor = new PhonePayPaymentProcessor();
            orderProcessor = new OrderProcessor(paymentProcessor);
            orderProcessor.ProcessOrder(order);
        }
    }
}