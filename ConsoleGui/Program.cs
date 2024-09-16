using BusinessLayer;
using ConsoleGui;
using DataAccessLayer;
using System.Data.SqlClient;


//register classes to their interfaces
Configure();    

//  Under the surface these UIs are very different,
//  making them increasingly more configurable
//  and easier to modify/expand/test.

new BadUI().ShowCustomers();

new BetterUI().ShowCustomers();

SuperSimpleIocContainer.Resolve<ICustomerVisualizer>().ShowCustomers();

void Configure()
{
    SuperSimpleIocContainer.Register<ICustomerDao>(() => new BrilliantCustomerDao(new SqlConnection("CONNECTION STRING")));
    SuperSimpleIocContainer.Register<ICustomerController>(() => new BrilliantCustomerController(SuperSimpleIocContainer.Resolve<ICustomerDao>()));
    SuperSimpleIocContainer.Register<ICustomerVisualizer>(() => new BrilliantUI(SuperSimpleIocContainer.Resolve<ICustomerController>()));
}