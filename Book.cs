public class Book
{
    private string title;
    private string genre;
    private int pages;

    public Book(string title, string genre, int pages)
    {
        this.title = title;
        this.genre = genre;
        this.pages = pages;
    }

    public string GetInfo()
    {
        return "Book: " + title + ", Genre: " + genre + ", Pages: " + pages;
    }
}