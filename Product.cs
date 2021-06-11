namespace PromotionEngine
{
  public class Product: IProduct
  {
        string UnitId {get;set;}
        int UnitPrice {get;set;}
        public  List<Product> GetPriceForUnit()
        {
          var list = new List<Product>();
          list.Add(new Product{UnitId="A",UnitPrice=50});
          list.Add(new Product{UnitId="B",UnitPrice=30});
          list.Add(new Product{UnitId="C",UnitPrice=20});
          list.Add(new Product{UnitId="D",UnitPrice=15});
          
          return list;
        }
  }

}
