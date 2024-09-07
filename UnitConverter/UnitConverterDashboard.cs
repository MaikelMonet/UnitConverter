namespace UnitConverter
{
    public partial class UnitConverterDashboard : Form
    {
        private List<string> methods = new List<string>();

        public UnitConverterDashboard()
        {
            InitializeComponent();

            WireUpDropDownList();

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (DataValidation())
            {
                ConvertUnits();

            }  
        }

        private bool DataValidation()
        {
            bool canConvert = double.TryParse(unitInput.Text, out double unit);

            if (canConvert == false)
            {
                MessageBox.Show("Please enter a valid amount");

            }
                      return canConvert;
        }

        private void WireUpDropDownList()
        {
            methods.Add("Miles to Kilometers");
            methods.Add("Kilometers to Miles");
            methods.Add("Pounds to Kilograms");
            methods.Add("Kilograms to Pounds");
            methods.Add("Celcius to Farenheit");
            methods.Add("Fahrenheit to Celsius");

            conversionMethodDropDownBox.DataSource = methods;
        }

        private void ConvertUnits()
        {

            switch (conversionMethodDropDownBox.SelectedItem)
            {
                case "Miles to Kilometers":
                    MilesToKilometers(double.Parse(unitInput.Text));
                    break;
                case "Kilometers to Miles":
                    KilometersToMiles(double.Parse(unitInput.Text));
                    break;
                case "Pounds to Kilograms":
                    PoundsToKilograms(double.Parse(unitInput.Text));
                    break;
                case "Kilograms to Pounds":
                    KilogramsToPounds(double.Parse(unitInput.Text));
                    break;
                case "Celcius to Farenheit":
                    CelsiusToFahrenheit(double.Parse(unitInput.Text));
                    break;
                case "Fahrenheit to Celsius":
                    FahrenheitToCelsius(double.Parse(unitInput.Text));
                    break;
            }
        }

        // TODO - Change all returning calculations to two decimal places.
        private void MilesToKilometers(double units)
        {
            double kilometers = units * 1.609;
            unitOutput.Text = kilometers.ToString();
        }

        private void KilometersToMiles(double units)
        {
            double miles = units / 1.609;
            unitOutput.Text = miles.ToString();
        }

        private void PoundsToKilograms(double units)
        {
            double kilograms = units / 2.205;
            unitOutput.Text = kilograms.ToString();
        }

        private void KilogramsToPounds(double units)
        {
            double pounds = units * 2.205;
            unitOutput.Text = pounds.ToString();
        }

        private void CelsiusToFahrenheit(double units)
        {
            double fahrenheit = units * 1.8 + 32;
            unitOutput.Text = fahrenheit.ToString();
        }

        private void FahrenheitToCelsius(double units)
        {
            double celsius = (units - 32) / 1.8;
            unitOutput.Text = celsius.ToString();
        }

    }
}
