using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.ViewModels;

namespace MyWebApp.Pages
{
    public class RegisterModel : PageModel
    {
        public Register Model { get; set; }
        public void OnGet()
        {
        }
    }
}
