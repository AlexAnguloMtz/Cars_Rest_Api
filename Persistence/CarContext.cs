using Cars.Domain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.Persistence
{

    [Table("car")]
    public class CarContext(DbContextOptions<CarContext> options) : DbContext(options)
    {
        public DbSet<Car> Car { get; set; }

    }
}
