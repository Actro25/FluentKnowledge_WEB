
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FluentKnowledge_WEB.Pages.Home.Editing;

public class EditingModel : PageModel
{
    private readonly ILogger<EditingModel> _logger;

    public EditingModel(ILogger<EditingModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}