using Model;

namespace DataAccessLayer
{
    public interface ICustomerDao
    {
        IEnumerable<Customer> getAllCustomers();
        Customer? getCustomer(string email);
        bool deleteCustomer(Customer customer);
        bool updateCustomer(Customer customer);
        void saveCustomer(Customer customer);
    }
}
