using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab;

public sealed partial class MainForm : Form
{
	private readonly BindingSource _bindingSource;
	private readonly List<Vehicle> _vehicles;

	private enum VehicleType { Car, Truck, None }

	public MainForm()
	{
		InitializeComponent();

		_vehicles = new List<Vehicle>();

		_bindingSource = new BindingSource
		{
			DataSource = _vehicles
		};

		VehicleGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		VehicleGridView.DataSource = _bindingSource;

		VehicleGridView.Columns[0].HeaderText = "Марка";
		VehicleGridView.Columns[1].HeaderText = "Год выпуска";
		VehicleGridView.Columns[2].HeaderText = "Исходная стоимость";
		VehicleGridView.Columns[3].HeaderText = "Текущая стоимость";
		VehicleGridView.Columns[4].HeaderText = "Тип";

		VehicleGridView.CellFormatting += VehicleGridView_CellFormatting;

        // If any element of form changes...
        VehicleBrandTextBox.TextChanged += OnFormChanged;
		VehicleReleaseYearTextBox.TextChanged += OnFormChanged;
		VehicleInitialPriceTextBox.TextChanged += OnFormChanged;
		VehicleTypeComboBox.SelectedIndexChanged += OnFormChanged;
	}

	private void OnFormChanged(object? sender, EventArgs e)
	{
		SaveButton.Enabled = IsFormFilled();
	}

	private void VehicleGridView_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		var isRowSelected = e.RowIndex != -1;

		DeleteButton.Enabled = isRowSelected;
		CopyButton.Enabled = isRowSelected;
	}
}
