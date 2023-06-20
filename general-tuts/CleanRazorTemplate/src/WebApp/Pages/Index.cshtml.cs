using Application.SampleValues.Queries.GetAllValues;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ISender _mediator;
    public IndexModel(ILogger<IndexModel> logger,ISender mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    public async Task OnGetAsync()
    {
        var result = await _mediator.Send(new GetAllValuesQuery());
        ViewData["result"] = result;
    }
}
