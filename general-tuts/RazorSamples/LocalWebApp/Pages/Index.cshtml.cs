using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;

namespace LocalWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IStringLocalizer<IndexModel> _stringLocalizer;

        public IndexModel(ILogger<IndexModel> logger, IStringLocalizer<IndexModel> stringLocalizer)
        {
            _logger = logger;
            _stringLocalizer = stringLocalizer;
        }

        public void OnGet()
        {
            ViewData["Welcome"] = _stringLocalizer["Welcome"].Value;
        }
    }
}