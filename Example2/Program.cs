//Написать метод подсчета количества цифр числа.
//Тарорико Мария
using System;
Console.Write("Введите число: ");
int n=int.Parse(Console.ReadLine());
int count=0;
while (n !=0) {
    count++;
    n=n/10;
}
Console.WriteLine($"Количество цифр в числе: {count}");