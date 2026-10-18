namespace ShopDemoV3.Models
{
    public class Customer
    {
        //private properties
        private string _firstname;
        private string _lastname;
        private string _emailAddress;
        private DateOnly _dateOfBirth;
        private bool _isValid { get; set; } = false;
    }
}