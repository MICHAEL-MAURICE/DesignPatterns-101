

namespace DesignPatterns.Chain_of_Responsability;

public class PurchaseRequest
{
    public decimal Amount { get; }
    public string Purpose { get; }

    public PurchaseRequest(decimal amount, string purpose)
    {
        Amount = amount;
        Purpose = purpose;
    }
}
