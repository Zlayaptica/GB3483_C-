﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Degre(int numberA, int numberB){ //ввод данных
  int result = 1;
  for(int i=1; i <= numberB; i++){  //возведение в степень
    result = result * numberA;
  }
        return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine()); //конвертация данных
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int Level = Degre(numberA, numberB); //вывод данных
  Console.WriteLine("Ответ: " + Level);
