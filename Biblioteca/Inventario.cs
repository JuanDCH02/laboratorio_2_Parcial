using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Inventario
    {
        public static Dictionary<string, int> Materiales { get; set; }

        static Inventario()
        {
            Materiales = new Dictionary<string, int>();
            Materiales["madera"] = 80;
            Materiales["tela"] = 50;
            Materiales["aspa"] = 30;
            Materiales["tornillo"] = 200;
            Materiales["base"] = 25;
            Materiales["bombilla"] = 27;
        }
        /// <summary>
        /// paso por cada key del inventario y agrego 15 unidades a cada una
        /// </summary>
        public static void AgregarInventario()
        {
            foreach(var key in Materiales.Keys)
            {
                Materiales[key] += 15;
            }
        }
        /// <summary>
        /// Hago una resta al valor de una key en especifico del diccionario inventario
        /// </summary>
        /// <param name="key"></param> key a disminuir
        /// <param name="cant"></param> cantidad a disminuir
        public static void RestarInventario(string key, int cant)
        {
            if (Materiales.ContainsKey(key))
            {
                Materiales[key] -= cant;
            }
        }
        /// <summary>
        /// Verifico si alguna key del diccionario inventario contiene menos de 20 unidades
        /// </summary>
        /// <returns></returns> false si el valor de alguna key es menor a 20
        public static bool checkearInventario()
        {
            bool rtn = false;
            foreach (var valor in Materiales.Keys)
            {
                if (Materiales[valor] < 20)
                {
                    rtn = true;
                }
            }
            return rtn;
        }
        /// <summary>
        /// Muestro todas las keys y sus respectivos valores del diccionario inventario
        /// </summary>
        /// <returns></returns> string linea por linea con los valores
        public static string MostrarInventario()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inventario:");
            foreach (var kvp in Materiales)
            {
                sb.AppendLine($"{kvp.Key}: {kvp.Value}");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Verifico el valor que contiene una key en especifico
        /// </summary>
        /// <param name="key"></param> key a evaluar
        /// <returns></returns> el valor entero de la key
        public static int CantidadInventario(string key)
        {
            int valor = 0;        
            if (Materiales.ContainsKey(key))
            {
                valor = Materiales[key];
            }
            return valor;
        }
    }
}
