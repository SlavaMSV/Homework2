/* Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет */

     
int Getthirddigit (int number)
{
    int i = number;
    while (i / 100 > 9)
            i =  i / 10;
    return(i%10);
}
Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
int digit3 = Getthirddigit(number);
if (number > 99)
    Console.WriteLine($"Третья цифра числа: {digit3}");
else
    Console.WriteLine("Нет третьей цифры");






