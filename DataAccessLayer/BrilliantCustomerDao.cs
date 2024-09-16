using Model;
using System.Data;

namespace DataAccessLayer;
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
    public bool Delete(Customer person)
    {
        throw new NotImplementedException();
    }
    public Customer Get(string email)
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