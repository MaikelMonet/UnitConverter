using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary
{
    public static class ConversionMethods
    {
       

        public static string MilesToKilometers(double units)
        {
            string kilometers;

            return kilometers = (units * 1.609).ToString("F2");
        }

        public static string KilometersToMiles(double units)
        {
            string miles;
                
            return miles = (units / 1.609).ToString("F2");
        }

        public static string PoundsToKilograms(double units)
        {
            string kilograms;

            return kilograms = (units / 2.205).ToString("F2");
        }

        public static string KilogramsToPounds(double units)
        {
            string pounds;

            return pounds = (units * 2.205).ToString("F2");
        }

        public static string CelsiusToFahrenheit(double units)
        {
            string fahrenheit;

            return fahrenheit = ((units * 1.8) + 32).ToString("F2");
        }

        public static string FahrenheitToCelsius(double units)
        {
            string celsius;

            return celsius = ((units - 32) / 1.8).ToString("F2");
        }
    }
}
