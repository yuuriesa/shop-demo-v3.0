using System.Text.Json.Serialization;
using ShopDemoV3.Utils;

namespace ShopDemoV3.Models
{
    public class Order
    {
        //private properties
        private string _orderNumber { get; set; }
        private DateTime _orderDate { get; set; }
        private decimal _totalOrderValue { get; set; }

        //public properties
        public int OrderId { get; private set; }
        public string OrderNumber => _orderNumber;
        public DateTime OrderDate => _orderDate;
        public decimal TotalOrderValue => _totalOrderValue;
        public int CustomerId { get; private set; }
        [JsonIgnore]
        public Customer Customer { get; set; }
        //public ICollection<Item> Items { get; private set; } = new List<Item>();
    
        //properties for validation
        public bool IsValid { get; private set; } = false;
        public string ErrorMessageIfIsNotValid { get; private set; } = string.Empty;
    
        //private Constuctors
        private Order()
        {
            
        }

        private Order
        (
            int orderId,
            string orderNumber,
            DateTime orderDate,
            decimal totalOrderValue,
            int customerId
            //List<Item> items
        )
        {
            OrderId = orderId;
            _orderNumber = orderNumber;
            _orderDate = orderDate;
            _totalOrderValue = totalOrderValue;
            //_customerId = customerId;
            CustomerId = customerId;
            //Items = items;

            //Validate();
        }

        //public methods
        public static Order RegisterNew
        (
            string orderNumber,
            DateTime orderDate,
            int customerId
            //List<Item> items
        )
        {
            Order order = new Order();

            // order.SetOrderNumber(orderNumber: orderNumber);
            // order.SetOrderDate(orderDate: orderDate);
            // order.SetOrderCustomerId(customerId: customerId);
            // order.SetOrderItems(items: items);
            // order.SetTotalOrderValue(items: items);
            // order.Validate();

            return order;
        }

        public static Order SetExistingInfo
        (
            int orderId,
            string orderNumber,
            DateTime orderDate,
            decimal totalOrderValue,
            int customerId
            //List<Item> items
        )
        {
            Order order = new Order
            (
                orderId: orderId,
                orderNumber: orderNumber,
                orderDate: orderDate,
                totalOrderValue: totalOrderValue,
                customerId: customerId
                //items: items
            );

            return order;
        }

        //private methods
        private void SetOrderId(int orderId)
        {
            if (orderId <= 0)
            {
                //ErrorMessageIfIsNotValid = DomainResponseMessages.OrderIdMustBeGreaterThanZeroError;
            }
            OrderId = orderId;
        }
    }
}