using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Gnomo
{
    public class GnomoLadron : Gnomo
    {

        private string especialidad;

        public GnomoLadron(string nombre, string color, string especialidad)
            : base(nombre, color)
        {
            this.especialidad = especialidad;
        }


        public bool robarObjeto(Objeto objeto)
        {

            if (objeto == null)
                return false;


            return true;
        }
    }
}
