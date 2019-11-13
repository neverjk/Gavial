namespace GavialServer.Entity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GavialDB : DbContext
    {
        public GavialDB()
            : base("name=GavialDB")
        {

        }
        public DbSet<User> Users { get; set; }
        
    }
}