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
        public static List<Employee> Employees {  get; set; }

        static Employee()
        {
            contadorId = 1;
            Employees = new List<Employee>();
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

        public static string Mostrar(Employee u) 
        {
            string datos = "";

            if (u.status == Status.Available)
            {
                datos = $"{u.Name} {u.Surname}, {u.Puesto}(#{u.Id})"; 
            }
            return datos.ToString();
        }
        public static EmployeeRole ConvertirARol(int num)
        {
            
            if(num == 0)
            {
                return EmployeeRole.Operador;
            }
            else { return EmployeeRole.Supervisor; }
        }
        public static bool ValidarAltaEmpleado(Employee u)
        {
            foreach(Employee empleado in Employees)
            {
                if(empleado.status == Status.Available && u.name == empleado.name && u.surname == empleado.surname && u.password == empleado.password)
                {
                    u.Status = Status.NotAvailable;
                    return true;
                }
            }
            return false;
        }
        public static Employee? BuscarPorID(int id)
        {
            foreach(Employee empleado in Employees)
            {
                if(id == empleado.id && empleado.status == Status.Available)
                {
                    return empleado;
                }
            }
            return null;
        }

        public static bool operator ==(Employee a, uint id)
        { return a.id == id; }
        public static bool operator !=(Employee a, uint id)
        { return !(a.id == id); }
    }
}
