using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU4_5.Negocio
{
    public class EstadoNoReciclable : IEstadoMaterial
    {
        public string ObtenerEstado() => "No reciclable";
        public bool EsReciclable() => false;
    }
}
