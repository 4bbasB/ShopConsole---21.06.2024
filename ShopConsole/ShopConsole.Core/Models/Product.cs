namespace ShopConsole.Core.Models;

public class Product : Base
{
    public int Count { get; set; }
    public int PurchasePrice { get; set; }
    public int SalePrice { get; set; }

}
