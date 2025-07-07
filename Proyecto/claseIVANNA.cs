namespace Proyecto
{
    public class claseIVANNA
    {
        // sensores
        public class sensores()
        {

            public bool detectarObjeto()
            {
                Console.WriteLine("Sensor: Se detecto Objeto...");
                return true;
            }

            public bool Velocidad()
            {
                Console.WriteLine("Sensor: Calculando Velocidad...");
                return true;
            }

            public void contador(float Objeto)
            {
                if (Objeto == 8)
                {
                    Console.WriteLine("Sensor: Contando Ojetos...");
                }
                else if(Objeto > 0)
                {
                    Console.WriteLine("Sensor: son demassiados objetos...");
                }
                else
                {
                    Console.WriteLine("Sensor: Faltan objetos...");
                }
               
                
            }
        }

       
    }
}
