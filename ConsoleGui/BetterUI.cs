using BusinessLayer;

namespace ConsoleGui;
public class BetterUI
{
    //BETTER DEVELOPER = IMPROVED decoupling :)

    //GOOD STUFF:
    //It is possible to
    // - refer to controller using a contract (interface)
    //   making it possible to instantiate another controller, if needed,
    //   by changing the "NEW [controller]()" to another ICustomerController implementation

    //BAD STUFF:
    // UI layer has responsibility for creation of a specific controller.
    //  - if customer controller constructor changes, this UI class must change too.
    // UI is still coupled to specific controller class (new CustomerController())
    // even though it is referenced using an interface.
  

    ICustomerController customerController = new BetterCustomerController();

    public void ShowCustomers()
    {

        Console.WriteLine("All customers");
        customerController.GetAllCustomers().ToList().ForEach(Console.WriteLine);

        Console.WriteLine("Potential customers");
        customerController.GetPotentialCustomers().ToList().ForEach(Console.WriteLine);
    }
}