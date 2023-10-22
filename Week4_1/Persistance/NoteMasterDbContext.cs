using System;
using Microsoft.EntityFrameworkCore;
using Week4_1.Entities;
namespace Week4_1.Persistance
{
	public class NoteMasterDbContext :DbContext 
	{
		public DbSet<Note> Notes { get; set; }
        //Naming should be plural. We are naming our entities in singular, each entity will hold a single instance.
        //However, in our table here, there can be more than one item, so we make it plural
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("NoteMaster");
        }
    }
}

