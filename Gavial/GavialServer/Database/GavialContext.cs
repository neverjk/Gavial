namespace GavialServer.Entity
{
    using GavialServer.Database.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GavialContext : DbContext
    {
        public GavialContext()
            : base("name=GavialDB")
        {

        }
        public DbSet<GavialUser> Users { get; set; }
        
    }
}