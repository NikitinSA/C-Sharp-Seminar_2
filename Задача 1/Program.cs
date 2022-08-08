/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и
показывает наибольшую цифру числа.*/

int GetRandomNumberInRange(int min_number, int max_number)
{
    int result = new Random().Next(min_number,max_number + 1);
    return result;
}

int GetMaxDigitFromNumber(int number)
{
    int result = number / 10;
    int second_digit = number % 10;
    if(second_digit > result)
    {
        result = second_digit;
    }
    return result;
}

int random_number = GetRandomNumberInRange(10, 99);
int max_digit = GetMaxDigitFromNumber(random_number);
Console.Write("Наибольшая цифра числа " + random_number + " является " + max_digit);