/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет*/

 Console.Write("Введите первое число: ");
 int num1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите второе число: ");
 int num2 = Convert.ToInt32(Console.ReadLine());

 int the_square_of_the_number_1(int num1)
 {
    int res = num1 * num1;
    return res;
 }

 int the_square_of_the_number_2(int num2)
 {
    int res = num2 * num2;
    return res;
 }

int res1 = the_square_of_the_number_1(num1);
int res2 = the_square_of_the_number_2(num2);

if (res1 == num2 || res2 == num1)
{
    Console.Write("Одно из чисел введенных Вами является квадратом другого");
}
else
{
    Console.Write("Ни одно из чисел введенных Вами не является квадратом другого");
}
