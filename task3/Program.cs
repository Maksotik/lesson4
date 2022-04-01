// Задача 3: Напишите программу, которая задаёт массив из 8 элементов 
// случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции

int size = 8;
int [] arr = new int [size];
Random rand = new Random();

for( int i = 0; i < size; i++ ){
    arr[i] = rand.Next(0, 9);
    Console.Write("{0} ", arr[i]); 
}
Console.WriteLine();



