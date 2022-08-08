/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.*/

int print_random_number (int min_number, int max_number)
{
    int result = new Random().Next(min_number,max_number);
    return result;
}

int first_number(int random_number)
{
   int result = random_number / 100;
   return result; 
}

int third_number(int random_number)
{
    int result = random_number % 10;
    return result;
}

int random_number = print_random_number(100, 999);
int number_first = first_number (random_number);
int number_third = third_number (random_number);
Console.WriteLine(random_number);
Console.WriteLine("Первое число " + number_first + ", третее число " + number_third);