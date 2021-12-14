//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
//программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
//Тарорико Мария
using System;
            
     
     Console.WriteLine("Введите логин и пароль");
       string login=Console.ReadLine();
        string password=Console.ReadLine();
     int k=3;
     do {
         if (login == "root" && password == "GeekBrains") {
        Console.WriteLine("Вы прошли авторизацию!");
        k=0;
     }
     else if (k>1) {
         k--;
         Console.WriteLine($"Повторите ввод! У вас осталось {k} попыток");
         Console.WriteLine("Введите логин и пароль");
         login=Console.ReadLine();
         password=Console.ReadLine();
     }
     else {
         k--;
     Console.WriteLine("Вы не прошли авторизацию!");
     }
     }
     
     while (k != 0);
       