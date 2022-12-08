/* Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/
 
 bool Polidrom(string number)
 {
    if(number[0] ==number[4] || number[1] == number[3])
    {
        return true;
    }
    else
    {
        return false;
    }
 }
 
 Console.Write("Введите пятизначное число ");
 string number = Convert.ToString(Console.ReadLine());
 bool res = Polidrom(number);
 Console.WriteLine(res);







/* Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/
/*
double Distance(double xA, double yA, double zA,double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
}

Console.WriteLine("Введите координату х точки А: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки А: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z точки А: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату х точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double dist = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine("Расстояние от точки А до точки В = " + dist);
*/





/* Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/
/*
void RowCube(int n)
{
    int result = 1;
    while(result <= n)
    {
    Console.Write(Math.Pow(result, 3) + " ");
    result++;
    }
}
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
RowCube(n);
*/


