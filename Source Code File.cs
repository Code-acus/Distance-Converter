// Distance converter application in C#:

private void convertButton_Click(object sender, EventArgs e)
{
    // Parse the distance value from the text box
    if (!double.TryParse(distanceTextBox.Text, out double distance))
    {
        MessageBox.Show("Invalid distance value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Get the selected units
    string fromUnit = fromUnitListBox.SelectedItem.ToString();
    string toUnit = toUnitListBox.SelectedItem.ToString();

    // Check if the selected units are the same
    if (fromUnit == toUnit)
    {
        // Display the same value as entered
        resultLabel.Text = $"{distance} {fromUnit} = {distance} {toUnit}";
        return;
    }

    // Convert the distance to the selected unit
    double result = 0;

    switch (fromUnit)
    {
        case "Inches":
            result = distance / FeetInInches / YardsInFeet;
            break;
        case "Feet":
            result = distance / YardsInFeet;
            break;
        case "Yards":
            result = distance;
            break;
    }

    // Convert the result to the selected unit
    switch (toUnit)
    {
        case "Inches":
            result *= YardsInFeet * FeetInInches;
            break;
        case "Feet":
            result *= YardsInFeet;
            break;
        case "Yards":
            // result already in yards
            break;
    }

    // Display the result
    resultLabel.Text = $"{distance} {fromUnit} = {result} {toUnit}";
}

/*
The updated code checks if the selected units are the same using string comparison, and if so, 
it displays the same value as entered. Otherwise, it proceeds with the conversion as before.

To create a Windows Form control, follow these steps:

Open Visual Studio and create a new Windows Forms project.
Open the Toolbox and drag a TextBox, two ListBox controls, a Button, and a Label to the form.
Set the Text property of the Button to "Convert".
Set the Text property of the Label to "Result".
Double-click the Button to generate its click event handler code.
Copy and paste the example code above into the form's code-behind file (MainForm.cs by default).
Add the MainForm_Load event handler to populate the unit selection list boxes.
Run the application and test it.
*/