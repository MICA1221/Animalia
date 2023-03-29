namespace Animalia_Explorer.models
{
    public class Gato : Animal, IAcciones
    {
        public Gato(string nombre, int edad) : base(nombre,edad)
            {
            }
        public override string EmitirSonido() 
        {
            return "Miau!";
        }
        public string Caminar() 
        {
            return "El gato está caminando";
        }
        public string Comer() 
        {
            return "El gato está comiendo";
        }
    }
}
