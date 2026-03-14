// See https://aka.ms/new-console-template for more information

// PIRMA PASKAITA


// Parašykite programą, kuri išvestų į ekraną, ar skaičius a yra didesnis už b

using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;
using Microsoft.VisualBasic;

var a = 3;
var b = 2;

if (a > b)
{
    Console.WriteLine("a is bigger than b");
}
else
{
    Console.WriteLine("a is smaller than b");
}

//Parašykite programą, kuri išvestų į ekraną, ar skaičius a yra didesnis, lygus ar mažesnis už b.

var a1 = 3;
var b1 = 3;

if (a1 > b1)
{
    Console.WriteLine("a1 is bigger than b1");
}
else if (a1 == b1)
{
    Console.WriteLine("a1 is equal to b1");
}
else
{
    Console.WriteLine("a1 is smaller than b1");
}


// Parašykite programą, kuri išvestų į ekraną didžiausia skaičiu iš a, b ir c.

var a2 = 3;
var b2 = 5;
var c = 6;


int biggest = Math.Max(a2, Math.Max(b2, c));
Console.WriteLine($"The biggest number is: {biggest}");

// Parašykite programą, kuri išvestų į ekraną, ar skaičius n yra lyginis.

var n = 4;

if (n % 2 == 0)
{
    Console.WriteLine("n is an even number");
}
else
{
    Console.WriteLine("n is an odd number");
}

// Parašykite programą, kuri išvestų į ekraną, ar iš trijų atkarpų a, b, c galima sudaryti trikampį.

var a3 = 3;
var b3 = 4;
var c1 = 5;

if (a3 + b3 > c1 && a3 + c1 > b3 && b3 + c1 > a3)
{
    Console.WriteLine("A triangle can be formed");
}
else
{
    Console.WriteLine("A triangle cannot be formed");
}

// Parašykite programą, kuri išvestų į ekraną, ar įvesti metai yra keliamieji.

Console.Write("Enter year: ");
var year = int.Parse(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine("The year is a leap year");
}
else
{
    Console.WriteLine("The year is not a leap year");
}

// Parašykite programą, kuri išvestų į ekraną kiek minučių praėjo nuo vidurnakčio. Vartotojas įveda valandas ir minutės.
// Taip pat jei vartotojas įveda ne skaičių, programa išvestų klaidą.

// Console.Write("Enter hours:");
// var hours = int.TryParse(Console.ReadLine());

// Console.Write("Enter minutes: ");
// var minutes = int.TryParse(Console.ReadLine());

// var totalMinutes = hours * 60 + minutes;
// Console.WriteLine($"Total minutes since midnight is: {totalMinutes}");

Console.Write("Enter hours:");
    if (!int.TryParse(Console.ReadLine(), out var hours))
{
    Console.WriteLine("Warning: Invalid input. Please enter a number.");
    return;
}

Console.Write("Enter minutes: ");
    if (!int.TryParse(Console.ReadLine(), out var minutes))
{
    Console.WriteLine("Warning: Invalid input. Please enter a number.");
    return;
}

var totalMinutes = hours * 60 + minutes;
Console.WriteLine($"Total minutes since midnight is: {totalMinutes}");
