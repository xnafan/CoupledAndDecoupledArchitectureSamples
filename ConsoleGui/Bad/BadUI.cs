using BusinessLayer.Bad;

public class BadUI
{

    //No way to
    //- change database server from here (not even using configuration)
    //- refer to controller class using contract (interface) 
    //  in order to make it easier to switch to another controller implementation

    CustomerController customerController = new CustomerController();

    public void ShowCustomers()
    { 
        Console.WriteLine("All customers");
        customerController.GetAllCustomers().ToList().ForEach(Console.WriteLine);

        Console.WriteLine("Potential customers");
        customerController.GetPotentialCustomers().ToList().ForEach(Console.WriteLine);
    }
}