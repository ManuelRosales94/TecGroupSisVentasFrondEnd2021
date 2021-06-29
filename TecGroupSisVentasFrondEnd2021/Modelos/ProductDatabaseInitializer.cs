using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TecGroupSisVentasFrondEnd2021.Modelos
{

    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));

        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Computo"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Celulares"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Gammer"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Pc"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Complementos"
                },
            };
            return categories;
        }

    }
}
