namespace PromotionEngine

public interface IOrder
{
  Dictionary<string,int> GetOrderItems(Product product);
  int GetTotalOrderAmount(Dictionary<string,int> products);
}
