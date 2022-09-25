// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int Value = int.Parse(strValue);
    return Value;
}
int Value = Prompt("Введите число > ");

void CubeTable( int Value)
{
    int index = 1;
    while (index <= Value)
    {
        System.Console.WriteLine($"Куб числа {index} это {index * index * index} ");
        index++;

    }
}
CubeTable(Value);

