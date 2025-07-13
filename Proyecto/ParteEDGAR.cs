namespace Proyecto
{
    public class ParteEDGAR
    {
        public class presentacion { 
        
            public presentacion()
            {
                this.inicio();
                this.Mover1();
            }

        public void inicio()
        {
            Console.WriteLine("Hola jefe");
        }
        public void Mover1()
        {
            Console.WriteLine("El programa comenzara pronto");
        }
        }
        public class ensendido
        {
            public void ensender()
            {
                Console.WriteLine("La vanda se ha encendido");
            }
            
        }
        public class ErenciaEd : presentacion
        {
            public void sobrecarga()
            {
                base.inicio();
                Console.WriteLine("\n!emergancia se sobrecarga\n");
            }
        }

    }
}
