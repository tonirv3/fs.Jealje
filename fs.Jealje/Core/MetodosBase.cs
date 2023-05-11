using fs.Jealje.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fs.Jealje.Core
{
    public abstract class MetodosBase<T> : Repositorio where T:BaseNegocio
    {
        public MetodosBase(string nombreTabla, string cadenaConnexion) : base(nombreTabla, cadenaConnexion)
        {
            
        }
    }
}
