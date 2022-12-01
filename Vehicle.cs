using System;

namespace lab;

public abstract class Vehicle
{
	public string Brand { get; }
	public uint ReleaseYear { get; }
	public double InitialPrice { get; }

	protected Vehicle(string brand, uint releaseYear, double initialPrice)
	{
		Brand = brand;
		ReleaseYear = releaseYear;
		InitialPrice = initialPrice;
	}

	public abstract double CalculatePrice();

	public override bool Equals(object? obj)
	{
		return obj switch
		{
			Vehicle vehicle => vehicle.Brand == Brand && vehicle.ReleaseYear == ReleaseYear && Math.Abs(vehicle.InitialPrice - InitialPrice) < 0.01,
			_ => throw new NotImplementedException()
		};
	}
}
