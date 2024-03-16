namespace Garage_Homework_Class.Models;

public class Book
{
    public string Name;
    public int PageCount;
    Book[] books = new Book[10];

    public void FullInfo()
    {
        Console.WriteLine($"Book name:{Name}, Page Count:{PageCount}");
    }
    public void CreateBook()
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine($"Please write the name of the book ({i + 1}. Book):");
            string name = Console.ReadLine().ToUpper();
            while (name.Length < 3)
            {
                Console.WriteLine("Kitab Adi kisadir bizde qaydalaar beledi min 3 herf");
                name = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"Write the page number of the book({i + 1}. Book):");
            int pageCount = int.Parse(Console.ReadLine());
            while (pageCount < 10)
            {
                Console.WriteLine("10 dan kicik ola bilmez ");
                pageCount = int.Parse(Console.ReadLine());
            }
            books[i] = new Book { Name = name, PageCount = pageCount };
            Console.WriteLine("Book Added");
            i++;
        }
    }
    public void ShowBook()
    {
        foreach (Book book1 in books)
        {
            if (book1 == null)
            {
                Console.WriteLine("Book Not Found");
                return;
            }
            else
            {
                book1.FullInfo();
            }
        }
    }
}
