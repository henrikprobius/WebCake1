namespace WebCake1.Models
{
    public class Order
    {
        public int CakeId { get; set; } = -1;

        public decimal Price { get; set; } = 0.0M;

        public string Title { get; set; } = string.Empty;

        public string CakeType { get; set; } = string.Empty;

        public CakeSize Size { get; set; } = CakeSize.Medium;

        public int Quantity { get; set; } = 0;

        public decimal GetOrderValue()
        { return Price * Quantity; }
    }
}
