using System;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        private const double FeetInInches = 12;
        private const double YardsInFeet = 3;

        public Form1()
        {
            InitializeComponent();
            InitializeConversionUnits();
        }

        private void InitializeConversionUnits()
        {
            convertFromListBox.SelectedIndex = 0;
            convertToListBox.SelectedIndex = 0;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double distance))
            {
                MessageBox.Show("Invalid distance value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fromUnit = convertFromListBox.SelectedItem?.ToString();
            string toUnit = convertToListBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fromUnit) || string.IsNullOrEmpty(toUnit))
            {
                MessageBox.Show("Please select conversion units", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double convertedDistance = ConvertDistance(distance, fromUnit, toUnit);

            convertedDistanceDisplayLabel.Text = $"{distance} {fromUnit} = {convertedDistance} {toUnit}";
        }

        private double ConvertDistance(double distance, string fromUnit, string toUnit)
        {
            double convertedDistance = 0;

            switch (fromUnit)
            {
                case "Inches":
                    convertedDistance = ConvertInches(distance, toUnit);
                    break;
                case "Feet":
                    convertedDistance = ConvertFeet(distance, toUnit);
                    break;
                case "Yards":
                    convertedDistance = ConvertYards(distance, toUnit);
                    break;
            }

            return convertedDistance;
        }

        private double ConvertInches(double distance, string toUnit)
        {
            switch (toUnit)
            {
                case "Inches":
                    return distance;
                case "Feet":
                    return distance / FeetInInches;
                case "Yards":
                    return distance / FeetInInches / YardsInFeet;
                default:
                    return 0;
            }
        }

        private double ConvertFeet(double distance, string toUnit)
        {
            switch (toUnit)
            {
                case "Inches":
                    return distance * FeetInInches;
                case "Feet":
                    return distance;
                case "Yards":
                    return distance / YardsInFeet;
                default:
                    return 0;
            }
        }

        private double ConvertYards(double distance, string toUnit)
        {
            switch (toUnit)
            {
                case "Inches":
                    return distance * YardsInFeet * FeetInInches;
                case "Feet":
                    return distance * YardsInFeet;
                case "Yards":
                    return distance;
                default:
                    return 0;
            }
        }
    }
}
