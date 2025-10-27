namespace _13_NullableEnumStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sifarisler
            var order1 = new DrinkOrder(101, "Ali", DrinkType.Coffee, DrinkSize.Medium);
            order1.DisplayOrder();
            order1.UpdateStatus(OrderStatus.Preparing);
            order1.UpdateStatus(OrderStatus.Ready);
            order1.UpdateStatus(OrderStatus.Delivered);

            var order2 = new DrinkOrder(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
            order2.DisplayOrder();
            order2.UpdateStatus(OrderStatus.Ready);

            var order3 = new DrinkOrder(103, "Vuqar", DrinkType.Juice, DrinkSize.Small);
            order3.DisplayOrder();


            //enum
            Console.WriteLine("Enum Deyerleri");

            Console.WriteLine("DrinkType deyerleri:");
            foreach (var value in Enum.GetValues(typeof(DrinkType)))
                Console.WriteLine(value);

            Console.WriteLine("DrinkSize deyerleri:");
            foreach (var value in Enum.GetValues(typeof(DrinkSize)))
                Console.WriteLine(value);

            Console.WriteLine("OrderStatus deyerleri:");
            foreach (var value in Enum.GetValues(typeof(OrderStatus)))
                Console.WriteLine(value);

            Console.WriteLine("OrderStatus deyerleri:");
            foreach (var value in Enum.GetValues(typeof(OrderStatus)))
                Console.WriteLine(value);

            Console.WriteLine("ToString() nümuneleri:");
            Console.WriteLine(DrinkType.Coffee.ToString());
            Console.WriteLine(DrinkSize.Large.ToString());

            Console.WriteLine("Parse() nümuneleri:");
            var parsedDrink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
            var parsedSize = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");
            Console.WriteLine($"Parsed DrinkType: {parsedDrink}");
            Console.WriteLine($"Parsed DrinkSize: {parsedSize}");


            //sadestatistika
            Console.WriteLine("Statistika");
            Console.WriteLine($"Ümumi sifariş: 3");
            Console.WriteLine($"1. Sifariş qiymeti: {order1.Price} AZN");
            Console.WriteLine($"2. Sifariş qiymeti: {order2.Price} AZN");
            Console.WriteLine($"3. Sifariş qiymeti: {order3.Price} AZN");

            decimal total = order1.Price + order2.Price + order3.Price;
            Console.WriteLine($"Ümumi mebleğ: {total} AZN");
        }
    }
}
