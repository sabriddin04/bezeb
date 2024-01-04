using System.Security.Cryptography.X509Certificates;

class Book:AbsractBook,IBorrowable
{
    public Book(string title,string author):base(title,author)
    {
        
    }
    public void Borrow(){
        System.Console.WriteLine($"the book{Title} by {Author} has been borrowed");
    }

    public void ReturnBook(){
        System.Console.WriteLine($"the book{Title} by {Author} has been returned");
    }


}