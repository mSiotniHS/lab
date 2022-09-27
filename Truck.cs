using System;

namespace lab;

public class Truck : Vehicle
{
	public Truck(string brand, uint releaseYear, double initialPrice) : base(brand, releaseYear, initialPrice)
	{
	}

	public override double CalculatePrice()
	{
		var currentYear = DateTime.Now.Year;
		var difference = currentYear - ReleaseYear;
		var regressionFactor = difference switch
		{
			0 => 0,
			<= 3 => 0.1,
			<= 10 => 0.2,
			_ => 0.3
		};

		return InitialPrice * (1 - regressionFactor);
	}
}
