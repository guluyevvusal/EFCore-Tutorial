using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;


public class EcommerceDbContext:DbContext
{
        DbSet<Product> Products { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        // Provider
        // Connection string
        // Lazy loading
        // etc... used here




        optionsBuilder.UseSqlServer("Server=LAPTOP-8PPT5PTN\\SQLEXPRESS; Database=EcommerceDb");
    }


}



    public class Product
    {
      public int Id { get; set; }

    }


#region OnConfiguring  ile Konfigürasyon ayarlarını etmek

// We use it to configure the EF Core tool
// It is used by overriding the context data

#endregion

#region Sade düzeyde Entity Tanımlama
//In Ef core, each table must have a primary key column by default.

#endregion





