// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6
int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int number = Prompt("Введите  число > ");
if (number >99 )
{
    while (number>999)
{
    number = number/10;
}
    System.Console.WriteLine( number%10);
}    
else
{
    System.Console.WriteLine("третьей цифры нет ");
}

