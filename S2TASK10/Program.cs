// Задача 10: 


Console.WriteLine ("Введите 3-х значное число:");

int num = int.Parse(Console.ReadLine()??"0");


double digit = Math.Log10(num);

digit = (int)digit;


if (digit == 2)
{
    
    int result = num / 10;
    
    result = result%10;
   
    Console.WriteLine ("Вторая цифра числа: " + num + " равна: " + result);
}
else
{
    Console.WriteLine ("Введенное число не 3-х значное!!!");
    Console.WriteLine ("Введите 3-х значное!!! число!!!");
}
