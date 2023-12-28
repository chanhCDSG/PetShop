using PetShop.Models;
//using Coffee.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Coffee.Web.Pages
{
    public class CreatePetModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        [BindProperty]
        public Pet? Pet { get; set; }
        public CreatePetModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPostInsert()
        {
            if(!ModelState.IsValid)
            {
                Console.WriteLine("Can't add");
                return Page();
            }
            if(Pet != null) 
            {
                Console.WriteLine(Pet.Name);
                _context.pets.Add(Pet);
                _context.SaveChanges();
            }
            return RedirectToPage("./Success");
        }
    }
}
