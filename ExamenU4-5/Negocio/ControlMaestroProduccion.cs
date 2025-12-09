using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU4_5.Negocio
{
    public class ControlMaestroProduccion
    {
        private static ControlMaestroProduccion _instancia;
        private HashSet<string> materialesReciclables;

        private ControlMaestroProduccion()
        {
            materialesReciclables = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Plastico","Papel", "Vidrio", "Metal", "Carton", "Pilas", "Latas"
            };
        }


        public static ControlMaestroProduccion Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ControlMaestroProduccion();
                return _instancia;
            }
        }

        public bool EsReciclable(string nombre)
        {
            return materialesReciclables.Contains(nombre);
        }
    }
}
