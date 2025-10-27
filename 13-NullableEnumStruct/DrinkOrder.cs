using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_NullableEnumStruct
{
    public class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }


        public DrinkOrder(int orderNumber, string customerName, DrinkType drink, DrinkSize size)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            Status = OrderStatus.New;
            Price = CalculatePrice();

        }

        private decimal CalculatePrice()
        {
            switch (Drink)
            {
                case DrinkType.Coffee:
                    return Size switch
                    {
                        DrinkSize.Small => 3m,
                        DrinkSize.Medium => 4m,
                        DrinkSize.Large => 5m,
                        _ => 0m
                    };

                case DrinkType.Tea:
                    return Size switch
                    {
                        DrinkSize.Small => 2m,
                        DrinkSize.Medium => 3m,
                        DrinkSize.Large => 4m,
                        _ => 0m
                    };
                case DrinkType.Juice:
                    return Size switch
                    {
                        DrinkSize.Small => 4m,
                        DrinkSize.Medium => 5m,
                        DrinkSize.Large => 6m,
                        _ => 0m
                    };

                case DrinkType.Water:
                    return Size switch
                    {
                        DrinkSize.Small => 1m,
                        DrinkSize.Medium => 1.5m,
                        DrinkSize.Large => 2m,
                        _ => 0m
                    };

                default:
                    return 0m;
            }
        }
        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Sifariş #{OrderNumber} statusu: {Status}");
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Sifariş Məlumatı");
            Console.WriteLine($"Sifariş nömrəsi: {OrderNumber}");
            Console.WriteLine($"Müştəri: {CustomerName}");
            Console.WriteLine($"İçki: {Drink}");
            Console.WriteLine($"Ölçü: {Size}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Qiymət: {Price} AZN");
        }
    }
}

           
        
        


