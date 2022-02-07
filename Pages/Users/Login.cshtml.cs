using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Model;

namespace MyWebApp.Pages.Users
{
    public class LoginModel : PageModel
    {

        private readonly MyWebApp.Data.MyWebAppContext _context;

        public LoginModel(MyWebApp.Data.MyWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {

            for (int i = 0; i < _context.User.Count(); i++) 
            {
                var dbUser = _context.User.FirstOrDefault(n => n.Username == User.Username);
                 
                if (dbUser is not null)
                {
                    if (dbUser.Password.Equals(User.Password)) 
                    {
                        return RedirectToPage("./Index");
                    }
                }
            }

            return Page();   
        }
    }
}
