using System;
public class Program
{
    public static void Main()
    {
        Book myBook = new Book();
        myBook.title = "Война и мир";
        myBook.author = "Лев Толстой";
        myBook.year = 1869;

        myBook.GetInfo();

        Book unknownBook = new Book();
        
        unknownBook.GetInfo();
    }
}