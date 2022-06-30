using Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BrilliantCustomerDao : ICustomerDao
    {
        //TOTAL decoupling = BRILLIANT DEVELOPER!  :-D

        //GOOD STUFF:
        // - Connectionstring storage mechanism
        //  is now up to user of the Dao class
        // - we're depending on a higher level of abstraction:
        //   IDbConnection instead of SqlConnection/OleDbConnection or similar

        //BAD STUFF:
        // ...none... ;-)

        private IDbConnection _connection;

        public BrilliantCustomerDao(IDbConnection connection)
        {
            _connection = connection;
        }
        public bool deleteCustomer(Customer person)
        {
            throw new NotImplementedException();
        }
        public Customer getCustomer(string email)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Customer> getAllCustomers()
        {
            throw new NotImplementedException();
        }
        public void saveCustomer(Customer person)
        {
            throw new NotImplementedException();
        }
        public bool updateCustomer(Customer person)
        {
            throw new NotImplementedException();
        }
    }
}

