using System;

class Book
{
    string Title;
    string Author;
    string ISBN;
    int pgno;

    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookpgno)
    {
        Title = bookTitle; 
        Author = bookAuthor;
        ISBN = bookISBN;
        pgno = bookpgno;
    }

    void DisplayInfo()
    {
        Console.WriteLine("Book Information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Title of the book is : {Title}");
        Console.WriteLine($"Author of the book is : {Author}");
        Console.WriteLine($"ISBN of the book is : {ISBN}");
        Console.WriteLine($"The pagenumber of the book is : {pgno}");
        Console.WriteLine("");
    }


    static void Main(String[] args)
    {
        //created the an object book
        Book book = new Book("C# for Beginners","Kevin Shalom","1234",200);
        Book book1 = new Book("Visual Studio 2022", "Microsoft", "123", 70);
        book.DisplayInfo();
        book1.DisplayInfo();
    }
}
