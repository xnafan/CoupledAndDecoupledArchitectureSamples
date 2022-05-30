using Model;
using System.Data.SqlClient;

namespace DataAccessLayer.Brilliant
{
    public class CustomerDao : ICustomerDao
    {
        private SqlConnection _connection;

        //TOTAL decoupling = BRILLIANT DEVELOPER!  :-D
        //- Connectionstring storage mechanism
        //  is now up to user of the Dao class
        public CustomerDao(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
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