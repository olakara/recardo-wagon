using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;

namespace LocalWebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IStringLocalizer<PrivacyModel> _stringLocalizer;

        public PrivacyModel(ILogger<PrivacyModel> logger, IStringLocalizer<PrivacyModel> stringLocalizer)
        {
            _logger = logger;
            _stringLocalizer = stringLocalizer;
        }

        public void OnGet()
        {
            ViewData["Title"] = _stringLocalizer["Title"].Value;
        }
    }
}