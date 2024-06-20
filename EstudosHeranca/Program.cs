using EstudosHeranca.Entities;

namespace EstudosHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //upcasting

            Account acc1 = bacc; //compilador aceita, pois a herança é uma relção é um, logo bacc é acc, saving é acc, logo aceita
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //Downcasting operação insegura, somente quando necessario

            BusinessAccount acc4 = (BusinessAccount)acc2; //para fazer um downcasting, declaramos desta forma, perceba que acc2 é businessaccount
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;//porem é um savingsaccount, e o savingaccount é sub classe igual o businessaccount
            if(acc3 is BusinessAccount) //testando se é instancia de businessaccount e no caso o if falha, não dando erro
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                    Console.WriteLine("Loan");
            }

            if(acc3 is SavingsAccount) //aqui esse if foi um sucesso e rodou, pois é um savingsaccount
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;//com isso fizemos um downcasting para savings
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
