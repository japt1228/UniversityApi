using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqSnippets
{


    public class Snippets
    {
        static public void BasicLinQ()
        {
            string[] cars =
            {
                "VW Golf",
                "VW California",
                "Audi A3",
                "Audi A5",
                "Fiat Punto",
                "Seat Ibiza",
                "Seat León"
            };

            // 1. SELECT * of cars
            var carList = from car in cars select car;
            
            foreach ( var car in carList )
            {
                Console.WriteLine(car);
            }

            // 2. SELECT WHERE car is Audi
            var audiList = from car in cars where car.Contains("Audi") select car;

            foreach(var audi in audiList)
            {
                Console.WriteLine(audi);
            }
        }

    }
}