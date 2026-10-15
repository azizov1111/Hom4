// public class User
// {
//     public string FirstName;
//     public string LastName;
//     public string Username;
//     public string PasswordHash;
//     public bool IsLoggedIn;
//     public DateTime CreatedAt;

//     public User(string FirstName, string LastName, string Username, string Password)
//     {
//         this.FirstName = FirstName;
//         this.LastName = LastName;
//         this.Username = Username;
//         PasswordHash = HashPassword(Password);
//         IsLoggedIn = false;
//         CreatedAt = DateTime.Now;
//     }

//     public string HashPassword(string password)
//     {
//         return password.GetHashCode().ToString();
//     }

//     public void Login(string username, string password)
//     {
//         if (Username == username && PasswordHash == HashPassword(password))
//         {
//             IsLoggedIn = true;
//             Console.WriteLine("Welcome, " + FirstName + "!");
//         }
//         else
//         {
//             Console.WriteLine("Login error: check username or password.");
//         }
//     }

//     public void Logout()
//     {
//         IsLoggedIn = false;
//         Console.WriteLine("You have logged out.");
//     }

//     public string GetFullInfo()
//     {
//         return FirstName + " " + LastName +
//                " | Login: " + Username +
//                " | Online: " + IsLoggedIn;
//     }

//     public void ChangePassword(string oldPassword, string newPassword)
//     {
//         if (PasswordHash == HashPassword(oldPassword))
//         {
//             PasswordHash = HashPassword(newPassword);
//             Console.WriteLine("Password changed successfully.");
//         }
//         else
//         {
//             Console.WriteLine("Incorrect old password.");
//         }
//     }

//     public int GetAccountAgeInDays()
//     {
//         return (DateTime.Now - CreatedAt).Days;
//     }
// }

