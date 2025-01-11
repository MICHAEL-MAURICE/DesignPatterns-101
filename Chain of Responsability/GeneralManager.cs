

namespace DesignPatterns.Chain_of_Responsability;

public class GeneralManager : Approver
{
    public override void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount < 50000)
        {
            Console.WriteLine($"Purchase request of {request.Amount} approved by the General Manager.");
        }
        else if (NextApprover != null)
        {
            NextApprover.ProcessRequest(request);
        }
    }
}

