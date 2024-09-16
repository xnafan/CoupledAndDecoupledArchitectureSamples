using Model;

namespace DataAccessLayer;

public interface ICustomerDao
{
    Customer? Get(string email);
    IEnumerable<Customer> GetAll();
    int Insert(Customer customer);
    bool Update(Customer customer);
    bool Delete(Customer customer);
}
