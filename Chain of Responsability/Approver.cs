
namespace DesignPatterns.Chain_of_Responsability;
public abstract class Approver
{
    protected Approver NextApprover { get; set; }

    public void SetNextApprover(Approver next)
    {
        NextApprover = next;
    }

    public abstract void ProcessRequest(PurchaseRequest request);
}

