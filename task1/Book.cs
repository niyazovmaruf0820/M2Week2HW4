namespace task1;

public class Book
{
    public string Title;
    public string Author;
    public int Year;
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public void GetInfo()
    {
        System.Console.WriteLine("Title: " + Title);
        System.Console.WriteLine("Author: " + Author);
        System.Console.WriteLine("Year: " + Year);
    }
    public bool IsPublishedRecently()
    {
        if (Year > 2010)
        return true;
        else return false;
    }
}
