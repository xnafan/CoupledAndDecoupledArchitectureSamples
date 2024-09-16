using Model;
using System.Data.SqlClient;

namespace DataAccessLayer;
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
    public bool Delete(Customer person)
    {
        throw new NotImplementedException();
    }
    public Customer? Get(string email)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Customer> GetAll()
    {
        throw new NotImplementedException();
    }
    public int Insert(Customer person)
    {
        throw new NotImplementedException();
    }
    public bool Update(Customer person)
    {
        throw new NotImplementedException();
    }
}