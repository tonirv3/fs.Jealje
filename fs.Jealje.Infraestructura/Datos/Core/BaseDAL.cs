using fs.Jealje.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace fs.Jealje.Infraestructura.Datos.Core
{
    public abstract class BaseDAL<T> : Repositorio, IBaseDAL<T> where T : BaseNegocio
    {
        protected BaseDAL(string nombreTabla, string CadenaConexion) : base(nombreTabla, CadenaConexion)
        {
        }

        internal virtual dynamic Mapping(T item)
        {
            return item;
        }

        public long Crea(T item)
        {
            using (IDbConnection cn = Conexion)
            {
                var parameters = (object)Mapping(item);
                cn.Open();
                item.Id = cn.Insert<T>(item);
            }

            return item.Id;
        }

        public T Dame(long id)
        {
            var sql = $"SELECT * FROM {_nombreTabla} WHERE Id = @id ";

            using (IDbConnection cn = Conexion)
            {
                cn.Open();
                return cn.QueryFirstOrDefault<T>(sql);
            }
        }

        public IEnumerable<T> DameTodos()
        {
            var sql = $"SELECT * FROM {_nombreTabla}";

            using (IDbConnection cn = Conexion)
            {
                cn.Open();
                return cn.Query<T>(sql);
            }
        }

        public IEnumerable<T> DameVista(string vista)
        {
            var sql = $"SELECT * FROM {_nombreTabla} WHERE {vista}";

            using (IDbConnection cn = Conexion)
            {
                cn.Open();
                return cn.Query<T>(sql);
            }
        }
    }
}
