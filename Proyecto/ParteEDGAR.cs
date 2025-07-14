namespace Proyecto
{
    public class ParteEDGAR
    {
        public class presentacion
        {
            public presentacion()
            {
                inicio();
                Mover1();
            }

            public void inicio()
            {
                Console.WriteLine("Hola jefe");
            }
            public void Mover1()
            {
                Console.WriteLine("El programa comenzará pronto");
            }
        }

        public class ensendido
        {
            public void ensender()
            {
                Console.WriteLine("La banda se ha encendido");
            }
        }

        public class ErenciaEd : ParteEDGAR
        {
            public void sobrecarga()
            {
                Console.WriteLine("\n⚠ Emergencia detectada: sobrecarga. El sistema se detiene.\n");
            }
        }
    }
}
