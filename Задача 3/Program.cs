/*Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/

Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(num1);
Console.WriteLine(num2);


double multiplicity(double num1, double num2)
{
    double result = num1 % num2;

    Console.WriteLine(result);
    
    if (result == 0)
    {
        Console.Write("Число " + num1 + " кратно числу " + num2);
    }
    else
    {
        Console.Write("Число " + num1 + " не кратно числу " + num2 + " остаток " + result);
    }

    return result;
}

double result = multiplicity (num1, num2);