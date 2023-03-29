using Animalia_Explorer.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Animalia_Explorer.Pages.Animales
{
    public class ListaModel : PageModel
    {
        public List<Animal> Animales { get; set; }
        public ListaModel()
        {
            Animales = new List<Animal>
            {
                new Perro("Morty", 3),
                new Gato("Script", 2),
            };
        }
        public void OnGet()
        {
            Animales = new List<Animal>
            {
                new Perro("Morty", 3),
                new Gato("Script", 2),
            };
        }
    }
}
