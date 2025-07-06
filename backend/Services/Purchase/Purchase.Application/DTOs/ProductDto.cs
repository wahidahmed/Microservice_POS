namespace Purchase.Application.DTOs
{
    public class ProductDto
    {
        public long ProductId { get; set; }
        public string ProdcutName { get; set; }
        public string ProductDescription { get; set; }
        public int UnitId { get; set; }
        public decimal SalesUnitPrice { get; set; }
    }
}
