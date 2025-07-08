using Proyecto;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using static Proyecto.claseIVANNA;

namespace Proyecto
{
    public class ed {
        public ParteEDGAR end;
        public claseBUENO bueno;
        public ParteJairo jairo;
        public claseIVANNA sensor;
        internal void punto1()
        {
            end = new ParteEDGAR();
            ParteEDGAR.presentacion presentacion = new ParteEDGAR.presentacion();
            presentacion.inicio();
            presentacion.Mover1();
           ParteEDGAR.ensendido ensendido = new ParteEDGAR.ensendido();
            ensendido.ensender();

        }
        internal void punto2()
        {
            bueno = new claseBUENO();
            claseBUENO.Mover mover = new claseBUENO.Mover();
            mover.Mover1();
        }
        internal void prueba2()
        {
            sensor = new claseIVANNA();
            claseIVANNA.Sensores sensores = new claseIVANNA.Sensores();
            sensores.detectarObjeto();
            sensores.Velocidad();
            Console.WriteLine("en el almasen hay 5 objetos");
            sensores.contador(5);
        }
        public void punto3()
        {
            jairo = new ParteJairo();
            ParteJairo.comenzar1 comenzar = new ParteJairo.comenzar1();
            comenzar.Comenzar();
        }

    }
}
