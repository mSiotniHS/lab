using System;
using System.Windows.Forms;

namespace lab;

partial class MainForm
{
	private void SaveButton_Click(object sender, EventArgs e)
	{
		if (!IsFormFilled()) return;

		var (brand, year, price, type) = CurrentInputState;

		Vehicle vehicle = type switch
		{
			VehicleType.Car => new Car(brand, year, price),
			VehicleType.Truck => new Truck(brand, year, price),
			VehicleType.None => throw new Exception("VehicleComboBox.SelectedIndex is somehow incorrect"),
			_ => throw new Exception("That's... interesting")
		};

		if (!_vehicles.Contains(vehicle))
		{
			_vehicles.Add(vehicle);
			_bindingSource.ResetBindings(false);
			ClearForm();
		}
		else
		{
			MessageBox.Show(
				"Такой автомобиль уже находится в списке",
				"Ошибка",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}

	private void DeleteButton_Click(object sender, EventArgs e)
	{
		var selectedRow = VehicleGridView.CurrentCell.RowIndex;
		if (selectedRow == -1) return;

		var result = MessageBox.Show(
			"Удалить выбранный автомобиль?",
			"Удаление",
			MessageBoxButtons.OKCancel,
			MessageBoxIcon.Question);

		if (result == DialogResult.OK)
		{
			_vehicles.RemoveAt(selectedRow);
			_bindingSource.ResetBindings(false);
		}
	}

	private void CopyButton_Click(object sender, EventArgs e)
	{
		var selectedRow = VehicleGridView.CurrentCell.RowIndex;
		if (selectedRow == -1) return;

		CurrentInputState = _vehicles[selectedRow] switch
		{
			Car car => (car.Brand, car.ReleaseYear, car.InitialPrice, VehicleType.Car),
			Truck truck => (truck.Brand, truck.ReleaseYear, truck.InitialPrice, VehicleType.Truck),
			_ => throw new Exception("_vehicles stores not only vehicles...")
		};
	}

	private void SortButton_Click(object sender, EventArgs e)
	{
		_vehicles.Sort((first, second) =>
		{
			var byReleaseYear = first.ReleaseYear.CompareTo(second.ReleaseYear);
			return byReleaseYear != 0 ? byReleaseYear : first.CalculatePrice().CompareTo(second.CalculatePrice());
		});

		_bindingSource.ResetBindings(false);
	}
}
