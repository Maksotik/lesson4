// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void sum (int num){
int sum = 0;    
    while( num != 0 ){
        sum += (num % 10);
        num /= 10;
    }
    Console.WriteLine("Сумма цифр в числе - {0}", sum);
}



Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
sum(number);
