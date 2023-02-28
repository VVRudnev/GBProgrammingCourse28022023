// Задача 6: 
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Целое число:");
string? inputNum = Console.ReadLine();



if (inputNum != null)
{
    
    int number = int.Parse(inputNum);
   
    if ((number % 2) == 0)
    {
         
         Console.WriteLine("введенное число является четным");
    }
    else
    {
        
        Console.WriteLine("введенное число является не четным");
    }
}

