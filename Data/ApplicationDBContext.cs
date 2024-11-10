using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    //interhit DbContext for EF Core feature
    public class ApplicationDBContext : DbContext
    {
        //constructor
        public ApplicationDBContext(DbContextOptions options):base(options) 
        {
            
        }

        //it will create table in db using UserModel
        public DbSet<UserModel> Users { get; set; }
    }
}
