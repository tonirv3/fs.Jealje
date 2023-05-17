using fs.Jealje.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fs.Jealje.Dominio.Entidades
{
    [Table("Vehiculos")]
    public class Vehiculo : AuditoriaBase
    {
        [Required]
        public long OIDAgencia { get; set; }
        public string Marca { get; set; }
        public string TipoVehiculo { get; set;}
        [StringLength(10)]
        public string Matricula { get; set; }
        public string Remolque { get; set; }
        public string CodTransportista { get; set; }
    }
}