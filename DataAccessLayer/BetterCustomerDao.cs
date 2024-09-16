using Microsoft.Extensions.Configuration;
using Model;
using System.Data.SqlClient;

namespace DataAccessLayer;

public class BetterCustomerDao : ICustomerDao
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
    public BetterCustomerDao(IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("BankingConnectionString");
        _connection = new SqlConnection(connectionString);
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