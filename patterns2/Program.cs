using System;

class ProductSubsystem
{
    public void CheckAvailability(string productName)
    {
        Console.WriteLine($"Проверка наличия товара {productName}");
    }

    public void PlaceOrder(string productName, int quantity)
    {
        Console.WriteLine($"Заказ товара {productName} в количестве {quantity}");
    }
}

class DeliverySubsystem
{
    public void ScheduleDelivery(string productName, int quantity, string address)
    {
        Console.WriteLine($"Запланирована доставка {quantity} шт. товара {productName} по адресу {address}");
    }
}

class OrderFacade
{
    private ProductSubsystem productSubsystem;
    private DeliverySubsystem deliverySubsystem;

    public OrderFacade()
    {
        productSubsystem = new ProductSubsystem();
        deliverySubsystem = new DeliverySubsystem();
    }

    public void PlaceOrder(string productName, int quantity, string address)
    {
        productSubsystem.CheckAvailability(productName);
        productSubsystem.PlaceOrder(productName, quantity);
        deliverySubsystem.ScheduleDelivery(productName, quantity, address);
    }
}

class Program
{
    static void Main(string[] args)
    {
        OrderFacade orderFacade = new OrderFacade();

        orderFacade.PlaceOrder("Книга", 2, "ул. Пушкина, д. 10");
    }
}
