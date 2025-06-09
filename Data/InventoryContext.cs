using Microsoft.EntityFrameworkCore;
using InventoryManager.API.Models;
using System.Collections.Generic;


namespace InventoryManager.API.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
