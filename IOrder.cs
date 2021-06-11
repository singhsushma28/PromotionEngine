namespace PromotionEngine

public interface IOrder
{
  Dictionary<string,int> GetOrderItems(List<Product> products);
  int GetTotalOrderAmount(Dictionary<string,int> products);
}
