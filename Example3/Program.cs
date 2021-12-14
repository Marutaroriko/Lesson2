//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
//Тарорико Мария
using System;
            Console.WriteLine("Введите числа: ");
        int k = 0, s = 0;
        int a = Convert.ToInt32(Console.ReadLine());
        while (a != 0) 
        {
            if (a > 0 && a % 2 == 1) {k++;
                s = s + a; }
                a = Convert.ToInt32(Console.ReadLine());
       }
Console.WriteLine($"Сумма = {s}");
