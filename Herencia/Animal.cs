using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //abstract   definicion que no podemos instanciar
    abstract class Animal
    {
        public string Indentificador { get; set; }
        public string Nombre { get; set; }

        // la utilizamos para modificar el metodo, los metodos abstractos no tienen implementacion.
        abstract public string desplazar();

    }
}
