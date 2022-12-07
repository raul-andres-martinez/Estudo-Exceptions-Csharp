using ByteBank.Models;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Raul", "123", "Estagiário");


            CurrentAccount conta1 = new CurrentAccount(customer1, 2, "120");

            Console.WriteLine(customer1.ToString());
        }
    }
}
