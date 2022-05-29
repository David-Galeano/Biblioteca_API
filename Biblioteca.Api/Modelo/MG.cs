using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class MG
    {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Nombre { get; set; }
        public string Creador { get; set; }
        public int PorcentajeDeFuncionamiento { get; set; }
        public string Descripcion { get; set; }
    }
}
