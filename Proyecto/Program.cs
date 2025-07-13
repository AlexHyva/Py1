using Proyecto;
using System;

namespace Proyecto
{
    public class Program
    {
        public class entes
        {
            public ParteEDGAR end = new ParteEDGAR();
            public claseBUENO bueno = new claseBUENO();
            public parteJairo jairo = new parteJairo();
            public claseIVANNA sensor = new claseIVANNA();

            public void punto1()
            {
                ParteEDGAR.presentacion presentacion = new ParteEDGAR.presentacion();
                ParteEDGAR.ensendido encender = new ParteEDGAR.ensendido();
                encender.ensender();
            }

            public void punto2()
            {
                claseBUENO.Mover mover = new claseBUENO.Mover();
                mover.Mover1();
            }

            public void prueba2()
            {
                claseIVANNA.Sensores sensores = new claseIVANNA.Sensores();
                sensores.detectarObjeto();
                sensores.Velocidad();
                Console.WriteLine("En el almacén hay 5 objetos\n");
                sensores.contador(5);
            }

            public void punto3()
            {
                ParteEDGAR.ErenciaEd emergencia = new ParteEDGAR.ErenciaEd();
                emergencia.sobrecarga();
            }

            public void punto4()
            {
                parteJairo.comenzar1 comenzar = new parteJairo.comenzar1();
                comenzar.Comenzar();
            }
        }
        static void Main(string[] args)
        {
            entes sistema = new entes();

            Console.WriteLine("\n=== INICIO DEL SISTEMA ===\n");

            sistema.punto1();   // Presentación y encendido
            sistema.punto2();   // Movimiento de cajas
            sistema.prueba2();  // Sensores
            sistema.punto3();   // Emergencia
            sistema.punto4();   // Movimiento de banda

            Console.WriteLine("\n=== FIN DEL PROGRAMA ===");
        }
    }
   
} 

