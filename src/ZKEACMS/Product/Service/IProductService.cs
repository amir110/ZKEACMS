/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Product.Models;

namespace ZKEACMS.Product.Service
{
    public interface IProductService : IService<ProductEntity>
    {
        void Publish(int ID);
        void Publish(ProductEntity product);
        ProductEntity GetByUrl(string url);
        ProductEntity GetLatestPublished();
    }
}