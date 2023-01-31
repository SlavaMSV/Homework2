/* 
Программа принимает случайное трехзначное число
и на выходе показывает вторую цифру числа 
*/

int getnumber ()
{
    Random rnd = new Random();
    int result = rnd.Next(100, 1000);
    return(result);
}
int getseconddigit (int number)
{
    int seconddigit = (number/10)%10;
    return (seconddigit);
}
int number = getnumber();
Console.WriteLine($"сгенерированное число: {number}");
int digit2 = getseconddigit(number);
Console.WriteLine ($"вторая цифра числа:{digit2}");