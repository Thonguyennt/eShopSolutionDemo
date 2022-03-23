using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catagory.Products
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItem> Categories { get; set; } = new List<SelectItem>();
    }
}
