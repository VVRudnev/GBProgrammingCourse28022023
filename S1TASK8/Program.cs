// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

 
Console.WriteLine("Введите целое положительное число");
string? inputNum = Console.ReadLine();


if (inputNum != null)
{
    
    int number = int.Parse(inputNum);

    
    string outNumLine = string.Empty;

    
    int count = 2;
    
    if (number % 2 == 0)
    {
        while (count < number)
        {
            
            outNumLine = outNumLine + count + ",";
            count = count + 2;
        }

        
        Console.WriteLine(outNumLine + number);
    }

    
    else
    {
        
        if (number == 1)
        {
            Console.WriteLine("Введите число больше 1");
        }
        else
        {
            while (count < number - 1)
            {
                
                outNumLine = outNumLine + count + ",";
                count = count + 2;
            }
            
            Console.WriteLine(outNumLine + (number - 1));
        }

    }

}