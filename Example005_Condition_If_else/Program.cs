System.Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username!.ToLower() == "лариса")
{
    System.Console.WriteLine("Ура, это же Лариса!!!!");
}
else
{
    System.Console.Write("Привет, ");
    System.Console.WriteLine(username);
}