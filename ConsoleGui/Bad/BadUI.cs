using BusinessLayer.Bad;

namespace ConsoleGui.Bad;
public class BadUI
{

    //VERY hard coupling = BAD DEVELOPER!! :(

    //GOOD STUFF:
    // ...it works...

    //BAD STUFF:
    // - Doesn't refer to controller class by contract (interface) 
    //   which would make it easier to switch to another controller implementation
    // - the UI instantiates its own controller,
    //   giving the UI responsibility it shouldn't have

    CustomerController customerController = new CustomerController();

    public void ShowCustomers()
    { 
        Console.WriteLine("All customers");
        customerController.GetAllCustomers().ToList().ForEach(Console.WriteLine);

        Console.WriteLine("Potential customers");
        customerController.GetPotentialCustomers().ToList().ForEach(Console.WriteLine);
    }
}