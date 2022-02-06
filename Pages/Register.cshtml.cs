using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.ViewModels;

namespace MyWebApp.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Register Model { get; set; }

        public UserManager<IdentityUser> userManager;
        public SignInManager<IdentityUser> signInManager;

        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) 
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync() 
        {
            if (ModelState.IsValid) 
            {
                var user = new IdentityUser()
                {
                    UserName = Model.Username
                };

                var result = await userManager.CreateAsync(user, Model.Password);
                if (result.Succeeded) 
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }

                foreach (var error in result.Errors) 
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return Page();
        }
    }
}
