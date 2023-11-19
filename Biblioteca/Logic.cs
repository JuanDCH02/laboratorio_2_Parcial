using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Logic
    {
        /// <summary>
        /// Valido que algun string solo contenga letras
        /// </summary>
        /// <param name="msj"></param> string a comprobar
        /// <returns></returns> false si contiene algun otro caracter que no sea letras
        public static bool ValidarString(string msj)
        {
            bool rtn = false;
            
            if (Regex.IsMatch(msj, "^[a-zA-Z]+$"))
            {
                rtn = true;
            }
            return rtn;
        }
        /// <summary>
        /// Metodo que crea una carpeta en el escritorio, especificando la hora y el mensaje de 
        /// alguna excepcion que le pasemos
        /// </summary>
        /// <param name="lugarError"></param>lugar del error del codigo
        /// <param name="ex"></param>excepcion que se produjo
        public static void RegistrarError(string lugarError, Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha y Hora del error: {DateTime.Now}. El error ocurrio en: {lugarError}, el mensaje de error es: '{ex.Message}'");
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Errores.txt\\";
            File.AppendAllText(path,sb.ToString());
        }
        //public static string MostrarEmpleados()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    foreach(Employee u in Employee.Employees)
        //    {
        //        stringBuilder.AppendLine(u.Mostrar(u));
        //    }
        //    return stringBuilder.ToString();
        //}
    } 
}
