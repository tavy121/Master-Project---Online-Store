﻿using BookStore.Models.DTOs.VM;
using System.Collections.Generic;

namespace BookStore.Models.Interfaces
{
    public interface IProductTypeService
    {
        IEnumerable<ProductTypeVM> GetAllProductType();
        ProductTypeVM GetProductType(int id);
        void AddProductType(ProductTypeVM dto);
        void UpdateProductType(int id, ProductTypeVM dto);
        void DeleteProductType(int id);
    }
}
