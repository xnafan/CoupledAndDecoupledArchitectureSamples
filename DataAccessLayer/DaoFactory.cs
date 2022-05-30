using DataAccessLayer;
using DataAccessLayer.Better;
using Microsoft.Extensions.Configuration;

namespace BusinessLayer.Better
{
    public class DaoFactory
    {
        public static ICustomerDao GetCustomerDao() 
        {
            return new CustomerDao(GetConfiguration());
        }
        private static IConfiguration GetConfiguration()
        {
            throw new NotImplementedException();
        }
    }
}