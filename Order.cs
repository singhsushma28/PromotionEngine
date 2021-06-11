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
      IProduct objProduct= new Product();
      var unitPrices= objProduct.GetPriceForUnit();
      
      int productAcount= products[Constants.ProductType.ProductA];
      int productBcount= products[Constants.ProductType.ProductB];
      int productCcount= products[Constants.ProductType.ProductC];
      int productDcount= products[Constants.ProductType.ProductD];
      
      int priceOfA= unitPrices.Find(x=> x.unitId== Constants.ProductType.ProductA).UnitPrices;
      int priceOfB= unitPrices.Find(x=> x.unitId== Constants.ProductType.ProductB).UnitPrices;
      int priceOfC= unitPrices.Find(x=> x.unitId== Constants.ProductType.Productc).UnitPrices;
      int priceOfD= unitPrices.Find(x=> x.unitId== Constants.ProductType.ProductD).UnitPrices;
      
      
      
      int totalPriceOfA= ((productAcount/3)*130)+(productAcount%3*priceOfA);
      int totalPriceOfB= ((productBcount/2)*45)+(productBcount%2*priceOfB);
      int totalPriceOfC= productCcount*priceOfC;
      int totalPriceOfD= productCcount*priceOfD;
      
      var totalCartPrice= totalPriceOfA+ totalPriceOfB+totalPriceOfC+totalPriceOfD;
      return totalCartPrice;
      
    }
  }
}
