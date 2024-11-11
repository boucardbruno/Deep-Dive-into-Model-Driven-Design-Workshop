namespace SeatsSuggestions;

public class SeatingPlace
{
    public SeatingPlace(string rowName, int number, PricingCategory pricingCategory, SeatingPlaceAvailability seatingPlaceAvailability)
    {
        RowName = rowName;
        Number = number;
        PricingCategory = pricingCategory;
        SeatingPlaceAvailability = seatingPlaceAvailability;
    }

    public string RowName { get; }
    public int Number { get; }
    public PricingCategory PricingCategory { get; }
    private SeatingPlaceAvailability SeatingPlaceAvailability { get; set; }

    public bool IsAvailable()
    {
        return SeatingPlaceAvailability == SeatingPlaceAvailability.Available;
    }

    public override string ToString()
    {
        return $"{RowName}{Number}";
    }

    public bool MatchCategory(PricingCategory pricingCategory)
    {
        return PricingCategory == pricingCategory;
    }

    public void Allocate()
    {
        if (SeatingPlaceAvailability == SeatingPlaceAvailability.Available) SeatingPlaceAvailability = SeatingPlaceAvailability.Allocated;
    }
}