using BusinessLayer;
namespace ConsoleGui;
public class BrilliantUI : ICustomerVisualizer
{
    //IMPROVEMENTS:
    //It is possible to
    // - refer to controller class using contract (interface)
    //   making external controller creation possible

    //BAD STUFF:
    // ... none ... ;-)

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