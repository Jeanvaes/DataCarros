using DataCarros.Datos.Modelo;
using Microsoft.EntityFrameworkCore;


namespace DataCarros.Datos.Servicio
{

    public class RepositorioCarros : DbContext
    {
        public RepositorioCarros (DbContextOptions<RepositorioCarros> options)
            : base(options)
        {
        }

        public DbSet<DataCarros.Datos.Modelo.Garaje> Garaje { get; set; }
       
    }


}
