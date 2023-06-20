using MediatR;

namespace Application.SampleValues.Queries.GetAllValues;

public class GetAllValuesQuery : IRequest<List<string>>
{
    
}

public class GetAllValuesQueryHandler : IRequestHandler<GetAllValuesQuery, List<string>>
{
    public GetAllValuesQueryHandler()
    {
            
    }
    
    public async Task<List<string>> Handle(GetAllValuesQuery request, CancellationToken cancellationToken)
    {
        var result = new List<string>();
        result.AddRange(new []{ "One", "Two", "Three"});
        return result;
    }
}