//логин и пароль
string login = "root";
string password = "GeekBrains";

//количество попыток
int count = 0;

do
{
    //вводим логин
    Console.Write("Введите логин: ");
    string Login = Console.ReadLine();

    //вводим пароль
    Console.Write("Введите пароль: ");
    string Password = Console.ReadLine();

    if (login == Login && password == Password)
    {
        Console.Write("Добро пожаловать!");
        break;
    }
    else
    {
        Console.Write("Неверно введен логин или пароль!\n");
        ++count;
    }
} while (count < 3);
Console.Write("Попробуйте позже!");
