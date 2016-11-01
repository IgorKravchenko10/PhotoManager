namespace PhotoManager
{
    using DataObjects;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PmContext : DbContext
    {
        // Your context has been configured to use a 'DbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PhotoManager.DbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbContext' 
        // connection string in the application configuration file.
        public PmContext()
            : base("name=PmContext")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<WorkType> WorkTypes { get; set; }

    }

    
}