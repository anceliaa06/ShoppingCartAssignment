namespace ShoppingCartAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Laptop", 50000, 10);
            Product p2 = new Product(2, "Mouse", 500, 5);

            LineItem item1 = new LineItem(1, 2, p1);
            LineItem item2 = new LineItem(2, 3, p2);

            Order order = new Order(101, DateTime.Now);
            order.AddItem(item1);
            order.AddItem(item2);

            Customer customer = new Customer(1, "Ancelia");
            customer.PlaceOrder(order);

            Console.WriteLine($"Total Order Price : ${order.CalculateOrderPrice()}");
        }
    }
}
