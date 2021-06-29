using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TecGroupSisVentasFrondEnd2021.Modelos
{
    public class ProductContext : DbContext
    {
        public ProductContext()
          : base("dbVentas")
        {
        }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }

        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderDetail> OrderDetails{   get; set; }
    }
}