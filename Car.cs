using System;

namespace lab;

public sealed class Car : Vehicle
{
	public Car(string brand, uint releaseYear, double initialPrice) : base(brand, releaseYear, initialPrice)
	{
	}

	public override double CalculatePrice()
	{
		var currentYear = DateTime.Now.Year;
		var difference = currentYear - ReleaseYear;
		const double regressionFactor = 0.1;

		return InitialPrice * Math.Pow(1 - regressionFactor, difference);
	}
}
