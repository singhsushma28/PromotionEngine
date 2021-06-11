using System.Collections.Generic;
namespace PromotionEngine
{
 public interface IProduct
    {
        string UnitId {get;set;}
        int UnitPrice {get;set;}
        List<Product> GetPriceForUnit();
        
    }
}
