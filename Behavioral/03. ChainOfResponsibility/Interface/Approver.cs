using _03._ChainOfResponsibility.Models;
using System;

namespace _03._ChainOfResponsibility.Interface
{
    public abstract class Approver
    {
        protected Approver approver;

        public void SetNextApprover(Approver approver)
        {
            this.approver = approver;
        }

        protected void PrintApprovedMessage(string investmentTitle)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} approved request: {1}", this.GetType().Name, investmentTitle);
            Console.ResetColor();
        }

        protected void PrintDelegationMessage()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Investment too big for " + this.GetType().Name + ". Delegated to " + approver.GetType().Name);
            Console.ResetColor();
        }

        public abstract void ApproveInvestment(Investment investment);

    }
}
