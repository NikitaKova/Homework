//Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не применять строки!
//14212 -> нет
//12821 -> да
//23432 -> да

int InputNumber(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int n)
{
    if (n < 1000 || n > 99999)
    {
        System.Console.WriteLine("Число не пятизначное");
        return false;
    }
    return true;
}

int n = InputNumber("Введите пятизначное число: ");
int Oldnumber = n ;
int Newnumber = 0 ;
if (!ValidateNumber(n))
{
    return;
}
while (n > 0)
{
    int Value = n % 10;
    Newnumber = Newnumber * 10 + Value;
    n = n / 10; 
}
if (Oldnumber == Newnumber)
{
    System.Console.WriteLine("Число палиндром");
}
else
{
    System.Console.WriteLine("Число не палиндром");
}
