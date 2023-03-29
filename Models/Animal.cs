using Animalia_Explorer.models;

namespace Animalia_Explorer.models
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        protected Animal(string nombre, int edad)
        {

            Nombre = nombre;
            Edad = edad;
        }
        public abstract string EmitirSonido();
    }
}
