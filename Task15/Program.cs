// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число от 1 до 7: ");
string number=Console.ReadLine();
int lenght=number.ToString().Length;

if(int.TryParse(number, out int num))
{
    if((num<6)&&(num>0))
    Console.WriteLine("Будний день");
    else 
    {
        if((num>5) && (num<8))
            Console.WriteLine("Выходной день");
        else 
            Console.WriteLine("Вы ввели некорректное число!!!");
    }
}
else 
    Console.WriteLine("Вы ввели не число. Для корректной работы программы введите число от 1 до 7!!!");



