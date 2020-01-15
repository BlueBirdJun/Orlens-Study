using System;
using System.Collections.Generic;
using System.Text;

namespace OCatle.Grains.Common.EventSourcing
{
    public abstract class BankAccountEvent
    {
        public decimal Amount { get; set; }
    }
    public class Deposited : BankAccountEvent { }
    public class Withdrawn : BankAccountEvent { }

    public class BankAccountState
    {
        public decimal Balance { get; set; }

        public BankAccountState Apply(Deposited evnt)
        {
            Balance += evnt.Amount;
            return this;
        }

        public BankAccountState Apply(Withdrawn evnt)
        {
            Balance -= evnt.Amount;
            return this;
        }
    }
}
