using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace MisClases
{
    public class Computadora
    {
        private int memoriaRam;
        private int capacidadDisco;
        private string procesador;
        private string sistemaOperativo;
        private List<string> programas;
        private int numeroDeSerie;

        //Constructor privado que solo instancia la lista de programas.
        private Computadora()
        {
            this.programas = new List<string>();
        }

        //Constructor público que asigna valores a todos sus campos excepto a la lista de programas.
        public Computadora(int memoriaRam, int capacidadDisco, string procesador, string sistemaOperativo, int numeroDeSerie)
           : this()
        {
            this.memoriaRam = memoriaRam;
            this.capacidadDisco = capacidadDisco;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;   
            this.numeroDeSerie = numeroDeSerie;
        }

        //Todas las propiedades son de solo lectura y retornan el valor de los atributos que hacen referencia,
        //excepto Programas, esta propiedad retorna un string con todos los nombres de los programas concatenados.
        
        public int NumeroDeSerie { get => numeroDeSerie; set => numeroDeSerie = value; } 
        public int MemoriaRam { get => memoriaRam; }
        public int CapacidadDisco { get => capacidadDisco; }
        public string Procesador { get => procesador; }
        public string SistemaOperativo { get => sistemaOperativo; }
        
       
        public string Programas
        {
            get
            {
                StringBuilder todos = new StringBuilder();

                for (int i = 0; i < programas.Count; i++)
                {
                    todos.Append(programas[i]);
                    if(i < programas.Count - 1)
                    {
                        todos.Append( " - ");
                    }
                }
                return todos.ToString();
            }
        }


        //Método get que retorna la lista de programas.
        public List<string> GetProgramas()
        {
            return programas;
        } 

        //Método set que se encarga de agregar un programa a la lista.
        public void SetPrograma(string programa)
        {
            this.programas.Add(programa);
        }

        //Método static ListadoDeProcesadores() que retorna una lista de al menos 5 tipos de procesadores.
        public static List<string> ListadoDeProcesadores()
        {
            List<string> listaProcesadores = new List<string>() 
            { "procesador1", "procesador2", "procesador3", "procesador4", "procesador5" };

            return listaProcesadores;
        }


        //Otros metodos

        public override string ToString()
        {
            return $"{procesador} - {memoriaRam} - {sistemaOperativo}";
        }

        public void CargarProgramasDesdeUnString(string programas)
        {
            this.programas.AddRange(programas.Split(" - "));
        }


        public override bool Equals(object pc)
        {
            Computadora pcComparar = pc as Computadora;

            return pcComparar is not null && this.numeroDeSerie == pcComparar.numeroDeSerie;
        }





    }
}
