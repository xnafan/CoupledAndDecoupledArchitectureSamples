using DataAccessLayer;
using DataAccessLayer.Better;
using Model;

namespace BusinessLayer.Better
{
    public class CustomerController
    {
        //BETTER DEVELOPER = IMPROVED decoupling :)

        //GOOD STUFF:
        // - Responsibility for construction of the Dao
        //   is moved out of the controller (and can be centralized)
        // - Controller is dependent on contract (Dao interface)
        //   instead of implementation (Dao class)

        //BAD STUFF:
        // - controller still has responsibility for retrieving Dao
        // - still hard to test controller without an active DB. 

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
