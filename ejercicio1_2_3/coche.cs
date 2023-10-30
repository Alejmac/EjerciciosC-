using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_2_3
{
    internal class coche
    {
        private int _id;
        private string _marca;
        private string _modelo;
        private double _km;
        private Double _precio;

        public coche( int  id,string marca,string modelo, double km, double precio)
        {
            this._id = id;
            this._marca = marca;    
            this._modelo = modelo;  
            this._km = km;
            this._precio = precio;

        }
        public int id { get => _id; set => _id = value; }
        public string marca { get => _marca; set => _marca = value; }
        public string modelo { get => _modelo; set => _modelo = value; }
        public double km { get => _km; set => _km = value; }
        public double precio { get => _precio; set => _precio = value; }

        public override string ToString()
        {
        return "marca " + marca+"modelo" + modelo+"precio"+precio;
            }

    }
   
}
