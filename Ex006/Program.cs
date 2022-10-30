// написать программу которая из имеющегося массива строк формирует массив из строк, длина которых меньше 3
 string [] FillArray;
{
    Console.WriteLine(" Введите массив строк через пробел");
    string array = Console.ReadLine() ;
    FillArray = array.Split(' ');
}
var result = new string[FillArray.Length];
var realSize = 0;
foreach (var value in FillArray)
 {
    if( value.Length < 4)
       {
        result[realSize]= value;
        realSize++;
       }
 }
 Console.WriteLine(string.Join(Environment.NewLine,result,0,realSize));
Console.ReadKey(true);

