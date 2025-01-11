

namespace DesignPatterns.Chain_of_Responsability;

public class DepartmentManager : Approver
{
    public override void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount < 10000)
        {
            Console.WriteLine($"Purchase request of {request.Amount} approved by the Department Manager.");
        }
        else if (NextApprover != null)
        {
            NextApprover.ProcessRequest(request);
        }
    }
}

