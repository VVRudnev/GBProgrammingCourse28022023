// Задача 4: 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите первое число:");
string? inputNum1 = Console.ReadLine();


Console.WriteLine("Введите второе число:");
string? inputNum2 = Console.ReadLine();


Console.WriteLine("Введите третье число:");
string? inputNum3 = Console.ReadLine();


if (inputNum1 != null && inputNum2 != null && inputNum3 != null)
{
    
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    int number3 = int.Parse(inputNum3);

    
    int maximum = number1;

    
    if (number2 > number1)
        maximum = number2;
    if (number3 > maximum)
        maximum = number3;

    // 
    Console.Write("Максимальное число равно: ");
    Console.WriteLine(maximum);

}
