/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным */
string Day (int daynumber)
{
    string result;
    if ((daynumber == 6) || (daynumber == 7))
    result = "выходной день";
    else if ((daynumber > 0) && (daynumber < 6))
    result = "будний день";
    else 
    result = "Введено некорректное значение. Введите цифру от 1 до 7";
    return (result);
}
Console.WriteLine ("Введите число дня недели:");
int daynumber = Convert.ToInt32(Console.ReadLine());
string weekday = Day(daynumber);
Console.WriteLine(weekday);

