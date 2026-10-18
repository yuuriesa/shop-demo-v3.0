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

        //public properties
        public int CustomerId { get; private set; }
        public string FirstName => _firstname;
        public string LastName => _lastname;
        public string EmailAddress => _emailAddress;
        public DateOnly DateOfBirth => _dateOfBirth;
        public string ErrorMessageIfIsNotValid { get; private set; } = string.Empty;
    
        //constructors    
        public Customer()
        {
            
        }

        private Customer
        (
            int customerId,
            string firstName,
            string lastName,
            string emailAddress,
            DateOnly dateOfBirth
        )
        {
            CustomerId = customerId;
            _firstname = firstName;
            _lastname = lastName;
            _emailAddress = emailAddress;
            _dateOfBirth = dateOfBirth;
        }
    }
}