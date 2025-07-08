using System.Runtime.CompilerServices;

namespace Proyecto
{
    public class ed
    {
        /// <summary>
        ///muestra la clase ParteEDGAR que contiene métodos para mover, detener e iniciar un objeto.
        /// </summary>
        public ParteEDGAR end;
        internal class Program
        {
            static void Main(string[] args)
            {
                ed edgar = new ed();
                edgar.prueba1();
                
                barraT barra = new barraT();
                barra.prueba();

                jairo pp3 = new jairo();
                pp3.prueba3();
            }
        }
        public void prueba1()
        {
            end = new ParteEDGAR();
            end.Mover1();
            end.inicio();
        }
    }
    public class barraT
    {
        public claseBUENO bueno;

        public void prueba() {             
            bueno = new claseBUENO();
            bueno.Mover();
        }
    }
    public class jairo
    {
        public ParteJairo inicializacion;

        public void prueba3()
        {
            inicializacion = new ParteJairo();
            inicializacion.Comenzar();
        }
    }

}
