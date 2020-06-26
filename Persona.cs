namespace _26_6_2020
{
    public class Persona
    {
        private int edad;
        private string nombre;

        public Persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public int Edad { get => edad; }
        public string Nombre { get => nombre; }
    }
}