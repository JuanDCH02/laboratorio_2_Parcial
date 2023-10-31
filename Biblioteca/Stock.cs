using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Stock
    {
        public static List<Product> ProductStock { get; set; }
        static Stock() 
        {
            ProductStock = new List<Product>();
        }
        public static int CantidadMuebles()
        {
            int count = 0;
            foreach (Product i in ProductStock)
            {
                if (i.Status == ProductStatus.Available  && i.Name == "Mueble")
                {
                    count += 1;
                }
            }
            return count;
        }

        public static int CantidadVentiladores()
        {
            int count = 0;
            foreach (Product i in ProductStock)
            {
                if (i.Status == ProductStatus.Available && i.Name == "Ventilador")
                {
                    count += 1;
                }
            }
            return count;
        }
        public static string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product i in ProductStock)
            {
                if (i.Status == ProductStatus.Available) 
                {
                    sb.Append($"{i.Name} (id-");
                    sb.AppendLine($"{i.Id.ToString()})");
                }        
            }
            return sb.ToString();
        }
    }
}
