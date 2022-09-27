namespace lab;

public abstract class Vehicle
{
	public string Brand { get; set; }
	public uint ReleaseYear { get; set; }
	public double InitialPrice { get; set; }

	public Vehicle(string brand, uint releaseYear, double initialPrice)
	{
		Brand = brand;
		ReleaseYear = releaseYear;
		InitialPrice = initialPrice;
	}

	public abstract double CalculatePrice();
}
