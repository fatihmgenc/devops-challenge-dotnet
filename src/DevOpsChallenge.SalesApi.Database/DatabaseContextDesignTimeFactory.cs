using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace DevOpsChallenge.SalesApi.Database
{
    /// <summary>
    /// Design time factory for the database context.
    /// </summary>
    public class DatabaseContextDesignTimeFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        /// <inheritdoc />
        public DatabaseContext CreateDbContext(string[] args)
        {
            //string connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__Database") ?? @"Server=(localdb)\mssqllocaldb;Database=DevOpsChallenge.SalesApi;Trusted_Connection=True;ConnectRetryCount=0";
            string connectionString = "Server=localhost;Database=latusDB;User=SA;Password=Str0ngPa$$w0rd;ConnectRetryCount=0";
            
            DbContextOptionsBuilder<DatabaseContext> optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlServer(connectionString);

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
