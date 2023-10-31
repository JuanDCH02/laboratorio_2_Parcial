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
        public static void AgregarInventario()
        {
            foreach(var key in Materiales.Keys)
            {
                Materiales[key] += 15;
            }
        }
        public static void RestarInventario(string key, int cant)
        {
            if (Materiales.ContainsKey(key))
            {
                Materiales[key] -= cant;
            }
        }
        public static bool checkearInventario()
        {
            bool rtn = false;
            foreach(var key in Materiales.Keys)
            {
                if (Materiales[key] < 20)
                {
                    rtn = true;
                }
            }
            return rtn;
        }

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
