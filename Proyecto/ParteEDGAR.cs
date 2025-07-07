namespace Proyecto
{
    public class ParteJairo
    {
        public float velocidad;
        public void inicio()
        {
            Console.WriteLine("Inicio del movimiento de la banda.");
        }
        public void Mover1()
        {
            velocidad = 10.0f;
            Console.WriteLine("La banda esta en movimiento: " + velocidad);
        }
        public void Detener()
        {
            velocidad = 0.0f;
            Console.WriteLine("La velocidad  esta disminullendo gradualmente.");
            Console.WriteLine("Se a detenido por completo la banda");

        }


    }
}
