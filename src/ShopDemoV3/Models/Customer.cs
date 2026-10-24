namespace ShopDemoV3.Models
{
    public class Customer
    {
        //private properties
        private string _firstName;
        private string _lastName;
        private string _emailAddress;
        private DateOnly _dateOfBirth;
        private ICollection<Address> addresses = new List<Address>();
        private bool _isValid { get; set; } = false;

        //public properties
        public int CustomerId { get; private set; }
        public string FirstName => _firstName;
        public string LastName => _lastName;
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

            //Validate
            // (

            // );
        }

        //public methods
        public static Customer RegisterNew
        (
            string firstName,
            string lastName,
            string emailAddress,
            DateTime dateOfBirth
        )
        {
            
        }

        public static Customer SetExistingInfo
        (
            int customerId,
            string firstName,
            string lastName,
            string emailAddress,
            DateOnly dateOfBirth
        )
        {
            Customer customer = new Customer
            (
                customerId: customerId,
                firstName: firstName,
                lastName: lastName,
                emailAddress: emailAddress,
                dateOfBirth: dateOfBirth
            );

            return customer;
        }

        public bool IsValid()
        {
            return _isValid;
        }

        //private methods
        private void SetCustomerId(int customerId)
        {
            if (customerId < 1)
            {
                _isValid = false;
                ErrorMessageIfIsNotValid = "";
            }
            CustomerId = customerId;
        }

        private void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        private void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        private void SetEmailAddress(string emailAddress)
        {
            _emailAddress = emailAddress;
        }
        private void SetDateOfBirth(DateTime dateOfBirth)
        {
            _dateOfBirth = DateOnly.FromDateTime(dateTime: dateOfBirth);
        }

        private void Validate(string firstName, string lastName, DateTime dateOfBirth)
        {
            if (firstName.Length > 40 || lastName.Length > 40)
            {
                _isValid = false;
                ErrorMessageIfIsNotValid = "";
            }

            DateTime dateNow = DateTime.Now;

            if (dateOfBirth.ToUniversalTime().Date > dateNow.Date)
            {
                _isValid = false;
                ErrorMessageIfIsNotValid = "";
            }
            
            if (ErrorMessageIfIsNotValid == string.Empty)
            {
                _isValid = true;
            }
        }
    }
}