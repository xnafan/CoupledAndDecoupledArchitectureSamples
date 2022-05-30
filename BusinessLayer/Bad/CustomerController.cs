using DataAccessLayer.Bad;
using Model;

namespace BusinessLayer.Bad
{
    public class CustomerController
    {
        //VERY hard coupling = BAD DEVELOPER!! :(

        //BAD STUFF:
        // 1) Controller is implementation-dependent (using a Dao CLASS)
        //  instead of contract-dependent (using a Dao INTERFACE).
        // Result:
        // - switching Dao will mean recompile and redeploy.
        // - no way to test Controller class without DB

        // 2) Controller is responsible for Dao creation
        // Result:
        // - if Dao constructor changes, controller must change
        // - switching to another Dao implementation
        //    may cause Controller methods to fail,
        //    as the Dao naming isn't enforced.

        //GOOD STUFF:
        //...it works...

        private CustomerDao _customerDao = new CustomerDao();

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerDao.getAllCustomers();
        }

        public IEnumerable<Customer> GetPotentialCustomers()
        {
            return _customerDao.getAllCustomers()
                .Where(customer => customer.AccountBalance > 0 && 
                    !customer.HasCriminalRecord);
        }
    }
}
