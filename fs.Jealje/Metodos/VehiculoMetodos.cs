using Dapper;
using fs.Jealje.Core;
using fs.Jealje.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
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
            var sql = $"SELECT * FROM {_nombreTabla}";

            using (IDbConnection cn = Conexion)
            {
                cn.Open();
                return cn.Query<Vehiculo>(sql);
            }
        }

        public Vehiculo Dame(long idVehiculo)
        {
            var sql = $"SELECT * FROM {_nombreTabla} WHERE Id = @idVehiculo ";

            using (IDbConnection cn = Conexion)
            {
                cn.Open();
                return cn.QueryFirstOrDefault<Vehiculo>(sql);
            }
        }

        public IEnumerable<Vehiculo> DameVista(string where)
        {
            var sql = $"SELECT * FROM {_nombreTabla} WHERE {where}";

            using (IDbConnection cn = Conexion)
            {
                cn.Open();
                return cn.Query<Vehiculo>(sql);
            }
        }
    }
}
