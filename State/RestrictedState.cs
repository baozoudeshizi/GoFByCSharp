using System;

namespace State
{
    internal class RestrictedState : AccountState
    {
        public RestrictedState(AccountState state)
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
            Console.WriteLine("账号受限，取款失败！！！");
        }

        internal override void ComputeInterest()
        {
            Console.WriteLine("计算利息！！！");
        }
        public override void StateCheck()
        {
            if (account.Balance>0)
            {
                account.State = new NormalState(this);
            }
            else if (account.Balance > -2000)
            {
                account.State = new OverdraftState(this);
            }
        }




    }
}