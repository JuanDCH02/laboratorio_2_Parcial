using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Product
    {
        protected string name;
        protected Status status;
        protected ulong id;
        protected static ulong contadorId;
        static Product()
        {
            contadorId = 1000;
        }
       public Product(string nombre)
        {
            name = nombre;
            id = contadorId;
            contadorId += 1;
            status = Status.Available;
        }
        public ulong Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }

        public static bool operator ==(Product a, ulong id)
        { return a.id == id; }
        public static bool operator !=(Product a, ulong id)
        { return !(a.id == id); }
    }
}
