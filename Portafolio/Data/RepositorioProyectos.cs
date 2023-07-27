using Portafolio.Models;

namespace Portafolio.Data
{
    public class RepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto> { new Proyecto
            {
                Titulo = "Administrador de escuelas",
                Descripcion = "Control de la información de varias escuelas realizado en ASP.Net Core",
                ImagenURL = "/images/webescuela.jpg",
                Link = ""
            },
            new Proyecto
            {
                Titulo = "Administrador de escuelas",
                Descripcion = "Control de la información de varias escuelas realizado en ASP.Net Core",
                ImagenURL = "/images/webescuela.jpg",
                Link = ""
            },
            new Proyecto
            {
                Titulo = "Administrador de escuelas",
                Descripcion = "Control de la información de varias escuelas realizado en ASP.Net Core",
                ImagenURL = "/images/webescuela.jpg",
                Link = ""
            }
            };
        }
    }
}
