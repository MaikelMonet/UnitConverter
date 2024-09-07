using ConverterLibrary;

namespace UnitConverter
{
    public partial class UnitConverterDashboard : Form
    {
        private readonly List<string> methods = new List<string>();

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
                    unitOutput.Text = ConversionMethods.MilesToKilometers(double.Parse(unitInput.Text));
                    break;
                case "Kilometers to Miles":
                    unitOutput.Text = ConversionMethods.KilometersToMiles(double.Parse(unitInput.Text));
                    break;
                case "Pounds to Kilograms":
                    unitOutput.Text = ConversionMethods.PoundsToKilograms(double.Parse(unitInput.Text));
                    break;
                case "Kilograms to Pounds":
                    unitOutput.Text = ConversionMethods.KilogramsToPounds(double.Parse(unitInput.Text));
                    break;
                case "Celcius to Farenheit":
                    unitOutput.Text = ConversionMethods.CelsiusToFahrenheit(double.Parse(unitInput.Text));
                    break;
                case "Fahrenheit to Celsius":
                    unitOutput.Text = ConversionMethods.FahrenheitToCelsius(double.Parse(unitInput.Text));
                    break;
            }
        }
    }
}
