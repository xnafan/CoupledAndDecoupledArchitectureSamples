using DataAccessLayer;
using Model;

namespace BusinessLayer.Brilliant
{
    public class CustomerController
    {
        //BRILLIANT DEVELOPER = TOTAL decoupling :)

        //GOOD STUFF:
        // - Responsibility for construction of the Dao
        //   is left up to external code

        private ICustomerDao _customerDao;

        public CustomerController(ICustomerDao customerDao)
        {
            _customerDao = customerDao;
        }

        public IEnumerable<Customer> GetAllCustomers() => _customerDao.getAllCustomers();

        public IEnumerable<Customer> GetPotentialCustomers()
        {
            return _customerDao.getAllCustomers()
                .Where(customer => customer.AccountBalance > 0 && 
                    !customer.HasCriminalRecord);
        }
    }
}