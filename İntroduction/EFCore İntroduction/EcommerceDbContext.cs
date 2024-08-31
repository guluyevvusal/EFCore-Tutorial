using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;




#region Veri nece silinir ?
//EcommerceDbContext context = new();

//Product product = await context.Products.FirstOrDefaultAsync(p=>p.Id == 4);

//context.Products.Remove(product);

//await context.SaveChangesAsync();
#endregion










#region Veri necə güncəllənir  ?
//EcommerceDbContext context = new();

//Product product = await context.Products.FirstOrDefaultAsync(p => p.Id == 3);

//product.Id = 5;
//product.ProductName = "V product";

//await context.SaveChangesAsync();

#endregion

#region Change Tracker Apı nədir ? 
//ChangeTracker is a mechanism responsible for tracking data coming from the context. Thanks to this tracking mechanism, it is understood that update or delete queries will be created as a result of operations related to data coming from the context!
#endregion

#region Change tracker Apı ilə izlənilməyən verilər necə güncəllənir ?
//EcommerceDbContext context = new();

//Product product = new()
//{
//    Id = 3,
//    ProductName = "Test Product",
//    Price = 180
//};

//context.Products.Update(product);

//await context.SaveChangesAsync();

//The Update function is used to update objects that are not tracked by the ChangeTracker mechanism!
#endregion

#region Entry State nedir ?
//It is a reference that expresses the state of an entity instance.

#endregion

















#region Veri nece elave edilir?

//EcommerceDbContext context = new();

//Product product = new()
//{
//    ProductName = "A product",
//    Price = 500
//};

#region context.AddAsync Funksiyası
//await context.AddAsync(product);
#endregion

#region context.DbSet.AddAsync Funksiyası
//await context.Products.AddAsync(product);
#endregion

//await context.SaveChangesAsync(); 

#endregion


#region SaveChanges nedir?
// Savechanges is a function that creates insert, update and delete operations within a transaction, sends them to the database and executes them.
#endregion


#region EF Core baxış bucağından bir verinin elave edilmesini nece bilirik?
//EcommerceDbContext context = new();
//Product product = new()
//{
//    ProductName = "B product",
//    Price = 2000

//};

//Console.WriteLine(context.Entry(product).State);

//    await context.AddAsync(product);

//Console.WriteLine(context.Entry(product).State);

//    await context.SaveChangesAsync();

//Console.WriteLine(context.Entry(product).State);
#endregion


#region Birden çox veri elave ederken nelere diqqet etmeliyik ?
//Since the SaveChanges function will create a transaction each time it is triggered, we should avoid using it for each transaction made with EF Core! Because a transaction specific to each transaction means extra cost in terms of database. Therefore, using savechanges once to be able to send all our transactions to the database with a single transaction as much as possible will contribute to both cost and manageability.

#region SaveChanges verimli istifade
//EcommerceDbContext context = new();

//Product product1 = new()
//{
//    ProductName = "C product",
//    Price = 400,
//};

//Product product2 = new()
//{
//    ProductName = "D product",
//    Price = 800,
//};

//Product product3 = new()
//{
//    ProductName = "E product",
//    Price = 100,
//};

//Product product4 = new()
//{
//    ProductName = "G product",
//    Price = 600,
//};

//Product product5 = new()
//{
//    ProductName = "H product",
//    Price = 700,
//};

//await context.AddAsync(product1);

//await context.AddAsync(product2);

//await context.AddAsync(product3);

//await context.AddAsync(product4);

//await context.AddAsync(product5);

//await context.SaveChangesAsync();
#endregion

#endregion


#region Elave edilen verinin Generate edilen Id-ni  elde etme
//EcommerceDbContext context = new();

//Product product6 = new()
//{
//    ProductName = "O product",
//    Price = 1500,
//};

//await context.AddAsync(product6);

//await context.SaveChangesAsync();

//Console.WriteLine(product6.Id);
#endregion












public class EcommerceDbContext:DbContext
{
    public  DbSet<Product> Products { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        // Provider
        // Connection string
        // Lazy loading
        // etc... used here




        optionsBuilder.UseSqlServer("Server=LAPTOP-8PPT5PTN\\SQLEXPRESS; Database=EcommerceDb; Trusted_Connection = True; TrustServerCertificate=true;");
    }


}



public class Product
{
      public int Id { get; set; }
      public string ProductName { get; set; }
      public float Price { get; set; }
      
}


#region OnConfiguring  ile Konfigürasyon ayarlarını etmek

// We use it to configure the EF Core tool
// It is used by overriding the context data

#endregion

#region Sade düzeyde Entity Tanımlama
//In Ef core, each table must have a primary key column by default.

#endregion





