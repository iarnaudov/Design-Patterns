using _03._ChainOfResponsibility.Interface;
using _03._ChainOfResponsibility.Models;
using System;

namespace _03._ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver Tim = new Manager();
            Approver Davy = new Director();
            Approver Lawrence = new President();

            Tim.SetNextApprover(Davy);
            Davy.SetNextApprover(Lawrence);

            Investment inv1 = new Investment("Aircraft", 75000);
            Investment inv2 = new Investment("Air compressor", 9000);
            Investment inv3 = new Investment("Warehouse truck", 35000);
            Tim.ApproveInvestment(inv1);
            Tim.ApproveInvestment(inv2);
            Tim.ApproveInvestment(inv3);
        }
    }
}
