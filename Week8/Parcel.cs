namespace Week8;

public class Parcel : DeliveryItem
{
    public string Dimensions { get; }

    public Parcel(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
        Dimensions="20*30*15";
    }

    public override double CalculateCost()
    {
        return (50 + (Weight * 25));
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"The parcel dimensions is {Dimensions}");
    }
}