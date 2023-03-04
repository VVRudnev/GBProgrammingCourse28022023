// Задача 13


Console.WriteLine("Введите положительное число");


int num = int.Parse(Console.ReadLine() ?? "0");


double digit = Math.Log10(num);

digit = (int)digit;


if (digit > 1)
{
    
    int count = 1;
    
    int res = num;
    while (count < digit - 1)
    {
        
        res = res/10;
        count ++;
    }
    
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.Write(", равняется: ");
    Console.WriteLine(res%10);
}

else
{
    
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.WriteLine(", отсутствует!");
}
