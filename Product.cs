namespace PromotionEngine
{
  public class Product: IProduct
  {
        string UnitId {get;set;}
        int UnitPrice {get;set;}
        public  List<Product> GetPriceForUnit()
        {
        }
  }

}
