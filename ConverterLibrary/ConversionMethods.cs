using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary
{
    public static class ConversionMethods
    {
       
        public static string ConvertUnits(double units, string conversionRequest)
        {
            string output = "";

            switch (conversionRequest)
            {
                case "Miles to Kilometers":
                    output = (units * 1.609).ToString("F2");
                    break;
                case "Kilometers to Miles":
                    output = (units / 1.609).ToString("F2");
                    break;
                case "Pounds to Kilograms":
                    output = (units / 2.205).ToString("F2");
                    break;
                case "Kilograms to Pounds":
                    output = (units * 2.205).ToString("F2");
                    break;
                case "Celcius to Farenheit":
                    output = (units * 2.205).ToString("F2");
                    break;
                case "Fahrenheit to Celsius":
                    output = ((units - 32) / 1.8).ToString("F2");
                    break;
            }

            return output;

        }
    }
}
