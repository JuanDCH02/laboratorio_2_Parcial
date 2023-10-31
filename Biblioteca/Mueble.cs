using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Biblioteca
{
    public sealed class Mueble : Product
    {
        
        public Mueble(string name) : base(name)
        {

        }

        public static bool CrearMueble(int cantidad)
        {
            if (Inventario.CantidadInventario("tornillo") > 30*cantidad && Inventario.CantidadInventario("tela") > 2*cantidad && Inventario.CantidadInventario("madera") > 4*cantidad)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Mueble m = new("Mueble");
                    Stock.ProductStock.Add(m);
                }
                Inventario.RestarInventario("tornillo", 30 * cantidad);
                Inventario.RestarInventario("tela", 2 * cantidad);
                Inventario.RestarInventario("madera", 4 * cantidad);
                return true;
            }
            else
            {
                return false;
            }
        }
    }








}



    

