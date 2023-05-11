using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fs.Jealje.Negocio
{
    public class AuditoriaBase : BaseNegocio
    {
        public bool Estado { get; set; }
        public string UsuarioAlta { get; set; }

        //Si se quiere, se puede utilizar el tipo de dato 'DateTime'
        public TimeOnly HoraAlta { get; set; }
        public DateOnly FechaAlta { get; set; }
        public string UsuarioModificacion { get; set; }
        public TimeOnly FechaModificacion { get; set; }        

    }
}
