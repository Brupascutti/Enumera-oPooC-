using enumeração.entities;
using enumeração.entities.Enums;
namespace enumeração {
    class Program {
        static void Main(string[] args) {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            String txt = OrderStatus.PendingPayment.ToString();

            OrderStatus OS = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(OS);
            Console.WriteLine(txt);

        }
    }
}