using _03._ChainOfResponsibility.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._ChainOfResponsibility.Models
{
    public class Director : Approver
    {
        public override void ApproveInvestment(Investment investment)
        {
            if (investment.Amount < 50000.0)
            {
                PrintApprovedMessage(investment.Title);
            }
            else if (approver != null)
            {
                PrintDelegationMessage();
                approver.ApproveInvestment(investment);
            }
        }
    }
}
