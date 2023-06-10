using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        public static Singleton Instance { get { return _instance; } }

        // contructor es Privado, solo puedo acceder por medio de la propiedad
        private Singleton()
        {

        }
    }
}
