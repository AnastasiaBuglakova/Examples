Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Машенька, дорогая, привет!");
}
else 
{
    Console.WriteLine("Привет, ");
    Console.Write(username);
}