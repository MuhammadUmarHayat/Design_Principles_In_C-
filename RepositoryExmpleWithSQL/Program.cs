namespace RepositoryExmple1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerRepository repository = new CustomerRepository();
            Customer customer1 = new Customer();
            customer1.Name = "Amna";
            customer1.Email = "am@gmail.com";

            repository.addCustomer(customer1);

           var  customers = repository.GetAllCustomers();

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer ID: {customer.customerId}, Name: {customer.Name}, Email: {customer.Email}");
            }

            Console.ReadLine();
        }
    }
}
