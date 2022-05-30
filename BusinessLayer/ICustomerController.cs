using Model;

namespace BusinessLayer
{
    public interface ICustomerController
    {
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<Customer> GetPotentialCustomers();
    }
}