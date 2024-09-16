using DataAccessLayer;
using Microsoft.Extensions.Configuration;

namespace BusinessLayer;
public class DaoFactory
{
    public static ICustomerDao GetCustomerDao() 
    {
        return new BetterCustomerDao(GetConfiguration());
    }
    private static IConfiguration GetConfiguration()
    {
        throw new NotImplementedException();
    }
}