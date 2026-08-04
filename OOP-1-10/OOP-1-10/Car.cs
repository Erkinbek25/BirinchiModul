namespace OOP_1_10;

public class Car
{
	public Car()
	{
		Brand = "Tesla";
	}

	public Car(string brand, string model, string color, DateTime year)
    {
        Brand = brand;
        Model = model;
        Color = color;
        Year = year;
    }

     public string Brand { get; set; }
	public string Model { get; set; }
	public string Color { get; set; }
	public DateTime Year { get; set; }

	public void Start()
	{

	}
}

