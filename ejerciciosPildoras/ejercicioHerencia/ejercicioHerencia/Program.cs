namespace ejercicioHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Coche  miCoche = new Coche("Toyota");

            Avion  miAvion = new Avion("Boing");

            Vehiculo[] coleccionVehiculos = new Vehiculo[2];

            coleccionVehiculos[0] = miCoche;

            coleccionVehiculos[1] = miAvion;

           for (int i = 0; i<3; i++ )
            {

                Vehiculo[i].

            }

        }
    }

    class Vehiculo
    {

        public Vehiculo(String nombreAparato)
        {

            nombre = nombreAparato;

        }

        public virtual void Conducir()
        {

            Console.WriteLine("Conduzco");

        }

        public void arrancarMotor()
        {

            Console.WriteLine("Enciendo motores");

        }

        public void pararMotor()
        {

            Console.WriteLine("paro motores");

        }

        public void getNombre()
        {

            Console.WriteLine("la funcion es" + nombre); ;

        }

        private String nombre;


    }

    class Coche : Vehiculo
    {

        public Coche(String nombreVehiculo) : base(nombreVehiculo)
        {


        }

        public override void Conducir()
        {
            Console.WriteLine("Conduzco sobre cuatro ruedas y asfalto");
        }

    }

    class Avion : Vehiculo
    {

        public Avion(String nombreVehiculo) : base(nombreVehiculo)
        {

        }

        public override void Conducir()
        {
            Console.WriteLine("Conduzco sobre el cielo");
        }

    }
}