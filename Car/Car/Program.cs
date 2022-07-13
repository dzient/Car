// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

//-----------------------------------------------------------------
//ArraysAndLists
//
// Name: David Zientara
// Date: 7-8-2022
// Comments: An exercise in arrays and lists
// Added methods per the instructions
//-----------------------------------------------------------------
class Car
{
    public string? Make, Model;
    public int Year;


    public static void Main()
    {
        Car car = new Car();
        car.Make = "Volkswagen";
        car.Model = "Golf";
        car.Year = 1992;

        Console.WriteLine($"Your car is a {car.Year} {car.Make} {car.Model} ");

    }

}