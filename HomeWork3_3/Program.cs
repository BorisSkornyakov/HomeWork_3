// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int DataEntry(string message)                      //Метод ввода данных
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Cubing(int number)                             // метод возведения в куб
{
    int num = number * number * number;
    return num;
}

int number = DataEntry("Введите целое число");    
for (int i = 1; i <= number; i++)
{
    int result = Cubing(i);
    System.Console.WriteLine(result);
}