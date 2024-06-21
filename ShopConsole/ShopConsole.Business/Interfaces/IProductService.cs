using ShopConsole.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsole.Business.Interfaces
{
    public interface IProductService
    {
        void AddProduct(int count, int purchasePrice, int salePrice, ProductType productType);
        void RemoveProduct(string product, int id);
        void EditProduct(string product, int id);
    }
}
