Console.Write("Please, enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Hooray! This is MASHA!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
