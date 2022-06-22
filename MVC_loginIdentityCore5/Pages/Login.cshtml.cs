using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVC_loginIdentityCore5.ViewModel;
using System.Threading.Tasks;

namespace MVC_loginIdentityCore5.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public Login model { get; set; }
        public LoginModel( SignInManager<IdentityUser> signInManager)
        {

            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync ( string returnurl =null )
        {
            if (ModelState.IsValid)
            {
                var IdentityResult = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (IdentityResult.Succeeded)
                {
                    if (returnurl == null | returnurl == "/")
                    {
                        return RedirectToPage("Index");

                    }
                    else
                    {
                        return RedirectToPage(returnurl);

                    }
                }


            }


            return Page();
        }

    }
}
