// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("Введите первое число > ");
int secondValue = Prompt("Введите второе число > ");
if (firstValue > secondValue)
{
    System.Console.WriteLine(" первое число больше второго");
} else if (firstValue < secondValue)
{
    System.Console.WriteLine("первое число меньше второго");
} else
{
  System.Console.WriteLine("оба числа равны");  
}