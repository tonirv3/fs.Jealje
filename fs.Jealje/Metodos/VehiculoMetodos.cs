using fs.Jealje.Core;
using fs.Jealje.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fs.Jealje.Metodos
{
    public class VehiculoMetodos : MetodosBase<Vehiculo>
    {
        public VehiculoMetodos(string nombreTabla, string cadenaConnexion) : base("Vehiculos", cadenaConnexion)
        {
        }

        public IEnumerable<Vehiculo> DameTodos()
        {
            var sql = $"SELECT * FROM {}"
        }
    }
}
