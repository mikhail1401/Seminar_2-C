Console.WriteLine("Task 1");
// Напишите программу, которая выводит случайное числоа из отрезка
// [10, 99] и показывает наибольшую цифру числа.
// Например: 78->8  12->2   85->8

int num = new Random().Next(10,100);    // returns a random integer witin a specified range [x;y).

Console.WriteLine(num);

int num1 = num / 10;
int num2 = num % 10;

if(num1 > num2)
{
    Console.WriteLine("Number " + num1 + " is bigger");    // concatenation
}
else if(num1 == num2)
{
    Console.WriteLine("Numbers are equal");
}
else
{
    Console.WriteLine($"Number {num2} is bigger");    // interpolation
}


Console.WriteLine("\nTask 2");
// Напишите программу, которая выводит случайное трехзначное число и удаляет
// вторую цифру этого числа.
// 456 -> 46        782 -> 72       918 -> 98

int number = new Random().Next(100,1000);

Console.WriteLine(number);

int digit1 = number/100;
int digit2 = number%10;

int result = digit1*10 + digit2;

Console.WriteLine(result);


Console.WriteLine("\nTask 3");
// Напишите программу, которая будет принимать на вход два чилса и выводить, является
// ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит 
// остаток деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Type the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1%number2==0)
{
    Console.WriteLine($"{number2} is a multiple of {number1}");
}
else
{
    Console.WriteLine("The remainder is equal to " + number1%number2);
}


Console.WriteLine("\nTask 4");
// Напишите программу, котора принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23
// 14 -> No    46 -> No    161 -> Yes

Console.WriteLine("Type a number: ");
int new_number = Convert.ToInt32(Console.ReadLine()); 

if ((new_number % 7 == 0)&&(new_number % 23 == 0)) Console.WriteLine("yes");    // && - AND, || - OR
else Console.WriteLine("No");


Console.WriteLine("\nTask 5");
// Напишите программу, которая принимает на вход два числа и 
// прверяет, является ли одно число квадратом другого.
// 5, 25 -> yes     -4, 16 -> yes       25, 5 -> yes       8, 9 -> no

Console.WriteLine("Type a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if ((n1 == n2*n2) || (n2 == n1*n1)) Console.WriteLine("Yes");
else Console.WriteLine("No");


Console.WriteLine("\nTask 6");
