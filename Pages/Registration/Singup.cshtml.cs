
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FluentKnowledge_WEB.Pages.Registration.Signup;

public class SignupModel : PageModel
{
    private readonly ILogger<SignupModel> _logger;

    public SignupModel(ILogger<SignupModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {
        
    }
}