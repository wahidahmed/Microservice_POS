
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Purchase.Domain.Entities
{
    public class Product
    {
        public long ProductId { get; set; }
        [MaxLength(200)]
        public string ProdcutName { get; set; }
        [MaxLength(1000)]
        public string ProductDescription { get; set; }

        [ForeignKey("Unit")]
        public int UnitId {  get; set; }
        [Precision(18, 2)]
        public decimal SalesUnitPrice { get; set; }
        public Unit Unit { get; set; }=new Unit();
        
    }
}
