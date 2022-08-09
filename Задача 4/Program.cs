/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да*/

Console.Write("Введите целое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

double multiplicity_7(double num1)
{
    double result = num1 % 7;
    return result;
}

double multiplicity_23(double num1)
{
    double result = num1 % 23;
    return result;
}

double res1 = multiplicity_7(num1);
double res2 = multiplicity_23(num1);

if (res1 == 0 && res2 == 0)
    {
        Console.Write("Число " + num1 + " кратно 7 и 23 одновременно.");
    }
    
    else
    {
        Console.Write("Число " + num1 + " некратно 7 и 23 одновременно.");
    }
