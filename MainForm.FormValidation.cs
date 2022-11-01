using System.Drawing;
using System.Globalization;

namespace lab;

partial class MainForm
{
	private void VehicleReleaseYearTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
	{
		var isNumber = int.TryParse(VehicleReleaseYearTextBox.Text, out _);
		if (isNumber)
		{
			e.Cancel = false;
			VehicleReleaseYearTextBox.BackColor = SystemColors.Window;
		}
		else
		{
			e.Cancel = true;
			VehicleReleaseYearTextBox.BackColor = Color.Red;
		}
	}

	private void VehicleInitialPriceTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
	{
		var culturedInput = VehicleInitialPriceTextBox.Text.Replace(',', '.');
		var isFloat = double.TryParse(culturedInput, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
		if (isFloat)
		{
			e.Cancel = false;
			VehicleInitialPriceTextBox.BackColor = SystemColors.Window;
		}
		else
		{
			e.Cancel = true;
			VehicleInitialPriceTextBox.BackColor = Color.Red;
		}
	}
}
