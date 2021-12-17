int a;
int b;
int c; 
int max;

//a
Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());

//b
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

//c
Console.Write("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());

//max будет равен 0
max = 0; 

//цикл
if (a < b && a < c)
{
    max = a;
}
else
{
    if (b < a && b < c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}

Console.Write($"Наименьшее число из трёх: {max}");