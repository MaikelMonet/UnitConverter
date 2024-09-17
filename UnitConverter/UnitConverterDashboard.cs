using ConverterLibrary;

namespace UnitConverter
{
    public partial class UnitConverterDashboard : Form
    {
        public UnitConverterDashboard()
        {
            InitializeComponent();

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
    }
}
