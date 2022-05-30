namespace Model
{
    public class Customer
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public decimal AccountBalance { get; set; }
        public bool HasCriminalRecord { get; set; }
    }
}