namespace Purchase.Application.DTOs
{
    public class UnitDto
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }

        public List<ProductDto> Products { get; set; } = new();
    }
}
