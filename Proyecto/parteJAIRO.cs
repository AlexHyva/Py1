namespace Proyecto
{
    public class ParteJairo
    {
        public float velocidadd;
        public void inicio()
        {
            Console.WriteLine("Inicio del movimiento de la banda.");
        }
        public void Mover1()
        {
            velocidadd = 10.0f;
            Console.WriteLine("La banda esta en movimiento: " + velocidadd);
        }
        public void Detener()
        {
            velocidadd = 0.0f;
            Console.WriteLine("La velocidad  esta disminullendo gradualmente.");
            Console.WriteLine("Se a detenido por completo la banda");

        }



    }
}

