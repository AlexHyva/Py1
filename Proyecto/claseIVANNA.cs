namespace Proyecto
{
    public class claseIVANNA
    {
        // sensores
        public class Sensores()
        {
            public claseBUENO _claseBUENO;
           

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
                _claseBUENO = new claseBUENO();
                if (Objeto == _claseBUENO.cajas)
                {
                    Console.WriteLine("Sensor: Contando Ojetos...");
                }
                else if(Objeto > _claseBUENO.cajas)
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
