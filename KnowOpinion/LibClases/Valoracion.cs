using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    class Valoracion
    {
        private int valor;
        public int Valor
        {
            get { return valor; }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    this.valor = value;
                }
            }
        }

        private string opinion;
        public string Opinion
        {
            get { return opinion; }
            set { this.opinion = value; }
        }
      
    }
}
