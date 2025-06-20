namespace Purchase.Domain.Entities
{
    public class Unit
    {
        public int UnitId {  get; set; }
        public string UnitName { get; set; }
        public ICollection<Product> Products { get; set; }=new List<Product>();
    }
}
