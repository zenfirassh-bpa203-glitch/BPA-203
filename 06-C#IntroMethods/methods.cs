
using System;
//task 1
//namespace Methods
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("riyazi emeliyyatlar");
//            Mathoprts(10, 20);

//        }
//        public static int Mathoprts(int x, int y)
//        {
//            Console.WriteLine($"Toplama: {x + y}");
//            Console.WriteLine($"Cixma: {x - y}");
//            Console.WriteLine($"Vurma: {x * y}");
//            Console.WriteLine($"Bolme: {x / y}");
//            return 0;
//        }
//    }
//}


//task 2
//using System;
//namespace Methods
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("cut ve tek ededler");
//            int[] arr = { 14, 20, 35, 40, 57, 60, 100 };
//            cuttekeded(arr);

//        }

//        public static void cuttekeded(int[] arr)
//        {
//            Console.WriteLine("Cut ededler:");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 == 0)
//                {
//                    Console.WriteLine(arr[i]);
//                }
//            }
//            Console.WriteLine("Tek ededler:");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 != 0)
//                {
//                    Console.WriteLine(arr[i]);
//                }
//            }
//        }
//    }
//}



////task 3
//using System;
//namespace Methods {

//    internal class Program
//    {
//        static void Main(string[] args) {


//            int[] arr = { 14, 20, 35, 40, 57, 60, 100 };
//            Bolunenededler(arr);


//        }

//        public static void Bolunenededler(int[] arr)
//        {
//            int sum = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 4 == 0 && arr[i] % 5 == 0)
//                {
//                    sum += arr[i];
//                }
//            }
//            Console.WriteLine($"4e ve 5e bolunen ededlerin cemi: {sum}");
//        }

//    } } 


//task 4

//using System;
//namespace Methods {

//    internal class Program
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("cumleni daxil edin");
//            string cumle = Console.ReadLine();
//            Console.WriteLine("targeti daxil edin");
//            char target = Convert.ToChar(Console.ReadLine());

//            int length = cumle.Length;
//            for (int i = 0; i < length; i++)
//            {
//                if (cumle[i] == target)
//                {
                    
//                Console.WriteLine("var");
//                    return;
//                }
//                else
//                {
//                    Console.WriteLine("yoxdur");
//                    return;
//                }
//            }
//            //cumleni daxil edin
//            //cumleni
//        }
//    }

//}