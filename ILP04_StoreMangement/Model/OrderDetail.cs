using System.ComponentModel.DataAnnotations.Schema;

namespace ILP04_StoreMangement.Model
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public double TotalAmount { get; set; }
     
        public int ProductId { get; set; }
       
        public int OrderId { get; set; }
      
    }
}
