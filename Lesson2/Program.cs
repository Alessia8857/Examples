// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int a = Prompt("Введите трёхзначное число > ");
if (a < 1000 && a > 99)
{
    int result = a / 10 % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine(" Вы ввели не трёхзначное число ");
}