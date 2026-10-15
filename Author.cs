
public class Author
{
    private string name;
    private int age;
    private string nationality;
    private List<Book> books;

    public Author()
    {
        name = "Unknown";
        age = 0;
        nationality = "Unknown";
        books = new List<Book>();
    }

    public Author(string name, int age)
    {
        this.name = name;
        this.age = age;
        nationality = "Unknown";
        books = new List<Book>();
    }

    public Author(string name, int age, string nationality)
    {
        this.name = name;
        this.age = age;
        this.nationality = nationality;
        books = new List<Book>();
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetNationality()
    {
        return nationality;
    }

    public void Introduce()
    {
        Console.WriteLine("My name is " + name + ". I am " + age +
                          " years old. I am from " + nationality + ".");
    }

    public void CelebrateBirthday()
    {
        age++;
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ListBooks()
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book.GetInfo());
        }
    }
}