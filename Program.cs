#region  Chain of Responsibility pattern

// Create the handlers
using DesignPatterns.Chain_of_Responsability;

Approver departmentManager = new DepartmentManager();
Approver generalManager = new GeneralManager();
Approver board = new Board();

// Set the chain: Department Manager -> General Manager -> Board
departmentManager.SetNextApprover(generalManager);
generalManager.SetNextApprover(board);

// Create some purchase requests
PurchaseRequest request1 = new PurchaseRequest(5000, "Laptops");
PurchaseRequest request2 = new PurchaseRequest(20000, "Office Furniture");
PurchaseRequest request3 = new PurchaseRequest(80000, "Major Project Supplies");

// Pass the requests into the chain starting with the department manager
departmentManager.ProcessRequest(request1);
departmentManager.ProcessRequest(request2);
departmentManager.ProcessRequest(request3);

Console.ReadLine();
#endregion