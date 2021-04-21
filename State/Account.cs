using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Account
    {
        public AccountState State { get; set; } //维持一个对抽象状态的引用
        public string Owner { get; set; }   //开户名
        public double Balance { get; set; }  //账户余额


        public Account(string owner, double init)
        {
            this.Owner = owner;
            this.Balance = init;
            this.State = new NormalState(this);  //设置初始状态
            Console.WriteLine(this.Owner + "开户，初始金额为" + init);
            Console.WriteLine("------------------------------------");

        }
       

        /// <summary>
        /// 往账户中存钱
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(double amount)
        {
            Console.WriteLine(this.Owner + "存款" + amount);
            State.Deposit(amount); //调用状态对象的存款方法
            Console.WriteLine("现在的余额为" + this.Balance);
            Console.WriteLine("现在的账户状态为：" + this.State.GetType().Name);
            Console.WriteLine("------------------------------------");
        }


        /// <summary>
        /// 从账户中取钱
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw(double amount)
        {
            Console.WriteLine(this.Owner + "取款" + amount);
            State.Withdraw(amount); //调用状态对象的存款方法
            Console.WriteLine("现在的余额为" + this.Balance);
            Console.WriteLine("现在的账户状态为：" + this.State.GetType().Name);
            Console.WriteLine("------------------------------------");
        }

        /// <summary>
        /// 计算利息
        /// </summary>
        public void ComputeInterest()
        {
            State.ComputeInterest(); //调用状态对象的computeInterest方法
        }
    }
}
