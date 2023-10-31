using System.Text;

namespace Biblioteca
{
    public abstract class User
    {
        protected string password;
        protected string name;
        protected string surname;

        protected User(string password, string name, string surname)
        {
            this.password = password;
            this.name = name;
            this.surname = surname;
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
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} {Surname}");
            return sb.ToString();
        }
    }   
}