//Напишите программу, которая получает на вход двузначное число и показывает наибольшую цифру числа.

/*int Digits (int number)
{
    //1. Выделить цифры числа
    int ed = number % 10;
    int dec = number / 10;
    //2. Сравнить цифры
    if (ed>dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
    //3. Сообщить результат
}
*/
/*
void Digit1 (int number)                            //метод сравнения разрядов
{
    int ed = number % 10;
    int dec = number / 10;
    
    if (ed>dec)
    {
        Console.WriteLine ("The biggest digit is " + ed);    
    }
    else
    {
        Console.WriteLine ("The biggest digit is " + dec);
    }
}
/*
Console.WriteLine ("input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 9 && user_number < 100)
{
    Digit1 (user_number);
    //int res = Digits(user_number);
    //Console.WriteLine ($"The biggest digit is {res}");
}
else
{
    Console.WriteLine ("Impossible value! ");
}*/


//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

//1. Невозвратный метод без аргумента
//2. Генератор
/*
void MaxDigit ()                                                //создали метод невозвратный без аргумента
{
    int  randomNum = new Random (). Next(10, 100);              //выполнили генерацию числа из полуинтервала [10, 100)
    Console.WriteLine ("Your number is " +randomNum);           //вывели пользователю сгенерированное значение

    Digit1 (randomNum);                                         // вызываем метод сравнения разрядов
}

MaxDigit ();
*/

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
void Cratnost (int a, int b, int num)        // метод проверки на кратность
{
    if (num % a == 0 && num % b == 0)        //проверка на кратность двух значений
    {
        Console.WriteLine($"your number {num} is multiple of {a} and {b}");
    }
    else
    {
        Console.WriteLine($"your number {num} is not multiple of {a} and {b}");
    }
}

//запрос данных у пользователя
Console.WriteLine ("Enter your number: ");                                       //Запрос самого числа
int new_user_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Enter your 1 devider: ");                                    //Запрос 1го делителя
int dev1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Enter your 2 devider: ");                                    //Запрос 2го делителя
int dev2 = Convert.ToInt32(Console.ReadLine());

Cratnost (dev1, dev2, new_user_num);                                             //Вызов метода
*/

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46, 789 -> 79
/*
int DeletDec()
{
    int randomNumber = new Random().Next (100, 1000);
    Console.WriteLine ("Your number is " +randomNumber);

    int digit1 = randomNumber / 100;            //456 / 100 = 4
    int digit2 = randomNumber % 10;             //456 % 10 = 6

    int newNum = digit1 * 10 + digit2;

    return newNum;
}

Console.WriteLine($"Your number is {DeletDec()}");
*/


//Домашнее задание

/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.WriteLine ("Enter your number: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number > 99 && number < 1000 || number>-1000 && number<-99 )
{
    int second_number = (number % 100)/10;
    Console.WriteLine($"Your second number is {second_number}");
}
else
{
    Console.WriteLine("Your number is not 3-digit!");
}*/

/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

Console.WriteLine ("Enter your number: ");
int number = Convert.ToInt32 (Console.ReadLine());

int ThirdNumber=0;
if (number >= 100 || number <= -100)
{
    while (number > 999 || number <-999)
    {
        number = number/10;
    }
    
    ThirdNumber = number % 10;
    Console.WriteLine($"Third number is {ThirdNumber}");
}
else
{
    Console.WriteLine("No third digit! ");
}*/

/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет


Console.WriteLine ("Enter the day of the week: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number <=7 )
{
    if (number>=6)
    {
        Console.WriteLine ("It's a holiday! =) ");
    }
    else
    {
        Console.WriteLine ("It's not a holiday! =( ");
    }
}
else 
{
   Console.WriteLine ("There is no day of the week! "); 
}*/


