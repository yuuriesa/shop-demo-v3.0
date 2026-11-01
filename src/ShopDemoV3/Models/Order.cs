using System.Text.Json.Serialization;

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
    }
}