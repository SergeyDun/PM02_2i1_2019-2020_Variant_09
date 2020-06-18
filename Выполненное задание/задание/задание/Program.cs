using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите 1-е основание трапеции:");
        double trapezoidBase1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите 2-е основание трапеции:");
        double trapezoidBase2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите высоту трапеции:");
        double trapezoidHeight = Convert.ToDouble(Console.ReadLine());

        double areaOfTrapezoid = (trapezoidBase1 + trapezoidBase2) * trapezoidHeight / 2;
        Console.WriteLine("Площадь трапеции равна: " + areaOfTrapezoid);
        Console.Read();

    }
}