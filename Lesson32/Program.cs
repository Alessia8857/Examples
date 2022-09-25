// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
const int XCOORD = 0;
const int YCOORD = 1;
const int ZCOORD = 2;
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] InsertCoords(string point)
{
    int[]temp = new int[3];
    temp[XCOORD] = Prompt( "введите x   >");
    temp[YCOORD] = Prompt( "введите y   >");
    temp[ZCOORD] = Prompt( "введите z  >");
    return temp;
}
double Length(int[] firstPoint,int[] secondPoint)
{
    return Math.Sqrt(Math.Pow(secondPoint[XCOORD]-firstPoint[XCOORD],2)
    +Math.Pow(secondPoint[YCOORD]-firstPoint[YCOORD],2)
    +Math.Pow(secondPoint[ZCOORD]-firstPoint[ZCOORD],2));
}
int[] firstPoint = InsertCoords("A");
int[] secondPoint = InsertCoords("B");

System.Console.Write($" {Length ( firstPoint,secondPoint) :f2} ");




