using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace lab;

public sealed partial class MainForm : Form
{
	private readonly BindingSource _bindingSource;
	private readonly List<Vehicle> _vehicles;

	private enum VehicleType { Car, Truck, None };

	public MainForm()
	{
		InitializeComponent();

		_vehicles = new List<Vehicle>();

		_bindingSource = new BindingSource()
		{
			DataSource = _vehicles
		};

		#region VehicleGridView Setup

		VehicleGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		VehicleGridView.DataSource = _bindingSource;

		#endregion

		// If any element of form changes...
		VehicleBrandTextBox.TextChanged += OnFormChanged;
		VehicleReleaseYearTextBox.TextChanged += OnFormChanged;
		VehicleInitialPriceTextBox.TextChanged += OnFormChanged;
		VehicleTypeComboBox.SelectedIndexChanged += OnFormChanged;
	}

	private bool IsFormFilled()
	{
		var brandIsFilled = VehicleBrandTextBox.Text != string.Empty;
		var yearIsFilled = VehicleReleaseYearTextBox.Text != string.Empty;
		var priceIsFilled = VehicleInitialPriceTextBox.Text != string.Empty;
		var typeIsSelected = VehicleTypeComboBox.SelectedIndex != -1;

		return brandIsFilled && yearIsFilled && priceIsFilled && typeIsSelected;
	}

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

	private void OnFormChanged(object? sender, EventArgs e)
	{
		SaveButton.Enabled = IsFormFilled();
	}

	private void ClearForm()
	{
		VehicleBrandTextBox.Clear();
		VehicleReleaseYearTextBox.Clear();
		VehicleInitialPriceTextBox.Clear();
		VehicleTypeComboBox.SelectedIndex = -1;
	}

	private void VehicleGridView_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		var isRowSelected = e.RowIndex != -1;

		DeleteButton.Enabled = isRowSelected;
		CopyButton.Enabled = isRowSelected;
	}
}
