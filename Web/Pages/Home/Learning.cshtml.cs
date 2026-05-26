using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FluentKnowledge_WEB.Pages.Home.Learning;

public class LearningModel : PageModel
{
    private readonly ILogger<LearningModel> _logger;

    public LearningModel(ILogger<LearningModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
