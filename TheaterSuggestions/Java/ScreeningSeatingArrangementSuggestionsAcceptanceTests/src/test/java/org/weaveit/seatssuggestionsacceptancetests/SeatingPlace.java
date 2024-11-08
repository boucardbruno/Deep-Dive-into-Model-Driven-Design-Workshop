package org.weaveit.seatssuggestionsacceptancetests;

public class SeatingPlace {

    private final String rowName;
    private final int number;
    private final PricingCategory pricingCategory;
    private SeatingPlaceAvailability seatingPlaceAvailability;

    public SeatingPlace(String rowName, int number, PricingCategory pricingCategory, SeatingPlaceAvailability seatingPlaceAvailability) {
        this.rowName = rowName;
        this.number = number;
        this.pricingCategory = pricingCategory;
        this.seatingPlaceAvailability = seatingPlaceAvailability;
    }

    public boolean isAvailable() {
        return seatingPlaceAvailability == SeatingPlaceAvailability.Available;
    }


    public void updateCategory(SeatingPlaceAvailability seatingPlaceAvailability) {
        this.seatingPlaceAvailability = seatingPlaceAvailability;
    }

    @Override
    public String toString() {
        return rowName + number;
    }
}

