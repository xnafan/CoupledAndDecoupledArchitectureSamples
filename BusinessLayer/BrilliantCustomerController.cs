using DataAccessLayer;
using Model;

namespace BusinessLayer;
public class BrilliantCustomerController : ICustomerController
{
    //BRILLIANT DEVELOPER = TOTAL decoupling :)

    //GOOD STUFF:
    // - Responsibility for construction of the Dao
    //   is left up to external code, and the Dao class
    //   is referenced via the contract (interface)
    // - Controller implements interface
    //   so references can be made to the functionality (interface)
    //   instead of the implementation (class)

    //BAD STUFF:
    // ...none... ;-)

    private ICustomerDao _customerDao;

    public BrilliantCustomerController(ICustomerDao customerDao)
    {
        _customerDao = customerDao;
    }

    public IEnumerable<Customer> GetAllCustomers() => _customerDao.GetAll();

    public IEnumerable<Customer> GetPotentialCustomers()
    {
        return _customerDao.GetAll()
            .Where(customer => customer.AccountBalance > 0 &&
                !customer.HasCriminalRecord);
    }
}