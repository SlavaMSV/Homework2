/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным */
string day (int daynumber)
{
    string result;
    if ((daynumber == 6) || (daynumber == 7))
    result = "выходной";
    else if ((daynumber > 0) && (daynumber < 6))
    result = "будний";
    else 
    result = "Введено некорректное значение";
    return (result);
}
Console.WriteLine ("Введите число дня недели:");
int daynumber = Convert.ToInt32(Console.ReadLine());
string weekday = day(daynumber);
Console.WriteLine(weekday);

