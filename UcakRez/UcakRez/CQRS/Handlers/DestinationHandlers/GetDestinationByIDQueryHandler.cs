using DataAccessLayer.Concrete;
using UcakRez.CQRS.Queries.DestinationQueries;
using UcakRez.CQRS.Results.DestinationResults;

namespace UcakRez.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
                DayNight = values.DayNight,
                Price = (float)values.Price
            };
        }
    }
}
