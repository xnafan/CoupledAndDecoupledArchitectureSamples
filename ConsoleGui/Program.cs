using BusinessLayer;
using BusinessLayer.Brilliant;
using ConsoleGui;
using ConsoleGui.Bad;
using ConsoleGui.Better;
using ConsoleGui.Brilliant;
using DataAccessLayer;
using DataAccessLayer.Brilliant;

Configure();

//  Under the surface these UIs are very different,
//  making them increasingly more configurable
//  and easier to modify/expand/test.

new BadUI().ShowCustomers();

new BetterUI().ShowCustomers();

SuperSimpleIocContainer.Resolve<ICustomerVisualizer>().ShowCustomers();

void Configure()
{
    SuperSimpleIocContainer.Register<ICustomerVisualizer>(() => new BrilliantUI(SuperSimpleIocContainer.Resolve<ICustomerController>()));
    SuperSimpleIocContainer.Register<ICustomerController>(() => new CustomerController(SuperSimpleIocContainer.Resolve<ICustomerDao>()));
    SuperSimpleIocContainer.Register<ICustomerDao>(() => new CustomerDao("CONNECTION STRING EXAMPLE"));
}