using BusinessLayer;
namespace ConsoleGui.Brilliant;
public class BrilliantUI : ICustomerVisualizer
{
    //IMPROVEMENTS:
    //It is possible to
    // - change database server (using configuration) without recompiling
    // - refer to controller class using contract (interface) making external controller creation possible

    // UI layer has responsibility for creation of specific controller.
    //  - if customer controller constructor changes, this UI class must change too.
    // UI is still coupled to specific controller class (new CustomerController())

    ICustomerController _customerController;

    public BrilliantUI(ICustomerController customerController)
    {
        _customerController = customerController;
    }

    public void ShowCustomers()
    {
        Console.WriteLine("All customers");
        _customerController.GetAllCustomers().ToList().ForEach(Console.WriteLine);

        Console.WriteLine("Potential customers");
        _customerController.GetPotentialCustomers().ToList().ForEach(Console.WriteLine);
    }
}