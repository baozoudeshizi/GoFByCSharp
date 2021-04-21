using System;

namespace State
{
    internal class OverdraftState : AccountState
    {

        public OverdraftState(AccountState state)
        {
            this.account = state.account;
        }

        public override void Deposit(double amount)
        {
            account.Balance += amount;
            StateCheck();
        }

        internal override void Withdraw(double amount)
        {
            account.Balance -= amount;
            StateCheck();
        }

        internal override void ComputeInterest()
        {
            Console.WriteLine("透支状态，需要计算利息");
        }




        public override void StateCheck()
        {
            if (account.Balance > 0)
            {
                account.State = new NormalState(this);
            }
            else if(account.Balance == -2000)
            {
                account.State = new RestrictedState(this);
            }
            else
            {
                Console.WriteLine("操作受限");
            }
        }
    }
}