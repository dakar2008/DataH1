using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1
{
    internal enum ActionType
    {
        Deposit,
        Withdraw
    }
    internal enum PersonGender
    {
        Male,
        Female
    }

    internal class Bank
    {
        /// <summary>
        /// Name of the bank
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// List of customers
        /// </summary>
        public List<Customer> Customers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">Type of account action</param>
        /// <param name="amount">Amount to deposit / withdraw</param>
        /// <param name="customerId">Id of customer</param>
        /// <param name="accountNumber">Accountnumber for the account to peform action</param>
        public void PerformAction(ActionType type, decimal amount, int customerId, int accountNumber)
        {
            Customer? customer;
            if(this.Customers != null)
            {
                customer = this.Customers.FirstOrDefault(x => x.Id == customerId);
                if (customer != null)
                {
                    Account account = customer.Person.Accounts.FirstOrDefault(x => x.AccountNumber == accountNumber);
                    if (account != null)
                    {
                        Action action = new Action();
                        action.Amount = amount;

                        if (type == ActionType.Withdraw)
                        {
                            if (account.Balance > amount)
                            {
                                account.Balance -= amount;
                                action.Type = ActionType.Withdraw;

                                Console.WriteLine($"{amount} withdraw from {account.Name}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Founds!");
                            }
                        }
                        else
                        {
                            account.Balance += amount;
                            action.Type = ActionType.Deposit;

                            Console.WriteLine($"{amount} depost to {account.Name}");
                        }
                        account.Actions.Add(action);
                    }
                    else
                    {
                        Console.WriteLine($"Could not find account with id: {accountNumber}");
                    }
                }
                else
                {
                    Console.WriteLine($"Could not find a customer with social security number: {customerId}");
                }
            }
            else
            {
                Console.WriteLine($"{Name} has no customers");
            }
        }
    }
    internal class Customer
    {
        /// <summary>
        /// Customer Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Person behind the customer
        /// </summary>
        public Person Person { get; set; }
    }
    internal class Person : Human
    {
        /// <summary>
        /// Social Security Number
        /// </summary>
        public int CPR { get; set; }
        /// <summary>
        /// Name of the person
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Adress of the person
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Zipcode where the person lives
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// City where person lives
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Gender of the person
        /// </summary>
        public PersonGender Gender { get; set; }
        /// <summary>
        /// Persons accounts
        /// </summary>
        public List<Account> Accounts { get; set; }
    }
    /// <summary>
    /// Bank Account
    /// </summary>
    internal class Account
    {
        /// <summary>
        /// Account number
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Account Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Balance of the account
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// Annual rate on the account
        /// </summary>
        public double AnnualRate { get; set; }
        /// <summary>
        /// Monthly service charges
        /// </summary>
        public double MonthlyServiceCharges { get; set; }
        /// <summary>
        /// Actions performed on the account
        /// </summary>
        public List<Action> Actions { get; set; }
    }
    internal class Action
    {
        /// <summary>
        /// Amount withdraw / deposit
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Action type
        /// </summary>
        public ActionType Type { get; set; }
    }
}