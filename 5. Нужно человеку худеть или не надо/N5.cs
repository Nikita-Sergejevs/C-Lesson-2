double m;
double h;

//масса
Console.Write("Введите свой вес в килограммах: ");
string weight = Console.ReadLine();
m = Convert.ToDouble(weight);

//рост
Console.Write("Введите свой рост в метрах: ");
string height = Console.ReadLine();
h = Convert.ToDouble(height);

double i=m/(h*h);

//цикл
if (i < 19)
{
    Console.Write("Вам нужно набрать вес");
}
else
{
    if (i > 25)
    {
        Console.Write("Вам нужно сбросить вес");
    }
    else
    {
        Console.Write("У вас вес в норме");
    }
}