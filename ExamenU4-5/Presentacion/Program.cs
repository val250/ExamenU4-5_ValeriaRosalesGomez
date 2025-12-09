using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenU4_5.Modelo;
using ExamenU4_5.Negocio;

namespace ExamenU4_5.Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulación de procesos industriales automatizados - Materiales Reciclables");

            var pool = new PoolMateriales();
            var control = ControlMaestroProduccion.Instancia;

            var listaMateriales = new List<string>
            {
                "Plastico", "Papel", "Tela", "Metal", "Carton"
            };

            var materialesProcesados = new List<Material>();

            foreach (var nombre in listaMateriales)
            {
                var material = pool.Obtener();
                material.Nombre = nombre;
                material.EsReciclable = control.EsReciclable(nombre);

                if (material.EsReciclable)
                    material.Estado = new EstadoReciclable();
                else
                    material.Estado = new EstadoNoReciclable();

                materialesProcesados.Add(material);
            }

            Console.WriteLine("Materiales presentados");
            foreach (var m in materialesProcesados)
            {
                Console.WriteLine($"- {m.Nombre}");
            }
            Console.WriteLine("");
            Console.WriteLine("Estado de los Materiales");
            foreach (var m in materialesProcesados)
            {
                Console.WriteLine($"- {m.Nombre}: {m.Estado.ObtenerEstado()}");
            }
            Console.WriteLine("");
            Console.WriteLine("State of Materials");
            foreach (var m in materialesProcesados)
            {
                ITraductor traductor = new AdaptadorIngles(m);
                string nombreEnIngles = traductor.ObtenerTraduccion();

                string estadoEnIngles = m.Estado.EsReciclable() ? "Recyclable" : "Non-recyclable";

                Console.WriteLine($"- {nombreEnIngles}: {estadoEnIngles}");
            }
            Console.WriteLine("");
            Console.WriteLine("Proceso finalizado");
            Console.ReadKey();
        }
    }
}
