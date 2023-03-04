// Задача 19


int FiveNumDig = ReadData("Введите 5-ти значное число");


bool answer = PaliTest(FiveNumDig);

if(answer == true) PrintData("Число: " + FiveNumDig + " является палиндромом :))");
 if(answer == false) PrintData("Число: " + FiveNumDig + " не является палиндромом :((");


bool PaliTest(int num)
{
    bool res = false;
     int d1 = num / 10000;
     int d2 = (num / 1000) % 10;
     int d3 = (num / 10) % 10;
     int d4 = num % 10;
     res = ((d1 == d4) && (d2 == d3)) ? true : false;
     return res;
 }



 int ReadData(string msg)
 {
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }


 void PrintData(string msg )
 {
     Console.WriteLine(msg);
 }
