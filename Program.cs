/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B больше 0: ");
int B = int.Parse(Console.ReadLine()!);

if (B <= 0) Console.WriteLine("Введено некорректное число");
else   
Console.WriteLine($"Число A в степени B = {NumberPow(A, B)}");

int NumberPow (int num, int pow){

    int multyNum = 1;
    for (int i = 0; i < pow; i++){
        multyNum = multyNum * num;
    }
    return multyNum;
}


/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа = {GetSumNums(num)}");

int GetSumNums (int number){
    int sumNums = 0;
    do {
        sumNums += number % 10;
        number = number / 10;
    } while ((number > 0) || (number < 0));
    return sumNums;
}


/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int n = 8; // количество элементов массива
int[] arr = PrintArray(n);
Console.WriteLine($"[{String.Join("|", arr)}]");

int[] PrintArray (int n){
    int[] array = new int [n];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(10);
    }
    return array;
}
