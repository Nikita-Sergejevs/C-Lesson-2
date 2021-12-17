//узнаём число
Console.Write("Введите число : ");
int b=int.Parse(Console.ReadLine());
int a=0;

//цикл
while(b>0) 
  {    
   a++;
   b/=10;
  }

Console.WriteLine("Количество цифр введенного числа : {0}", a);