// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

void num_pow(int num, int pow){
int deg = 1;    
    if (num == 0){
        Console.WriteLine("Результат возведения в степень: ");
        Console.WriteLine("{0}", deg*0);
        return;
    }
    for( int i = 0; i < pow; i++ ){
            deg *= num;
    }
    Console.WriteLine("Результат возведения в степень: ");
    Console.WriteLine(deg);
}



Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральную степень:  ");
int pow = int.Parse(Console.ReadLine());
num_pow(number, pow);

