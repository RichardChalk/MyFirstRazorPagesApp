using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstRazorPagesApp.Pages
{
    public class ChampionsModel : PageModel
    {
        public class ChampionViewModel
            {

            public int Id { get; set; }
            public string Name { get; set; }
            public int Damage { get; set; }
        }

        public List<ChampionViewModel> Champions { get; set; } = new List<ChampionViewModel>(); 
        public void OnGet()
        {
            // Tänk att denna lista finns egentligen i en dbContext!
            Champions.Add(new ChampionViewModel
            {
                Id = 1, Name = "Annie", Damage = 100,
            });
            Champions.Add(new ChampionViewModel
            {
                Id = 2,
                Name = "Brand",
                Damage = 110,
            });
            Champions.Add(new ChampionViewModel
            {
                Id = 3,
                Name = "Calista",
                Damage = 130,
            });
        }
    }
}
