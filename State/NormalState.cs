using System;

namespace State
{
    /// <summary>
    /// 具体状态类： 正常类
    /// </summary>
    internal class NormalState : AccountState
    {
        public NormalState(Account account)
        {
            this.account = account;
        }

        public NormalState(AccountState state)
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
            Console.WriteLine("正常状态，无需支付利息");
        }

        /// <summary>
        /// 状态转换
        /// </summary>
        public override void StateCheck()
        {
            if(account.Balance > -2000 && account.Balance <= 0)
            {
                account.State = new OverdraftState(this);
            }
            else if(account.Balance == -2000)
            {
                account.State = new RestrictedState(this);
            }
            else if (account.Balance < -2000)
            {
                Console.WriteLine("操作受限!!!");
            }
        }


    }
}