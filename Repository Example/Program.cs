using RepExp1.Data;
using RepExp1.UseCases;

namespace RepExp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new CustomerRepository();
            var getCustomerUseCase = new GetCustomer(repository);

            Console.Write("Enter Customer ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var customer = getCustomerUseCase.Execute(id);

            if (customer != null)
            {
                Console.WriteLine($"Customer Found: {customer.Name}");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
    }
}
