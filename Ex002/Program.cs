// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("Введите первое число > ");
int secondValue = Prompt("Введите второе число > ");
int thirdValue = Prompt("Введите третье число > ");
int MaxValue = firstValue;
{
if ( MaxValue < secondValue )
   {
    MaxValue = secondValue ;
   }
if (MaxValue < thirdValue)
   {
    MaxValue = thirdValue ;
   }
   System.Console.WriteLine ($"{MaxValue}");
}
 