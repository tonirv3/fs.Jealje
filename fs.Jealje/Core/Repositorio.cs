using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fs.Jealje.Core
{
    public abstract class Repositorio
    {
        protected readonly string _nombreTabla;
        protected readonly string _cadenaConexion;

        public Repositorio(string nombreTabla, string CadenaConexion)
        {
            _nombreTabla = nombreTabla;
            _cadenaConexion = CadenaConexion;
        }

        internal SqlConnection Conexion 
        {
            get
            {
                return new SqlConnection(_cadenaConexion);
            }
        }
    }
}
