using System.Data.Entity;

namespace MVCpractico.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCpractico.Models.Producto> Productoes { get; set; }
    }
}