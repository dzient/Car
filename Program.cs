// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

//-----------------------------------------------------------------
//Car
//
// Name: David Zientara
// Date: 7-13-2022
// Comments: An exercise in classes
// Added methods per the instructions
//-----------------------------------------------------------------



class Car
{
    //Added Make, Model and Year
    //Made Make + Model nullable
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }


    public static void Main()
    {
       
        //Create a car and change the properties
        Car car = new Car();
        car.Make = "Volkswagen";
        car.Model = "Golf";
        car.Year = 1992;
        //Print it out
        Console.WriteLine($"Your car is a {car.Year} {car.Make} {car.Model} ");

    }

}