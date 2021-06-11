namespace PromotionEngine
{
  public class Order : IOrder
  {
    public Dictionary<string,int> GetOrderItems(List<Product> products)
    {
      int Acount=0, Bcount=0,Ccount=0,Dcount=0;
      var listProduct= new Dictionary<string,int>();
      foreach(var product in products)
      {
        switch(product.unitId)
        {
          case Constants.ProductType.ProductA:
            Acount+=1; break;
          case Constants.ProductType.ProductB:
            Bcount+=1; break;
          case Constants.ProductType.ProductC:
            Ccount+=1; break;
          case Constants.ProductType.ProductD:
            Dcount+=1; break;
          default:
          Console.WriteLine("Invalid product"); break;   
        }
        
        listProduct.Add(Constants.ProductType.ProductA,Acount);
        listProduct.Add(Constants.ProductType.ProductB,Bcount);
        listProduct.Add(Constants.ProductType.ProductC,Ccount);
        listProduct.Add(Constants.ProductType.ProductD,Dcount);
        
        return listProduct;
      }
    }
    
    public int GetTotalOrderAmount(Dictionary<string,int> products)
    {
      
      
    }
  }
}
