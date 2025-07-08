namespace Proyecto
{
    public class ParteJairo
    {
        public float velocidadd;
        public void Comenzar()
        {
            Console.WriteLine("Inicio del movimiento de la banda.");
            velocidadd = 10.0f;
            Console.WriteLine("La banda esta en movimiento: " + velocidadd);
            velocidadd = 0.0f;
            Console.WriteLine("La velocidad  esta disminullendo gradualmente.");
            Console.WriteLine("Se a detenido por completo la banda");
        }
       

    }
}

