/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int y = number / 1000;
int z = number % 100;
if ((number / 10000 == number % 10) && (y % 10 == z / 10))
{
Console.WriteLine("Число - палиндром");
}
else
{
Console.WriteLine("Число - не палиндром");
}