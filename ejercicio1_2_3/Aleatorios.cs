using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_2_3
{
    internal class Aleatorios
    {
        // se manda a llamar  un objeto tipo random 
        private Random _random;
        //se inicializa la variable en el contrsuctor 
        public Aleatorios()
        {
            this._random = new Random();
        }
        public int generarNumeroAleatorio(int min, int max)
        {
            if (min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }
            //sigenerar un numero del 1 a 9 , nunca llega al 9, se soluciona sumando 1
            // el minimo no puede ser mayor al maximo
            return this._random.Next(min, max) + 1;
        }
        public int[] generarNumerosAleatorios(int longitud,int min,int max)
        {

            if (longitud <= -0)
            {
                return null;
            }
            int[] numeros = new int[longitud];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = generarNumeroAleatorio(min, max);
            }
            return numeros;
        }


    }


    }
