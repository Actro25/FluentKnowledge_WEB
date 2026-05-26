using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FluentKnowledge_WEB.Pages;
public class IndexModel : PageModel
{
    public IActionResult OnGet()
    {
        return RedirectToPage("/Welcome/Index");
    }
}