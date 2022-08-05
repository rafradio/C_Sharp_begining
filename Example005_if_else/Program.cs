Console.Write("Введите пожалуйста имя пользователя: ");
string userName = Console.ReadLine();
if (userName.ToLower() == "женя")
{
    Console.WriteLine("Ура! Это же Женя!");
}
else 
{
    Console.WriteLine("Привет, " + userName + "!");
}