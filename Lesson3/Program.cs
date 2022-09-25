// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите пятизначное число > ");
if (value<100000 && value>9999 )
{
if (value/10000 == value %10 || value/1000%10 == value%100/10)
{
    System.Console.Write( $" да ");     
}
else
{
  System.Console.Write( $" нет ");  
}
}
else
{
  System.Console.Write ( $" вы ввели не пятизначное число ");  
}
 
