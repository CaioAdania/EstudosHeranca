using EstudosHeranca.Entities;

namespace EstudosHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "bob", 100.0, 500.0);

            Console.WriteLine(account.Balance);

        }
    }
}
