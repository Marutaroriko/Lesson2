//Написать метод, возвращающий минимальное из трёх чисел.
//Тарорико Мария
using System;
Console.Write("Введите a= ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b= ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c= ");
int c=Convert.ToInt32(Console.ReadLine());
int min;
if (a<b && a<c) 
{
  min=a;  
}
     else 
       if (b<c) {
           min=b;
                }
 else {
 min=c;
 }
 Console.WriteLine($"Минимальное из трех чисел = {min}");