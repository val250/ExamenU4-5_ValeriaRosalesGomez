using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenU4_5.Modelo;

namespace ExamenU4_5.Negocio
{
    public class AdaptadorIngles: ITraductor
    {
        private Material _material;

        public AdaptadorIngles(Material material)
        {
            _material = material;
        }

        public string ObtenerTraduccion()
        {
            string texto = _material.Nombre;

            texto = texto.Replace("Plastico", "Plastic")
                         .Replace("Papel", "Paper")
                         .Replace("Vidrio", "Glass")
                         .Replace("Carton", "Cardboard")
                         .Replace("Pilas", "Batteries")
                         .Replace("Latas", "Cans")
                         .Replace("Tela", "Fabric");

            return texto;
        }
    }
}
