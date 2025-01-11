
namespace DesignPatterns.Chain_of_Responsability;

public class Board : Approver
{
    public override void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount >= 50000)
        {
            Console.WriteLine($"Purchase request of {request.Amount} referred to the Board for consideration.");
        
    }
    }
}

