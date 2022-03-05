using System;

namespace plantilla
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instancias
            Caballo Babieca=new Caballo("Babieca");
            Humano ALvaro=new Humano("Alvaro");
            Gorila Copito = new Gorila("Copito");

            ALvaro.getNombre();



        }
    }

    interface IMamiferosTerrestres
    {
        int NumeroPatas();

    }

    class Mamiferos
    {
        private String nombreSerVivo;

        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo); 
        }

    }

    class Caballo : Mamiferos, IMamiferosTerrestres
    {

        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public int NumeroPatas()
        {
            return 4;
        }
    }

    class Humano : Mamiferos, IMamiferosTerrestres
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }

        public int NumeroPatas()
        {
            return 2;
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}