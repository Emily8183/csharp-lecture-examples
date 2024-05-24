namespace Chapter08;

public interface IDiscountable
{
    void ApplyPercentDiscount(double percent);

    void ApplyFlatDiscount(double amount);

    void RemoveDiscount();
}
