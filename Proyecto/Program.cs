using System.Runtime.CompilerServices;

namespace Proyecto
{
    public class ed
    {
        /// <summary>
        ///muestra la clase ParteEDGAR que contiene métodos para mover, detener e iniciar un objeto.
        /// </summary>
        public ParteEDGAR end;

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
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            barraT barra = new barraT();
            barra.prueba();
            ed edgar = new ed();
            edgar.prueba1();
        }
    }
}
