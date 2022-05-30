﻿using Model;
using System.Data.SqlClient;

namespace DataAccessLayer.Bad
{
    public class CustomerDao
    {
        private SqlConnection _connection;
        public CustomerDao()
        {
            //VERY hard coupling = BAD DEVELOPER! :(

            //BAD STUFF:
            //Connectionstring hardcoded into connection class
            //Result: No way to change DB server without recompile and -deploy 
            
            //GOOD STUFF:
            //...it works...
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