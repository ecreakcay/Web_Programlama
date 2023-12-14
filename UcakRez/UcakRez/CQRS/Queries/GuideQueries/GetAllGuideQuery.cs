using MediatR;
using UcakRez.CQRS.Results.GuideResults;

namespace UcakRez.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
