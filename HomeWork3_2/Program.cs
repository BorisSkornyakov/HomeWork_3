//  Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int DataEntry(string message)                           //Метод ввода данных
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] InputCoord(int n)                                  //Метод ввод трехмерных координат
{
    int[] coord = new int[3];
    coord[0] = DataEntry("Введите координату Х точки {n} -> ");
    coord[1] = DataEntry("Введите координату Y точки {n} -> ");
    coord[2] = DataEntry("Введите координату Z точки {n} -> ");
    return coord;
}

int Squar(int number)                                       // Метод возведения в квадрат
{
    int n = number * number;
    return n;
}

int[] point1 = InputCoord(1);                               //Вводим координаты точек
int[] point2 = InputCoord(2);
double length = Math.Sqrt(Squar(point1[0] - point2[0]) + Squar(point1[1] - point2[1]) + Squar(point1[2] - point2[2]));
System.Console.WriteLine($"Расстояние между точками равно {length}");


