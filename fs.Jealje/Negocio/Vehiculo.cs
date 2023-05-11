using System.ComponentModel.DataAnnotations.Schema;

namespace fs.Jealje.Negocio
{
    [Table("Vehiculos")]
    public class Vehiculo : AuditoriaBase
    {        
        public long OIDAgencia { get; set; }
        public string Marca { get; set; }
        public string TipoVehiculo { get; set;}
        public string Matricula { get; set; }
        public string Remolque { get; set; }
        public string CodTransportista { get; set; }
    }
}