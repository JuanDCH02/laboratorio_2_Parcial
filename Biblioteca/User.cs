using System.Text;
using System.Text.RegularExpressions;

namespace Biblioteca
{
    public abstract class User
    {
        protected string password;
        protected string name;
        protected string surname;
        protected Status status;

        protected User(string password, string name, string surname)
        {
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.status = Status.Available;
        }

        public string Password
        {
            get {return password; }
            set { password = value;} 
        }
        public string Name
        {
            get {return name;}
            set { name = value; }
        }
        public string Surname
        {
            get {return surname;}
            set { surname = value;}
        } 
        public Status Status
        {
            get {return status;}
            set { status = value; }
        }  
        public virtual string Mostrar(User u)
        {
            string datos = string.Empty;

            if (u.status == Status.Available)
            {
                datos = $"{Name} {Surname}";
            }       
            return datos.ToString();
        }
    }   
}