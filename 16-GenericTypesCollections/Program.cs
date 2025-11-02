using _16_GenericTypesCollections.Models;

namespace _16_GenericTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
            Book book2 = new Book(2, "1984", "George Orwell", 1949, 328);
            Book book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
            Book book4 = new Book(4, "Ağ Gəmi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new Book(5, "Qırıq Budaq", "Elçin", 1998, 350);

            Console.WriteLine("Kitab melumatlari:");
            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();

            Console.WriteLine("------------------------------------");  

            Library<Book> lib = new Library<Book>("Milli Kitabxana");
            lib.Add(book1);
            lib.Add(book2);
            lib.Add(book3);
            lib.Add(book4);
            lib.Add(book5);

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Kitab sayı: {lib.Count()}");
            lib.FindByIndex(0).DisplayInfo();
            lib.FindByIndex(2).DisplayInfo();

            Console.WriteLine("Bütün kitablar:");
            foreach (var b in lib.GetAll())
                b.DisplayInfo();

            Console.WriteLine("------------------------------------");
            List<Member> members = new List<Member>()
            {
                new Member(1, "Ali Məmmədov", "ali@mail.com"),
                new Member(2, "Leyla Həsənova", "leyla@mail.com"),
                new Member(3, "Vüqar Əliyev", "vuqar@mail.com")
            };

            var member = members[0];
            member.BorrowBook(book1);
            member.BorrowBook(book2);
            member.DisplayBorrowedBooks();

            member.ReturnBook(1);
            member.DisplayBorrowedBooks();
            member.BorrowBook(book3);
            member.BorrowBook(book4);
            member.BorrowBook(book5);
            member.BorrowBook(book2);

            Console.WriteLine("------------------------------------");

            BookManager manager = new BookManager();
            manager.AddBook(book1);
            manager.AddBook(book2);
            manager.AddBook(book3);
            manager.AddBook(book4);
            manager.AddBook(book5);

            Console.WriteLine("George Orwell kitabları:");
            foreach (var b in manager.GetBooksByAuthor("George Orwell"))
                b.DisplayInfo();

            Console.WriteLine("Cingiz Aytmatov kitabları:");
            foreach (var b in manager.GetBooksByAuthor("Cingiz Aytmatov"))
                b.DisplayInfo();

            Console.WriteLine("Jack London kitabları:");
            foreach (var b in manager.GetBooksByAuthor("Jack London"))
                b.DisplayInfo();

            Console.WriteLine("Dostoyevski kitabları:");
            Console.WriteLine(manager.GetBooksByAuthor("Dostoyevski").Count + " kitab tapıldı");


            Console.WriteLine("------------------------------------");
            manager.AddToWaitingQueue("Nigar");
            manager.AddToWaitingQueue("Rəşad");
            manager.AddToWaitingQueue("Səbinə");
            Console.WriteLine($"Növbədə: {manager.WaitingQueue.Count} nəfər");

            var served = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmət edilir: {served}");
            Console.WriteLine($"Qalan: {manager.WaitingQueue.Count}");

            served = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmət edilir: {served}");
            Console.WriteLine($"Qalan: {manager.WaitingQueue.Count}");

            served = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmət edilir: {served}");
            Console.WriteLine($"Qalan: {manager.WaitingQueue.Count}");

            Console.WriteLine("------------------------------------");

            manager.ReturnBook(book1);
            manager.ReturnBook(book2);
            manager.ReturnBook(book3);

            Console.WriteLine($"\nStack-də kitab sayı: {manager.RecentlyReturned.Count}");
            var lastReturned = manager.GetLastReturnedBook();
            Console.WriteLine($"Son qaytarılan kitab: {lastReturned.Title}");

            manager.RecentlyReturned.Pop();
            Console.WriteLine($"Yeni stack sayı: {manager.RecentlyReturned.Count}");
            lastReturned = manager.GetLastReturnedBook();
            Console.WriteLine($"Yeni son kitab: {lastReturned.Title}");


            Console.WriteLine("------------------------------------");
            var search = manager.SearchByTitle("1984");
            if (search != null)
                search.DisplayInfo();
            else
                Console.WriteLine("Kitab tapılmadı!");

            search = manager.SearchByTitle("Harry Potter");
            if (search != null)
                search.DisplayInfo();
            else
                Console.WriteLine("Kitab tapılmadı!");

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Statistika:");
            Console.WriteLine($"Ümumi kitab sayı: {manager.Books.Count}");
            Console.WriteLine($"Ümumi üzv sayı: {members.Count}");
            Console.WriteLine($"Növbede nefer sayı: {manager.WaitingQueue.Count}");
            Console.WriteLine($"Stack-de kitab sayı: {manager.RecentlyReturned.Count}");

            int minYear = int.MaxValue, maxYear = int.MinValue;
            foreach (var b in manager.Books)
            {
                if (b.Year < minYear) minYear = b.Year;
                if (b.Year > maxYear) maxYear = b.Year;
            }
            Console.WriteLine($"En kohne kitab ili: {minYear}");
            Console.WriteLine($"En yeni kitab ili: {maxYear}");



        }
    }
}
