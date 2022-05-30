//They look very similar
//  but under the surface they are very different
//  making them increasingly more configurable
//  and easier to modify/expand/test.

using BusinessLayer;
using BusinessLayer.Brilliant;
using ConsoleGui;
using DataAccessLayer.Brilliant;

Configure();

new BadUI().ShowCustomers();

new BetterUI().ShowCustomers();

new BrilliantUI().ShowCustomers();


void Configure()
{
    SuperSimpleIocContainer.Register<ICustomerController>(() => new CustomerController( new CustomerDao("")));
}
