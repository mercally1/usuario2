using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    public class Persona
    {
        private int id;
        private string name;
        private string type;
        private int edad;
        /*s
        // se invoca automaticamente, tiene que tener el mismo nombre de la clase
        //
        public Persona()
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("soy el constructor");
            }
           
        }
        */
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Edad { get => edad; set => edad = value; }

        public void crearPersona(int Id, string Name, string Type)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            this.edad = Edad;
        }

        public string crearPersona()
        {
            return " id:" + Id + "\n" + "Nombre:" + Name + "\n" + "tipo de usuario:" + Type;
        }

    }
}
