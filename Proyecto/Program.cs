using System.Runtime.CompilerServices;

namespace Proyecto
{
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
        }
    }
}
