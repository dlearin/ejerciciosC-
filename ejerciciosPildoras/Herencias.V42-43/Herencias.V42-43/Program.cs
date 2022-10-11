namespace Herencias.V42_43
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Caballo Babieca = new Caballo("Babieca");

            Humano Juan = new Humano("Juan");

            Gorila Copito = new Gorila("Copito");

            Mamiferos[] almacenaAnimales = new Mamiferos[3];

            almacenaAnimales[0] = Babieca;

            almacenaAnimales[1] = Juan;

            almacenaAnimales[2] = Copito;

            for(int i = 0; i< 3; i++)
            {

                almacenaAnimales[i].pensar();

            }

           /* almacenaAnimales[1].getNombre(); */

            /*Juan.getNombre(); */
        }
    }

    interface IMamiferosTerrestres
    {

        int numeroPatas();

    }

    interface IAnimalesYDeportes
    {
        string tipoDeporte();

        Boolean esOlimpico();
    }

    interface ISaltoConPatas
    {

        int numeroPatas();

    }


    class Mamiferos
        {

        public Mamiferos(String nombre)
        {

            nombreSerVivo = nombre;

        }

        public void respirar()
        {
          Console.WriteLine("puedo respirar");
        } 

        public void cuidarCrias()
        {
            Console.WriteLine("cuido crias");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre ser vivo es " + nombreSerVivo);
        }

        public virtual void pensar()
        {

            Console.WriteLine("pensamiento basico institntivo");

        }

        private String nombreSerVivo;



    }

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {



        }

        public void galopar()
        {
            Console.WriteLine("puedo galopar");
        }

       
        public int numeroPatas()
        {
            return 4;

        }

       public string tipoDeporte()
        {

            return "hipica";
        }

        public bool esOlimpico()
        {
            return true;
        }

    }

    class Humano : Mamiferos     
    {

        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }

        public override void pensar()
        { 

         Console.WriteLine("puedo pensar");

        }

    }

    class Gorila : Mamiferos
    {

        public Gorila(String nombreGorila) : base(nombreGorila) { }

        public override void pensar()
        {
            Console.WriteLine("pensamientos instintivos");

        }

        public void trepar()
        {

            Console.WriteLine("soy capaz de trepar");

        }

    }

}