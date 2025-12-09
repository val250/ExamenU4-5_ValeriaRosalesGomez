using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenU4_5.Negocio;

namespace ExamenU4_5.Modelo
{
    public class Material
    {
        public string Nombre { get; set; }
        public bool EsReciclable { get; set; }
        public IEstadoMaterial Estado { get; set; }

        public void Iniciar()
        {
            Nombre = string.Empty;
            EsReciclable = false;
            Estado = null;
        }
    }
}
