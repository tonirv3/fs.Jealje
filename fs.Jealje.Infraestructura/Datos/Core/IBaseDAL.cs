using fs.Jealje.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fs.Jealje.Infraestructura.Datos.Core
{
    public interface IBaseDAL<T> where T : BaseNegocio
    {
        IEnumerable<T> DameTodos();
        T Dame(long id);
        IEnumerable<T> DameVista(string vista);
        long Crea(T item);
    }
}
