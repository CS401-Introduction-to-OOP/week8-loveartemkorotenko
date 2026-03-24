namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _deliveryItems = new List<T>();

    public void AddItem(T item)
    {
        _deliveryItems.Add(item);
    }

    public double GetTotalCost()
    {
        double TotalCost = 0;
        
        foreach (var item in _deliveryItems)
        {
            TotalCost += item.CalculateCost();
        }

        return TotalCost;
    }
}
