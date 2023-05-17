using fs.Jealje.Dominio.Entidades;
using fs.Jealje.Infraestructura.Datos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fs.Jealje.Infraestructura.Datos
{
    public class VehiculoDAL : BaseDAL<Vehiculo>, IVehiculoDAL
    {
        public VehiculoDAL(string nombreTabla, string CadenaConexion) : base("Vehiculos", CadenaConexion)
        {
        }
    }
}
