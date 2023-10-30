using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_2_3
{
    internal class Concesionario
    {
        private coche[] _coches;
        private int _limite;
        private int _numcoches;

        public Concesionario(int limite)
        {
            this._limite = limite;
            this._coches = new coche[limite];
            _numcoches = 0;

        }
        public void anadirCoche(coche c)
        {
            if (c != null && _numcoches < _coches.Length) {
                _coches[_numcoches] = c;
                _numcoches++;
            }   
        }
        public void mostrarCoches()
        {
            for (int i = 0; i < _numcoches; i++) 
            {
                Console.WriteLine(_coches[i].ToString());
            }
        }
        public void vaciarCoches()
        {
            this._coches = new coche[_limite];
            _numcoches = 0; 
        }
        public void eliminarCoche(coche c)
        {
            if (c != null && _numcoches != 0)
            {
                int posicion = -1;

                for (int i = 0; i < _numcoches; i++)
                {
                    if (c.id == _coches [i].id)
                    {
                        posicion = i;
                    }
                }
                if (posicion == -1)
                {
                    Console.WriteLine(" el coche no existe");
                }
                else
                {
                    _coches[posicion] = null;
                    for (int i = posicion; i < _numcoches; i++)
                    {
                        _coches[i] = _coches[i + 1];
                    }
                }

            }
        }
    }
}
