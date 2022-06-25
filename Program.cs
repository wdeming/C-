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

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Задача 4:Решение__________");
int max = first_number;
if (second_number > first_number)
    max = second_number;
if (third_number > max)
    max = third_number;
Console.WriteLine("Максимальным числом из укаханных является число:" + max);
// ну или 
// int max = new[] { first_number, second_number, third_number }.Max();
// Console.WriteLine("Максимальным числом из укаханных является число:" + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Задача 6:Решение__________"); // для первого вводимого числа
if (first_number%2 == 0) Console.WriteLine("Первое введенное число является четным");
else Console.WriteLine("Первое введенное число НЕ является четным");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Задача 8:Решение__________"); // для первого вводимого числа
int module = Math.Abs(Convert.ToInt32(first_number));
int count = 1;
if (first_number > -2 &&  first_number < 2) Console.WriteLine("Между числами " + first_number + " и 0 нет четных чисел");
else {
    while (count <= module){     
        if (count%2 == 0){
            Console.WriteLine(first_number > 1 ? count : -count);
        }
        count++;
    }    
}