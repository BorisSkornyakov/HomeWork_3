//  Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int DataEntry(string message)                                //Метод ввода целого числа
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int TurnNumber(int num)                                      // Метод разворота числа
{
    int rev = 0;
    while (num > 0)
    {
        int digit = num % 10;
        rev = rev * 10 + digit;
        num = num / 10;
    }
    return rev;
}

int number = DataEntry("Введите пятизначное число -> ");     // Вводим пятизначное число
int revnumber = TurnNumber(number);                          // разворачиваем число и сохраняем его во временной переменной
if(number == revnumber)                                      // Сравниваем введенное число и его перевернутый вариант
{                                                            // Если совпадает значит число полином
    System.Console.WriteLine($"Число {number} полином");     // Если не совпадает значит не полином
}
else 
{
    System.Console.WriteLine($"Число {number} не является полиномом");
}