namespace Model;
public class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public decimal AccountBalance { get; set; }
    public bool HasCriminalRecord { get; set; }

    public Customer(string? name, string? email, decimal accountBalance = 0, bool hasCriminalRecord = false)
    {
        Name = name;
        Email = email;
        AccountBalance = accountBalance;
        HasCriminalRecord = hasCriminalRecord;
    }
}