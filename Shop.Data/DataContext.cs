using Microsoft.EntityFrameworkCore;
using Shop.Models;
using System;

namespace Shop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base (options)
        {}

        //representacao das tabelas em memoria. Mapeamento atraves dos modelos
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
