using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;
using ToDoAPI.Models;
namespace ToDoAPI.Data 
{
/*  A DbContext instance represents a combination of the Unit Of Work 
    and Repository patterns such that it can be used to query from 
    a database and group together changes that will then be written 
    back to the store as a unit.DbContext is conceptually similar 
    to ObjectContext.*/
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }

        public DbSet<ToDo> ToDos => Set<ToDo>();
    }
}
