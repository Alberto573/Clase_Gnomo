using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Gnomo
{
    public class Objeto
    {

        private string tipo;


        private double valor;

        public Objeto(string tipo, double valor)
        {
            this.tipo = tipo;
            this.valor = valor;
        }

        public string Tipo
        {
            get { return tipo; }
        }

        public double Valor
        {
            get { return valor; }
        }
    }
}
