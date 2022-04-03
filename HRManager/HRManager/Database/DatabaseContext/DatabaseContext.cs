using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using HRMenager.DTO;

namespace SecureDevelopment_1
{
    public class DatabaseContext: DbContext
    {
       internal  string ConnectionString = "Host=localhost:5432; Database=postgres; Username=postgres; Password=postgres";

       public  DatabaseContext() {  }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseNpgsql(ConnectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>();



        }


    }
}
