namespace OOPH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Name = "My Bank";
            if(bank == null)
            {
                Console.WriteLine("Bank Can't Be Empty");
            }
            else
            {
                bank.PerformAction(ActionType.Deposit, 12000, 12331, 1232131);
            }
        }
    }
}