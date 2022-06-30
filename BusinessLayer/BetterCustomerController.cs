using DataAccessLayer;
using Model;

namespace BusinessLayer
{
    public class BetterCustomerController : ICustomerController
    {
        //BETTER DEVELOPER = IMPROVED decoupling :)

        //GOOD STUFF:
        // - Responsibility for construction of the Dao
        //   is moved out of the controller, into a factory
        //   (and can thus be centralized)
        // - Controller is dependent on contract (Dao interface)
        //   instead of implementation (Dao class)
        // - Controller is now defined using a contract (interface)
        //   which means that classes using the Controller can swap it
        //   for another implementation

        //BAD STUFF:
        // - controller still has responsibility for retrieving Dao
        // - still hard to test controller without a DB server. 

        private ICustomerDao _customerDao = DaoFactory.GetCustomerDao();

        public IEnumerable<Customer> GetAllCustomers() => _customerDao.getAllCustomers();

        public IEnumerable<Customer> GetPotentialCustomers()
        {
            return _customerDao.getAllCustomers()
                .Where(customer => customer.AccountBalance > 0 && 
                    !customer.HasCriminalRecord);
        }
    }

   
}
