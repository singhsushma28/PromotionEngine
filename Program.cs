
namespace PromotionEngine

class Program
{
  public static void Main(string[] args)
        {
            var listProduct= new List<Product>();
            int numberOfProduct= Convert.ToInt32(Console.ReadLine());
            for(int i=0; i< numberOfProduct;i++)
            {
              string ProductId= Console.ReadLine();
              listProduct.Add(new Product{ UnitId= ProductId});
            }
            
            IOrder order= new Order();
            var orderCount= order.GetOrderItems(listProduct);
            
            int totalAmount= order.GetTotalOrderAmount(orderCount);
            
            Console.WriteLine("Total Amount: {0}",totalAmount);
        }
}
