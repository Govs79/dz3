using System.Reflection;

int number = 55;
int firstDigit = number/10;
int secondDigit = number%10;
int max = 0;
//if (firstDigit = secondDigit)
//{
 //   Console.WriteLine("Числа равны");
//}
if (firstDigit>secondDigit)
{
    max = firstDigit;
}
else
{
    max = secondDigit;
}
Console.WriteLine($"Наибольшая цифра числа {number} - {max}");
