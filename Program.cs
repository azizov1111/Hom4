

// // class Program
// // {
// //     static void Main()
// //     {
// //         Rectangle rectangle = new Rectangle(5, 3, "Red");

// //         Console.WriteLine("Width: " + rectangle.Width);
// //         Console.WriteLine("Height: " + rectangle.Height);
// //         Console.WriteLine("Color: " + rectangle.Color);
// //         Console.WriteLine("Area: " + rectangle.GetArea());
// //         Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());
// //     }
// // }




// // class Program
// // {
// //     static void Main()
// //     {
// //         User user = new User("Ivan", "Ivanov", "ivan123", "12345");

// //         user.Login("ivan123", "12345");

// //         Console.WriteLine(user.GetFullInfo());

// //         user.ChangePassword("12345", "54321");

// //         user.Logout();

// //         Console.WriteLine("Account age: " + user.GetAccountAgeInDays() + " days");
// //     }
// // }






// class Program
// {
//     static void Main()
//     {
//         Author author = new Author("J.K. Rowling", 60, "British");

//         Book book1 = new Book("Harry Potter", "Fantasy", 350);
//         Book book2 = new Book("The Casual Vacancy", "Novel", 500);

//         author.AddBook(book1);
//         author.AddBook(book2);

//         author.Introduce();

//         Console.WriteLine("Name: " + author.GetName());
//         Console.WriteLine("Age: " + author.GetAge());
//         Console.WriteLine("Nationality: " + author.GetNationality());

//         Console.WriteLine();

//         Console.WriteLine("Books:");
//         author.ListBooks();

//         Console.WriteLine();

//         author.CelebrateBirthday();
//         Console.WriteLine("New age: " + author.GetAge());
//     }
// }



class Program
{
    static void Main()
    {
        Country country = new Country("Uzbekistan", "Tashkent", 38000000, "Uzbek");

        Console.WriteLine("Country Name: " + country.GetName());
        Console.WriteLine("Capital: " + country.GetCapital());
        Console.WriteLine("Population: " + country.GetPopulation());
        Console.WriteLine("Official Language: " + country.GetOfficialLanguage());
    }
}