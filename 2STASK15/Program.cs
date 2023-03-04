// Задача 15


Console.WriteLine("Введите положительное число");


int day = int.Parse(Console.ReadLine() ?? "0");


if (day > 7 || day < 1)
{
    
    Console.WriteLine("Число " + day + " не является днем недели, введите число от 1 до 7! ");
}

else
{   
    
    Dictionary<int, string> dayOfWeek = new Dictionary<int, string>
{
    { 1, "Понедельник - Рабочий день" },
    { 2, "Вторник - Рабочий день" },
    { 3, "Среда - Рабочий день" },
    { 4, "Четверг - Рабочий день" },
    { 5, "Пятница - Рабочий день" },
    { 6, "Суббота - Выходной день" },
    { 7, "Воскресенье - Выходной день" },
};

    
    Console.WriteLine(dayOfWeek[day]);
}

