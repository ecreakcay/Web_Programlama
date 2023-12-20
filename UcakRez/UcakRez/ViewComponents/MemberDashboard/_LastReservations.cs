using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UcakRez.ViewComponents.MemberDashboard
{
    public class _LastReservations : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _LastReservations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetLast4Destinations();
            return View(values);
        }


    }
}
