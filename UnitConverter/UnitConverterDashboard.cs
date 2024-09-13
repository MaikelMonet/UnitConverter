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

            HeaderLabel.BackColor = Color.Transparent;

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (DataValidation())
            {
                unitOutput.Text = ConversionMethods.ConvertUnits(double.Parse(unitInput.Text), conversionMethodDropDownBox.SelectedItem.ToString());

            }  
        }

        private bool DataValidation()
        {
            bool canConvert = double.TryParse(unitInput.Text, out double unit);

            if (canConvert == false)
            {
                MessageBox.Show("Please enter a valid amount", "Invalid value!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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

    }
}
