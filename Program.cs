// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""
void Zadacha64 ()
{
int numberM = 1;
int numberN = 20;
Recursion (numberM, numberN);
Console.WriteLine();

void Recursion (int numberM, int numberN)
{
    if (numberM > numberN) return;
    if (numberM%3 == 0)
    {
        Console.Write (numberM + " ");
    }
    numberM++;
    Recursion (numberM, numberN);
}
}
Zadacha64 ();

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
void Zadacha66 ()
{
int numberM = 1;
int numberN = 15;
Recursion (numberM, numberN);
Console.WriteLine();

void Recursion (int numberM, int numberN, int result = 0)

{
    if (numberM > numberN)
    {
        Console.WriteLine(result);
        return;
    }
    result += numberM;
    numberM++;
    Recursion (numberM, numberN, result);
}
}
Zadacha66 ();

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
void Zadacha68 ()
{
int m = 3;
int n = 2;
Console.WriteLine(Recursion (m, n));

int Recursion (int m, int n)
{
    if (m == 0) return n+1;
    if (n == 0) return Recursion (m - 1, 1);
    return Recursion (m -1, Recursion (m, n - 1));
   
}
}
Zadacha68 ();