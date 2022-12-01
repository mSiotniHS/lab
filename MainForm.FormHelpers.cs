using System;
using System.Globalization;
using System.Windows.Forms;

namespace lab;

partial class MainForm
{
	private (string, uint, double, VehicleType) CurrentInputState
	{
		get
		{
			var brand = VehicleBrandTextBox.Text;
			var year = uint.Parse(VehicleReleaseYearTextBox.Text);
			var price = double.Parse(VehicleInitialPriceTextBox.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
			var type = VehicleTypeComboBox.SelectedIndex switch
			{
				0 => VehicleType.Car,
				1 => VehicleType.Truck,
				_ => VehicleType.None
			};

			return (brand, year, price, type);
		}
		set
		{
			var (brand, year, price, type) = value;

			VehicleBrandTextBox.Text = brand;
			VehicleReleaseYearTextBox.Text = year.ToString();
			VehicleInitialPriceTextBox.Text = price.ToString(CultureInfo.InvariantCulture);
			VehicleTypeComboBox.SelectedIndex = type switch
			{
				VehicleType.Car => 0,
				VehicleType.Truck => 1,
				VehicleType.None => -1,
				_ => throw new Exception("That's... unreal")
			};
		}
	}

	private bool IsFormFilled()
	{
		var brandIsFilled = VehicleBrandTextBox.Text != string.Empty;
		var yearIsFilled = VehicleReleaseYearTextBox.Text != string.Empty;
		var priceIsFilled = VehicleInitialPriceTextBox.Text != string.Empty;
		var typeIsSelected = VehicleTypeComboBox.SelectedIndex != -1;

		return brandIsFilled && yearIsFilled && priceIsFilled && typeIsSelected;
	}

	private void ClearForm()
	{
		VehicleBrandTextBox.Clear();
		VehicleReleaseYearTextBox.Clear();
		VehicleInitialPriceTextBox.Clear();
		VehicleTypeComboBox.SelectedIndex = -1;
	}

	private static void VehicleGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
	{
		// formatting prices
		if (e.Value is null || e.ColumnIndex is not (2 or 3)) return;

		var price = Convert.ToDouble(e.Value);
		e.Value = Math.Round(price, 2);
	}
}
