using System.Data.Entity;

namespace APIpractico.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIpractico.Models.Producto> Productoes { get; set; }
    }
}