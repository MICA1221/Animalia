namespace Animalia_Explorer.models
{

    public class Perro : Animal, IAcciones
    {
        public Perro(string nombre, int edad) : base(nombre, edad)
        {
        }
        public override string EmitirSonido()
        {
            return "Guau!";
        }
        public string Caminar()
        {
            return "El perro está caminando.";
        }
        public string Comer()
        {
            return "El perro está comiendo.";
        }
    }
}