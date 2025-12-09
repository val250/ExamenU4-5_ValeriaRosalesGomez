using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU4_5.Negocio
{
    public class EstadoReciclable : IEstadoMaterial
    {
        public string ObtenerEstado() => "Reciclable";
        public bool EsReciclable() => true;
    }
}
