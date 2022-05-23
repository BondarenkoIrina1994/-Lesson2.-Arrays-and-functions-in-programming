// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число: ");
string number=Console.ReadLine();
int lenght=number.ToString().Length;

if(int.TryParse(number, out int num))
{
    if(lenght<3)
    Console.WriteLine("Третьей цифры нет");
    else 
    Console.WriteLine("Третья цифра числа "+num+ ":"+number[2]);
}
else 
    Console.WriteLine("Вы ввели не число. Для корректной работы программы введите число!!!");
