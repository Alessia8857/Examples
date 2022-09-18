// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите номер дня недели > ");
if (value >=1 && value< 8)
{
  if (value>=1 && value<6)  
  {
    System.Console.WriteLine(" нет ");
  }
   else
   System.Console.WriteLine(" да");
}
else
System.Console.WriteLine(" неверный диапозон");