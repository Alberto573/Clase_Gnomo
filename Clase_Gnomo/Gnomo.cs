using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Gnomo
{
    public class Gnomo
    {
        
        protected string nombre;

        
        protected string color;

        protected int vida;

        public Gnomo(string nombre, string color)
        {
            this.nombre = nombre;
            this.color = color;
        }
    }

}
