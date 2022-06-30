using Model;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BadCustomerDao
    {
        private SqlConnection _connection;
        public BadCustomerDao()
        {
            //VERY hard coupling = BAD DEVELOPER! :(

            //GOOD STUFF:
            //...it works...
            
            //BAD STUFF:
            //Connectionstring hardcoded into connection class
            //Result: No way to change DB server without recompile and redeploy 
            
            _connection = new SqlConnection("[ sample connection string ]");
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