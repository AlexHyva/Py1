namespace Proyecto
{
    public class claseIVANNA
    {
        public class Sensores
        {
            private claseBUENO _claseBUENO = new claseBUENO();

            public bool detectarObjeto()
            {
                Console.WriteLine("Sensor: Se detectó objeto...");
                return true;
            }

            public bool Velocidad()
            {
                Console.WriteLine("Sensor: Calculando velocidad...");
                return true;
            }

            public void contador(float objetosDetectados)
            {
                float cajasActuales = _claseBUENO.cajas;

                if (objetosDetectados == cajasActuales)
                {
                    Console.WriteLine("Sensor: Cantidad correcta de objetos.");
                }
                else if (objetosDetectados > cajasActuales)
                {
                    Console.WriteLine("Sensor: Hay demasiados objetos.");
                }
                else
                {
                    Console.WriteLine("Sensor: Faltan objetos.");
                }
            }
        }
    }
}
