namespace Proyecto
{
    public class parteJairo
    {
        public class comenzar1
        {
            public float velocidadd;

            public void Comenzar()
            {
                Console.WriteLine("Inicio del movimiento de la banda.");
                velocidadd = 10.0f;
                Console.WriteLine("La banda está en movimiento: " + velocidadd);
                velocidadd = 0.0f;
                Console.WriteLine("La velocidad está disminuyendo gradualmente.");
                Console.WriteLine("Se ha detenido por completo la banda");
            }
        }
    }

}
