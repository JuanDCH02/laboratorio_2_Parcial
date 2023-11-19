using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class DAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static DAO()
        {
            connectionString = @"Data Source= .;Initial Catalog=EmployeesDb;INtegrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        public static Employee validarSiExiste(string n, string sn, string psswd) 
        {
            Employee pepe = null;
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM employees WHERE name = '{n}' AND surname = 'sn' AND password = 'psswd'";
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pepe = new Employee(reader["password"].ToString(), reader["name"].ToString(), reader["surname"].ToString(), Employee.ConvertirARol(Convert.ToInt32(reader["role"])));
                        Employee.Employees.Append(pepe);           
                    }
                }

                return pepe ;
            }
            catch (Exception e)
            {

                throw;
            }
            finally { connection.Close(); }
        }
        public static void CargarEmpleadoSql(Employee p)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO Employees (name, surname, password, status)\n" +
                                        $"VALUES ('{p.Name}', '{p.Surname}', '{p.Password}', '{p.Status}' )";
            }
            catch (Exception ex)
            {
                Logic.RegistrarError("Error al cargar al empleado en la DB", ex);
            }
            finally { connection.Close(); }
        }
        public static int EliminarEmpleadoSql(Employee p)
        {
            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM Employees WHEN employee_id = {p.Id} AND name = {p.Name}";
                return 1;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
            catch(Exception ex)
            {
                Logic.RegistrarError("Error al Eliminar un empleado de la DB", ex );
                return -1;
            }      
            finally { connection.Close(); }          
        }
    }
}
