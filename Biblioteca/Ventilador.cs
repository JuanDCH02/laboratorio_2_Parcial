using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ventilador : Product
    {
       
        public Ventilador(string nombre) : base(nombre)
        {
            
        }
        public static bool CrearVentilador(int cantidad)
        {
            if (Inventario.CantidadInventario("tornillo") > 15 * cantidad && Inventario.CantidadInventario("aspa") > 4 * cantidad && Inventario.CantidadInventario("bombilla") > 4 * cantidad && Inventario.CantidadInventario("base") > 1 *cantidad)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Mueble m = new("Ventilador");
                    Stock.ProductStock.Add(m);
                }
                Inventario.RestarInventario("tornillo", 15 * cantidad);
                Inventario.RestarInventario("aspa", 4 * cantidad);
                Inventario.RestarInventario("bombilla", 4 * cantidad);
                Inventario.RestarInventario("base", 1 * cantidad);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
