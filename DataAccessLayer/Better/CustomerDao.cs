using Microsoft.Extensions.Configuration;
using Model;
using System.Data.SqlClient;

namespace DataAccessLayer.Better
{
    public class CustomerDao : ICustomerDao
    {
        private SqlConnection _connection;
        
        //IMPROVED decoupling = BETTER DEVELOPER :)
        
        //GOOD STUFF
        //- Connectionstring is now configurable
        //  and can be edited externally
        //  without recompile or redeploy

        //BAD STUFF
        //- Code that is responsible for Dao class construction
        //  has to support the IConfiguration interface
        //  (extra complexity in tests)
        public CustomerDao(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("BankingConnectionString");
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