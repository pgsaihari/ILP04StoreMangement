using ILP04_StoreMangement.Model;
using System.ComponentModel.DataAnnotations.Schema;

public class Order
{
    public int Id { get; set; }
    public string Address { get; set; }
    public double OrderTotal { get; set; }
    public DateTime OrderPlaced { get; set; } = DateTime.Now;
    
    public int UserId {  get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }

        

}

