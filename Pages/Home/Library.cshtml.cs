
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FluentKnowledge_WEB.Pages.Home.Library;

partial class LibraryModel : PageModel
{
    private readonly ILogger<LibraryModel> _logger;

    public LibraryModel(ILogger<LibraryModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}