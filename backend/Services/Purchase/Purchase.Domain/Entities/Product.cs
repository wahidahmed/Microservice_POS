
using System.ComponentModel.DataAnnotations.Schema;

namespace Purchase.Domain.Entities
{
    public class Product
    {
        public long ProductId { get; set; }
        public string ProdcutName { get; set; }
        public string ProductDescription { get; set; }

        [ForeignKey("Unit")]
        public int UnitId {  get; set; }
        public decimal SalesUnitPrice { get; set; }
        public Unit Unit { get; set; }=new Unit();
        
    }
}
