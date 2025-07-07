namespace Proyecto
{
    public class ParteEDGAR
    {
        public float velsosidad;
        public void inicio()
        {
            Console.WriteLine("Inicio del movimiento.");
        }
        public void Mover1()
        {
            velsosidad = 10.0f;
            Console.WriteLine("La velocidad es: " + velsosidad);
        }
        public void Detener()
        {
            velsosidad = 0.0f;
            Console.WriteLine("La velocidad disminulle.");
            Console.WriteLine("Se a detenido");

        }
       

    }
}
