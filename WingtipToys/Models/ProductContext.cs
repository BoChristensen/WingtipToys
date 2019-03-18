//Access all the core functionality of Entity Framework(query,insert,update amd delete data
using System.Data.Entity;
namespace WingtipToys.Models
{
    public class ProductContext : DbContext
    {
        //This class fetch, Storing and updating Product class instance in the database.
        //ProductContext class derives form the DBcontext case class from Entity Framework
        public ProductContext() : base("WingtipToys")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}