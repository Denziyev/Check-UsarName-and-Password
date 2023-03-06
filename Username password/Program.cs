Console.WriteLine("Enter the username: ");
string Name=Console.ReadLine();
Console.WriteLine("Enter the Password: ");
string Password=Console.ReadLine();
Users user = new Users(Name,Password);
Console.Clear();
if (user.Password != null && user.UserName != null)
{
    Console.WriteLine("SUCCESS");
}
else Console.WriteLine("FAIL");

























