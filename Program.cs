// Получаем все вводные от пользователя

Console.WriteLine("Введите первое число");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int second_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int third_number = Convert.ToInt32(Console.ReadLine());

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Задача 2:Решение__________");
if (first_number > second_number){
    Console.WriteLine($"Первое число ({first_number}) больше второго числа ({second_number})");    
}
else if (first_number < second_number){
    Console.WriteLine($"Второе число ({second_number}) больше первого числа ({first_number})");    
}
else Console.WriteLine("числа равны");

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int max = first_number;
if (second_number > first_number)
    max = second_number;
if (third_number > max)
    max = third_number;
Console.WriteLine("Максимальным числом из укаханных является число:" + max);