abstract class AbsractBook
{
    public string Title { get; set; }
    public string Author { get; set; }

    public AbsractBook(string title,string author)
    {

        Title=title;
        Author=author;
        
    }
    public void Read(){
        System.Console.WriteLine($"the book{Title} by {Author} is reading");
    }
    
}