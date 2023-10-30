using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    internal class Bebida
    {
        public string Nombre { get; set; }
        public int cantidad { get; set; }

        public Bebida(string Nombre , int cantidad) { 
        
            this.Nombre = Nombre;
            this.cantidad = cantidad;   
        }
        public void beberse(int cuantoBebio)
        {
            this.cantidad -=  cuantoBebio;
        }


    }
}
