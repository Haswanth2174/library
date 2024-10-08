using System;

class Book
{
    string Title;
    string Author;
    string ISBN;
    int pgno;

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
        Book book = new Book();
        book.Title = "C# for Beginners";
        book.Author = "Kevin Shalom";
        book.ISBN = "12345";
        book.pgno = 12;

        //created another object book1
        Book book1 = new Book();
        book1.Title = "C# for Intermediate";
        book1.Author = "Shalem Raj";
        book1.ISBN = "54321";
        book1.pgno = 21;

        book.DisplayInfo();
        book1.DisplayInfo();
    }
}
