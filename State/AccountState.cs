namespace State
{
    public abstract class AccountState
    {
        public Account account;
        public abstract void Deposit(double amount);

        internal abstract void Withdraw(double amount);
        internal abstract void ComputeInterest();


        public abstract void StateCheck();
    }
}