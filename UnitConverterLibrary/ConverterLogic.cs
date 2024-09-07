namespace UnitConverterLibrary
{
    public static class ConverterLogic
    {

        public static void MilesToKilometers(double units)
        {
            double kilometers = units * 1.609;
            Console.WriteLine($"{units} Miles is equal to {Math.Round(kilometers, 2)} Kilometers");
        }

        public static void KilometersToMiles(double units)
        {
            double miles = units / 1.609;
            Console.WriteLine($"{units} kilometers is equal to {Math.Round(miles, 2)} Miles ");
        }

        public static void PoundsToKilograms(double units)
        {
            double kilograms = units / 2.205;
            Console.WriteLine($"{units} pounds is equal to {Math.Round(kilograms, 2)} kilograms ");
        }

        public static void KilogramsToPounds(double units)
        {
            double pounds = units * 2.205;
            Console.WriteLine($"{units} kilograms is equal to {Math.Round(pounds, 2)} pounds ");
        }

        public static void CelsiusToFahrenheit(double units)
        {
            double fahrenheit = units * 1.8 + 32;
            Console.WriteLine($"{units}°C is equal to {Math.Round(fahrenheit, 2)}°F");
        }

        public static void FahrenheitToCelsius(double units)
        {
            double celsius = (units - 32) / 1.8;
            Console.WriteLine($"{units}°F is equal to {Math.Round(celsius, 2)}°C ");
        }
    }
}

