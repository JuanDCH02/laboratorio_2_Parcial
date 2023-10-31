using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Employee : User
    {
        private EmployeeRole puesto;
        private uint id;
        private static uint contadorId;
        static Employee()
        {
            contadorId = 1;
        }

        public Employee(string password,string name, string surname, EmployeeRole puesto) 
        :base(password, name, surname)
        {
            this.puesto = puesto;
            id = contadorId;
            contadorId+=1;
        }
        public EmployeeRole Puesto
        { 
            get { return puesto; }
            set { puesto = value; }
        }
        public uint Id
        { 
            get { return id; }
            set { id = value; }
        }

        public override string Mostrar() 
        {
            StringBuilder sb = new();
            sb.Append(base.Mostrar());
            sb.AppendLine($",{Puesto} #{Id}");
            return sb.ToString();
        }
        public static bool operator ==(Employee a, uint id)
        {
            return a.id == id;
        }
        public static bool operator !=(Employee a, uint id)
        {
            return !(a.id == id);
        }
    }
}
