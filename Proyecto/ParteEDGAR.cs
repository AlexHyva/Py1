namespace Proyecto
{
    public class ParteEDGAR
    {
        public float velocidad;
        public void inicio()
        {
            Console.WriteLine("Hola jefe");
        }
        public void Mover1()
        {
            Console.WriteLine("El programa comenzara pronto");
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
