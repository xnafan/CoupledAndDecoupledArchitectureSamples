using BusinessLayer;
using ConsoleGui;

public class BrilliantUI
{
    public void ShowCustomers()
    {
        //IMPROVEMENTS:
        //It is possible to
        // - change database server (using configuration) without recompiling
        // - refer to controller class using contract (interface) making external controller creation possible

        // UI layer has responsibility for creation of specific controller.
        //  - if customer controller constructor changes, this UI class must change too.
        // UI is still coupled to specific controller class (new CustomerController())

       ICustomerController customerController = SuperSimpleIocContainer.Resolve<ICustomerController>();

        Console.WriteLine("All customers");
        customerController.GetAllCustomers().ToList().ForEach(Console.WriteLine);

        Console.WriteLine("Potential customers");
        customerController.GetPotentialCustomers().ToList().ForEach(Console.WriteLine);

    }
}